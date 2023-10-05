using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using controller;
using modelo;

namespace gitcake
{
    public partial class Frmcadastro : Form
    {
        produtomodelo pmodelo = new produtomodelo();
        produtocontroller pController = new produtocontroller();
        int codigoproduto;
        conexao com = new conexao();

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

        private void Frmcadastro_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * from produto";
            dataGridView1.DataSource = com.ObterDados(sql);
        }

        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
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
                    string sql = "SELECT * from produto";
                    dataGridView1.DataSource = com.ObterDados(sql);
                }
                else
                {
                    MessageBox.Show("Erro no Cadastro");
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtproduto.Text))
            {
                MessageBox.Show("O campo 'Produto' é obrigatório.");
                return false;
            }

            if (!decimal.TryParse(txtpreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido. Insira um valor numérico positivo.");
                return false;
            }

            if (!int.TryParse(txtquantidade.Text, out int quantidade) || quantidade < 0)
            {
                MessageBox.Show("Quantidade inválida. Insira um valor numérico não negativo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(lblfoto.Text) || !File.Exists(lblfoto.Text))
            {
                MessageBox.Show("Selecione uma imagem válida.");
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                if (foto.ShowDialog() == DialogResult.OK)
                {
                    lblfoto.Text = foto.FileName;
                    Image arquivo = Image.FromFile(foto.FileName);
                    pictureBox1.Image = arquivo;
                }
                else
                {
                    MessageBox.Show("Você não escolheu uma foto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btneditarproduto_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                pmodelo.descricao = txtproduto.Text;
                pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
                pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
                pmodelo.codigo = Convert.ToInt32(txtcodigo.Text);
                pmodelo.data_val = dtpdata.Value;
                pmodelo.foto = lblfoto.Text;
                if (pController.cadastrarProduto(pmodelo, 2) == true)
                {
                    MessageBox.Show("Cadastro com Sucesso");
                    string sql = "SELECT * from produto";
                    dataGridView1.DataSource = com.ObterDados(sql);
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * from produto where produto like '%" + txtPesquisar.Text + "%'";
            dataGridView1.DataSource = com.ObterDados(sql);
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                pmodelo.codigo = Convert.ToInt32(txtcodigo.Text);
                if (pmodelo.codigo <= 0)
                {
                    MessageBox.Show("Favor escolher um produto válido.");
                    return;
                }

                if (MessageBox.Show("Tem certeza de que deseja excluir este produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (pController.cadastrarProduto(pmodelo, 3) == true)
                    {
                        MessageBox.Show("Produto excluído: " + pmodelo.descricao);
                        tabPage2.Focus();
                        tabestoque.SelectedIndex = 1;
                        string sql = "SELECT * from produto";
                        dataGridView1.DataSource = com.ObterDados(sql);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
