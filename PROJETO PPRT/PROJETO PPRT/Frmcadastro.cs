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
           txtcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["idproduto"].Value.ToString();
           txtproduto.Text = dataGridView1.Rows[e.RowIndex].Cells["produto"].Value.ToString();
           txtpreco.Text = dataGridView1.Rows[e.RowIndex].Cells["preco"].Value.ToString();
           txtquantidade.Text = dataGridView1.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
           dtpdata.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["validade"].Value.ToString());
           pictureBox1.Image = Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells["foto"].Value.ToString());
           lblfoto.Text = dataGridView1.Rows[e.RowIndex].Cells["foto"].Value.ToString();
           tabPage1.Focus();
           tabestoque.SelectedIndex = 0;



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmcadastro_Load(object sender, EventArgs e)
        {
          string  sql = "SELECT * from produto";
            dataGridView1.DataSource = com.ObterDados(sql);
        }

        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            pmodelo.descricao = txtproduto.Text;
            pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
            pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
            pmodelo.data_val = dtpdata.Value;
            pmodelo.foto = lblfoto.Text;
            produtocontroller pController = new produtocontroller();
            if (pController.cadastrarProduto(pmodelo, 1) == true)
            {

                MessageBox.Show("Cadastro com sucesso");
                // Atualizar o produto
                string sql = "SELECT * from produto";
                dataGridView1.DataSource = com.ObterDados(sql);
            }


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
            /*if (chkperecivel.Checked)
                pmodelo.perecivel = true;
            else
                pmodelo.perecivel = false;*/
            pmodelo.data_val = dtpdata.Value;
            pmodelo.foto = lblfoto.Text;
            if (pController.cadastrarProduto(pmodelo, 2) == true)
            {
                MessageBox.Show("Cadastra com Sucesso");
                string sql = "SELECT * from produto";
                dataGridView1.DataSource = com.ObterDados(sql);
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
        }
        private void SelecionarClick(object sender, EventArgs e, string Id)
        {
            MessageBox.Show(" Produto Selecionado " + Id);
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

        private void chkperecivel_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e, string Id)
        {
           // MessageBox.Show(" Produto Selecionado " + Id);
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * from produto where produto like '%" + txtPesquisar.Text+"%'";
            dataGridView1.DataSource = com.ObterDados(sql);

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

           
        }

        private void btnedita_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
             pmodelo.descricao = txtproduto.Text;
            pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
            pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
            pmodelo.codigo = Convert.ToInt32(txtcodigo.Text);
                                        
            pmodelo.foto = lblfoto.Text;
            if (pController.cadastrarProduto(pmodelo, 2) == true)
            {
                MessageBox.Show("Atualizado com Sucesso");
                tabPage2.Focus();
                tabestoque.SelectedIndex = 1;
                string sql = "SELECT * from produto";
                dataGridView1.DataSource = com.ObterDados(sql);
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
               

                pmodelo.codigo = Convert.ToInt32(txtcodigo.Text);
                if (string.IsNullOrEmpty(pmodelo.codigo.ToString()))
                {

                    MessageBox.Show("Codigo esta vazio");
                    txtcodigo.Focus();
                }
                else
                {
                    if (pmodelo.codigo > 0)
                    {
                        if (pController.cadastrarProduto(pmodelo, 3) == true)
                        {
                            MessageBox.Show("produto excluido " + pmodelo.descricao);
                            tabPage2.Focus();
                            tabestoque.SelectedIndex = 1;
                            string sql = "SELECT * from produto";
                            dataGridView1.DataSource = com.ObterDados(sql);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um produto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }
    }
}
