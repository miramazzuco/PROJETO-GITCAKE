using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using gitcake;
using modelo;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.ListViewItem;

namespace PROJETO_PPRT
{
    public partial class Frmpedido : Form
    {
        conexao com = new conexao();
        public Frmpedido()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmpedido_Load(object sender, EventArgs e)
        {
            //tabela de dados
            DataTable dt = new DataTable();
            //buscando e populando da datatable
            dt = com.ObterDados("select * from produto");
            int registros;// ler a quantidade de dados
            int x = 0, y = 0; // posição da tela
            int qtdeproduto;// guarda a quantidade de produto no estoque
            // varrer os registros da tabela produto
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel(); //criando o painel de produto
                                             // produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Location = new Point(x, y);//defino o local
                produto.Height = 190;
                produto.Width = 115;
                Label idproduto = new Label();//crio uma label
                idproduto.Name = "idproduto";
                idproduto.Location = new Point(-2, 10);
                idproduto.Text = dt.Rows[registros][0].ToString();//mostra o registro
                PictureBox foto = new PictureBox(); // crio a area de foto
                foto.Location = new Point(15, 0);
                foto.Height = 95;
                foto.Width = 90;
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][5].ToString());
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(10, 119);
                Label descproduto = new Label();
                descproduto.Name = "produto";
                descproduto.Text = dt.Rows[registros][1].ToString();
                descproduto.Location = new Point(10, 98);
                TextBox qtde = new TextBox();
                qtde.Name = "quantidade";
                qtdeproduto = Convert.ToInt32(dt.Rows[registros][3].ToString());
                qtde.Leave += new EventHandler((sender1, e1) => QtdeLeave(sender1, e1, qtde.Text, qtdeproduto));

                if (qtdeproduto < 1)
                {
                    qtde.Enabled = false;
                }

                qtde.Location = new Point(10, 139);

                // adicionando os componente no painel
                Button registrar = new Button();
                registrar.Name = "Selecionar";
                registrar.Text = "Selecionar";
                registrar.Font = new Font("Arial", 8, FontStyle.Bold);
                registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text , descproduto.Text,qtde.Text,preco.Text));
                registrar.Location = new Point(10, 163);
                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                produto.Controls.Add(registrar);
                produto.Controls.Add(qtde);
                // painel criado da caixa de ferramenta
                // adiciono cada produto da consulta ao painel
                flowLayoutPanel1.Controls.Add(produto);
                //somando 100 a y
                y += 100;
                x = 0;
            }
        }
        private void SelecionarClick(object sender, EventArgs e, string Id, string produto, string quantidade, string preco)
        {

            /*string sql;//variavel global
            usuariocontroller uscontroller = new usuariocontroller();
            sql = "SELECT * from produto";*/
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Produto";
            dataGridView1.Columns[2].Name = "Preco";
            dataGridView1.Columns[3].Name = "quantidade";
            dataGridView1.Columns[4].Name = "SubTotal";
            decimal subTotal = Convert.ToInt32(quantidade.ToString()) * Convert.ToDecimal(preco.ToString());
            decimal total = 0;
            dataGridView1.Rows.Add(Id.ToString(), produto.ToString(), preco.ToString(), quantidade.ToString(),subTotal.ToString());

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }


            MessageBox.Show(" Produto Selecionado " + total.ToString());
            label2.Text = total.ToString();
            
          
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
