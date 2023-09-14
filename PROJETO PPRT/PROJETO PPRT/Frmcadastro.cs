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
using modelo;
using System.Diagnostics.Eventing.Reader;




namespace gitcake
{
    public partial class Frmcadastro : Form
    {
        produtomodelo pmodelo = new produtomodelo();
        produtocontroller pController = new produtocontroller();
        int codigoproduto; // identifico qual  codigo
        conexao com = new conexao(); // chamar a classe conexao
        public Frmcadastro()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmcadastro_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            pmodelo.descricao = txtproduto.Text;
            pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
            if (chkperecivel.Checked)
            {
                pmodelo.perecivel = true;
            }
            else
            {
                pmodelo.perecivel = false;
            }
            pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
            pmodelo.data_val = dtpdata.Value;
            pmodelo.foto = lblfoto.Text;
            produtocontroller pController = new produtocontroller();
            if (pController.cadastrarProduto(pmodelo, 1) == true)

                MessageBox.Show("Cadastro com sucesso");
            else
                MessageBox.Show("Erro no Cadastro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //chamo a caixa de dialago da foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                //verificar se apertou no ok do dialg
                if (foto.ShowDialog() == DialogResult.OK)
                {
                    //mostrar o nome da foto
                    lblfoto.Text = foto.FileName;
                    //caminho da imagem para ser exibida no form
                    Image arquivo = Image.FromFile(foto.FileName);
                    pictureBox1.Image = arquivo; //carregar a foto

                }
                else
                {
                    MessageBox.Show("nao escolheu a foto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void txtproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneditarproduto_Click(object sender, EventArgs e)
        {

            pmodelo.descricao = txtproduto.Text;
            pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
            pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
            pmodelo.codigo = Convert.ToInt32(txtcodigo.Text);
            if (chkperecivel.Checked)
                pmodelo.perecivel = true;
            else
                pmodelo.perecivel = false;
            pmodelo.data_val = dtpdata.Value;
            pmodelo.foto = lblfoto.Text;
            if (pController.cadastrarProduto(pmodelo, 2) == true)
            {
                MessageBox.Show("Cadastra com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
        }
    }
}
