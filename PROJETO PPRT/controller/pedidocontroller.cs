using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gitcake;
using modelo;
using MySql.Data.MySqlClient;
using PdfSharp;//biblioteca gerar pdf
using PdfSharp.Drawing;// para desenho
using PdfSharp.Pdf;// conversao
using controller;
using System.Drawing.Printing;
using Org.BouncyCastle.Asn1.Crmf;
using Google;
using PdfSharp.Pdf.AcroForms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Application = System.Net.Mime.MediaTypeNames.Application;

namespace controller
{
    public class pedidocontroller
    {
        bool resultado = false;// verificar o resultado 
        // chamo o metodo conexao
        string sql;
        conexao conn = new conexao();
         public long ultimoidcadastrado;
       // itemmodelo it = new itemmodelo();
       
        public long cadastrapedido(pedidomodelo pedi, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1:// inserir dados


                        sql = "insert into pedido(emissao,cliente,statuspedido,entrega,endereco,total)" +
                                                    "values(@emissao,@cliente,@statuspedido,@entrega,@endereco,@total)";
                        break;

                    case 2: // atualizar

                        sql = "update pedido set emissao=@emissao,cliente=@cliente,statuspedido=@statuspedido,entrega=@entrega,endereco=@endereco where idpedido=@id";
                        break;
                    // case 3:
                    //   sql = "DELETE from pedido where idpedido=@id";
                    // break;
                    default:
                        break;
                }
                string[] campos = { "@emissao", "@cliente", "@statuspedido", "@entrega", "@endereco", "@total" };
                object[] valores = { pedi.emissao, pedi.cliente, pedi.statuspedido, pedi.entrega, pedi.endereco, pedi.total };

                ultimoidcadastrado = conn.cadastrapedido(pedi.idpedido, campos, valores, sql);
                if (ultimoidcadastrado >= 1)
                {
                    return ultimoidcadastrado;
                }
                
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public bool atualizaitem(int iditem)
        {
            bool resultado = false;
            MySqlConnection sqlcon = conn.getConexao();
            string sql = "UPDATE item SET idpedido =" + Convert.ToInt32(ultimoidcadastrado) + "WHERE iditem=@iditem";
            //string sql = "UPDATE item SET idpedido WHERE iditem =" + iditem;
            sqlcon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlcon);
            mySqlCommand.Parameters.AddWithValue("@iditem", iditem);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = sql;
            if (mySqlCommand.ExecuteNonQuery() >= 1)
            {
                return resultado;
            }
            resultado = true;
            return resultado;
        }

        /*public bool cadastrarPedido(pedidomodelo pedi)
        {
            bool resultado = false;
            string sql = "insert into pedido(idpedido,emissao,cliente,statuspedido,entrega,endereco,total)values('" + pedi.idpedido + "','" + pedi.emissao + "','" + pedi.cliente + "','" + pedi.statuspedido + "','" + pedi.entrega + "','" + pedi.endereco + "','" + pedi.total + "')";

            MySqlConnection sqlcon = conn.getConexao();
            sqlcon.Open(); // abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlcon.Close();//fecho a conexao
            return resultado;// retorno o valor
        }*/


        // public static void GerarPDF(DataGridView dataGridView)
        //{
        //     throw new NotImplementedException();
        // }

        /* public class GerarPDF
         {
             private Button printButton = new Button();
             private DataGridView dataGridView1 = new DataGridView();
             private PrintDocument printDocument1 = new PrintDocument();

             public GerarPDF()
             {
                 // Exemplo de dados para o DataGridView
                 dataGridView1.Columns.Add("idproduto", "coluna 1");
                 dataGridView1.Columns.Add("Column2", "Coluna 2");
                 dataGridView1.Rows.Add("Linha1Col1", "Linha1Col2");
                 //dataGridView1.Rows.Add("Linha2Col1", "Linha2Col2");

                 printButton.Text = "Imprimir";
                 printButton.Click += printButton_Click;
                 printDocument1.PrintPage += printDocument1_PrintPage;

                 Controls.GetInstance(dataGridView1);
                 Controls.GetInstance(printButton);
             }

             private void printButton_Click(object sender, EventArgs e)
             {
                 printDocument1.Print();
             }

             private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
             {
                 Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
                 dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
                 e.Graphics.DrawImage(bm, 0, 0);
             }

             [STAThread]
             public static void Main()
             {
                 //Application.EnableVisualStyles();
                // Application.SetCompatibleTextRenderingDefault(false);
                 //   Application.Run(new GerarPDF());
             }
         }*/
    }
   

}










