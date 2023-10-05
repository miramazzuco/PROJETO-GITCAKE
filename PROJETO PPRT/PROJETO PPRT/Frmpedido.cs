using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using gitcake;
using modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using MySqlX.XDevAPI.Relational;
using System.IO;
using System.Drawing.Printing;
using MySqlX.XDevAPI;

namespace PROJETO_PPRT
{
    public partial class Frmpedido : Form
    {
        private Font printFont;
        private StreamReader StreamToPrint;
        decimal total = 0;
        conexao com = new conexao();
        public Frmpedido()
        {
            InitializeComponent();
        }



        private void Frmpedido_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = com.ObterDados("select  * from produto ");
            int registros;
            int x = 0, y = 0;
            int qtdeproduto;

            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel();//criando o painel de produto
                produto.Location = new Point(x, y);//defino o local
                produto.Height = 190;
                produto.Width = 115;
                //produto.BorderStyle = BorderStyle.FixedSingle;
                Label idproduto = new Label();//crio uma label
                idproduto.Name = "idproduto";
                idproduto.Location = new Point(-2, 10);
                idproduto.Text = dt.Rows[registros][0].ToString();//mostra o registro
                PictureBox foto = new PictureBox();//crio a area da foto
                foto.Location = new Point(15, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][5].ToString());
                foto.Height = 90;
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(10, 119);
                Label descricao = new Label();
                descricao.Name = "produto";
                descricao.Text = dt.Rows[registros][1].ToString();
                descricao.Location = new Point(10, 98);
                TextBox qtde = new TextBox();
                qtde.Name = "quantidade";
                qtdeproduto = Convert.ToInt32(dt.Rows[registros][3].ToString());
                // qtde.Leave += new EventHandler((sender1, e1) => QtdeLeave(sender1, e1, qtde.Text, qtdeproduto));
                qtde.Location = new Point(10, 138);

                if (!string.IsNullOrEmpty(qtde.Text))
                {


                    if (Convert.ToInt32(qtde) >= qtdeproduto)
                    {
                        MessageBox.Show("Quantidade indisponivel", "Alerta");
                    }
                }

                if (qtdeproduto < 1)
                {
                    qtde.Enabled = false;
                }
                else
                {
                    qtde.Enabled = true;
                }


                Button registrar = new Button();
                registrar.Name = "Selecionar";
                registrar.Text = "Selecionar";
                registrar.Font = new Font("Arial", 8, FontStyle.Bold);
                registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text, descricao.Text, qtde.Text, preco.Text));
                registrar.Location = new Point(10, 162);
                registrar.Width = 100;
                registrar.FlatStyle = FlatStyle.Popup;
                registrar.ForeColor = Color.FromArgb(255, 255, 128);



                //adicionando os componentes ao painel
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                produto.Controls.Add(descricao);
                produto.Controls.Add(registrar);
                produto.Controls.Add(qtde);

                //painel criado da caixa
                //add cada produto da consulta ao painel
                flowLayoutPanel1.Controls.Add(produto);
                //somando 100 a 
                y += 100;
                x = 0;
            }
        }


        private void SelecionarClick(object sender, EventArgs e, string id, string produto, string quantidade, string preco)
        {
            decimal subTotal = 0;
            dtitempedido.ColumnCount = 5;
            dtitempedido.Columns[0].Name = "Id";
            dtitempedido.Columns[1].Name = "produto";
            dtitempedido.Columns[2].Name = "preco";
            dtitempedido.Columns[3].Name = "quantidade";
            dtitempedido.Columns[4].Name = "SubTotal";

           // dtitempedido.DataSource
            if (String.IsNullOrEmpty(quantidade))//condicional para quantidade nula
                quantidade = "1";
            

            subTotal = Convert.ToInt32(quantidade.ToString()) * Convert.ToDecimal(preco.ToString());

            dtitempedido.Rows.Add(id.ToString(), produto.ToString(), preco.ToString(), quantidade.ToString(), subTotal.ToString());

            for (int i = 0; i < dtitempedido.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dtitempedido.Rows[i].Cells[4].Value);
               
            }

            MessageBox.Show("Produto Selecionado" + subTotal.ToString());
            txttotal.Text = total.ToString();
            
            string file = "C:\\Users\\aluno\\Documents\\GitHub\\PROJETO-GITCAKE\\PROJETO PPRT\\PROJETO PPRT\\bin\\Debug\\MyFile.txt.txt";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dtitempedido.Columns.Count);
                bw.Write(dtitempedido.Rows.Count);
                foreach (DataGridViewRow dgvR in dtitempedido.Rows)
                {
                    for (int j = 0; j < dtitempedido.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }

            }



        }


        private void QtdeLeave(object sender, EventArgs e, string qtde, int qtdeprod)
        {
            if (!string.IsNullOrEmpty(qtde))
            {
                if (Convert.ToInt32(qtde) > qtdeprod || Convert.ToInt32(qtde) <= 0)
                {
                    MessageBox.Show("Quantidade indisponivel", "Alerta");
                }
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                StreamToPrint = new StreamReader
                   ("C:\\Users\\User\\Documents\\MyFile.txt.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.printDocument1_PrintPage);
                    pd.Print();
                }
                finally
                {
                    StreamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void GerarPDF()
        {
            //Exemplo de dados para o DataGridView
            dtitempedido.Columns.Add("idproduto", "coluna 1");
            dtitempedido.Columns.Add("Column2", "Coluna 2");
            dtitempedido.Rows.Add("Linha1Col1", "Linha1Col2");
            dtitempedido.Rows.Add("Linha2Col1", "Linha2Col2");

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = StreamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }

        private void btn_avancarpedido_Click(object sender, EventArgs e)
        {
            Frmpagamento pg = new Frmpagamento();
            pg.ShowDialog();
        }

        private void btn_excluirprodpedido_Click(object sender, EventArgs e)
        {
            pedidocontroller pdcontroller = new pedidocontroller();
        }
    }










}
