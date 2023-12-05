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
        conexao conn = new conexao();// chamo o metodo conexao
        string sql;
        public bool cadastrarpedido(pedidomodelo pedi, int operacao)
        {
            try
            {
                switch (operacao)
                {
                    case 1:// inserir dados


                        sql = "insert into pedido(emissao,cliente,idproduto,quantidade,statuspedido,entrega,endereco,total)" +
                                                    "values(@emissao,@cliente,@idproduto,@quantidade,@statuspedido,@entrega,@endereco,@total)";
                        break;

                    case 2: // atualizar

                        sql = "update pedido set emissao=@emissao,cliente=@cliente,idproduto=@idproduto,quantidade=@quantidade,statuspedido=@statuspedido,entrega=@entrega,endereco=@endereco,total=@total where idpedido=@id";
                        break;
                    case 3:
                        sql = "DELETE from pedido where idpedido=@id";
                        break;
                }
                string[] campos = { "@emissao", "@cliente", "@idproduto","@quantidade" ,"@statuspedido", "@entrega", "@endereco", "@total" };
                object[] valores = { pedi.emissao, pedi.cliente, pedi.idproduto, pedi.quantidade,pedi.entrega, pedi.endereco, pedi.total };
                if (conn.cadastrar(pedi.idpedido, campos, valores, sql) >= 1)
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



         }*/
    }


}
