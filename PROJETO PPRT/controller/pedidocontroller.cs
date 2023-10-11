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
using modelo;
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
using System.Runtime.Remoting.Contexts;

namespace controller
{
    public class pedidocontroller
    {
        bool resultado = false;
        string sql;
        conexao con = new conexao();
        // public static void GerarPDF(DataGridView dataGridView)
        //{
        //     throw new NotImplementedException();
        // }


        public bool cadastrarPedido(pedidomodelo pm, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1:// inserir dados


                        sql = "insert into pedido(cliente,emissao,status,entrega,endereco)" +
                                                    "values(@cliente,@emissao,@status,@entrega,@endereco)";
                        break;

                    case 2: // atualizar

                        sql = "update pedido set cliente=@cliente,emissao=@emissao,status=@status,entrega=@entrega,endereco=@endereco where idpedido=@id";
                        break;
                    case 3:
                        sql = "DELETE from pedido where idpedido=@id";
                        break;
                }
                string[] campos = { "@cliente", "@emissao", "@status", "@entrega", "@endereco" };
                object[] valores = { pm.cliente, pm.emissao, pm.status, pm.entrega, pm.endereco };
                if (con.cadastrar(pm.idpedido, campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
        public bool excluirproduto(int idproduto)
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexao();
            string sql = "delete from produto where idproduto =" + idproduto;
            sqlcon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlcon);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = sql;
            if (mySqlCommand.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            return resultado;
        }
        public class GerarPDF
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

            
        }
    }
   

}










