using System;
using System.Drawing;
using System.IO;
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
        private ErrorProvider errorProvider = new ErrorProvider();
        private bool isValid;

        public Frmcadastro()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider.Clear();

            errorProvider.Clear();
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
            errorProvider.Clear();
            try
            {
                string sql = "SELECT * from produto";
                dataGridView1.DataSource = com.ObterDados(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btncadastrarproduto_Click(object sender, EventArgs e)
        {
            

            errorProvider.Clear();
            if (ValidarCampos())
            {
                try
                {
                    pmodelo.descricao = txtproduto.Text;
                    pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
                    pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
                    pmodelo.data_val = dtpdata.Value;
                    pmodelo.foto = lblfoto.Text;


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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o produto: " + ex.Message);
                }
            }
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();

            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtproduto.Text))
            {
                errorProvider.SetError(txtproduto, "O campo 'Produto' é obrigatório.");
                isValid = false;

            }
            else
            {
                errorProvider.Clear();
            }

            if (!decimal.TryParse(txtpreco.Text, out decimal preco) || preco <= 0)
            {
                errorProvider.SetError(txtpreco, "Preço inválido. Insira um valor numérico positivo.");
                isValid = false;
            }

            if (!int.TryParse(txtquantidade.Text, out int quantidade) || quantidade == 0)
            {
                errorProvider.SetError(txtquantidade, "Quantidade inválida. Insira um valor numérico não negativo.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lblfoto.Text) || !File.Exists(lblfoto.Text))
            {
                errorProvider.SetError(lblfoto, "Selecione uma imagem válida.");
                isValid = false;
            }

            return isValid;
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

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                string sql = "SELECT * from produto where produto like '%" + txtPesquisar.Text + "%'";
                dataGridView1.DataSource = com.ObterDados(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                pmodelo.idproduto = Convert.ToInt32(txtcodigo.Text);
                if (pmodelo.idproduto <= 0)
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
                MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            isValid = true;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void btnedita_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (ValidarCampos())
            {
                try
                {
                    pmodelo.descricao = txtproduto.Text;
                    pmodelo.preco = Convert.ToDecimal(txtpreco.Text);
                    pmodelo.quantidade = Convert.ToInt32(txtquantidade.Text);
                    pmodelo.idproduto = Convert.ToInt32(txtcodigo.Text);
                    pmodelo.data_val = dtpdata.Value;
                    pmodelo.foto = lblfoto.Text;
                    if (pController.cadastrarProduto(pmodelo, 2) == true)
                    {
                        MessageBox.Show("Editado com Sucesso");
                        string sql = "SELECT * from produto";
                        dataGridView1.DataSource = com.ObterDados(sql);
                        tabPage2.Focus();
                        tabestoque.SelectedIndex = 1;
                        txtproduto.Clear();
                        txtcodigo.Clear();
                        txtpreco.Clear();
                        txtquantidade.Text = "0";
                        dtpdata.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar o produto: " + ex.Message);
                }
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
