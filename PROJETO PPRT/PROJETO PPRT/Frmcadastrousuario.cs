using controller;
using modelo;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROJETO_PPRT
{
    public partial class Frmcadastrousuario : Form
    {
        int idperfil = 1;
        int codigo;
        int nome;

        public DataGridView Dtusuario => dtusuario;
        private usuariocontroller uscontroller = new usuariocontroller();

        private ErrorProvider errorProvider = new ErrorProvider();

        public Frmcadastrousuario(int codigo, int verifapefil)
        {
            InitializeComponent();
            dtusuario.CellFormatting += dtusuario_CellFormatting;
            if (verifapefil == 1)
            {
                btnexcluirusuario.Visible = false;
                label2.Visible = false;
                txtsenha.Visible = false;
            }

            if (verifapefil == 2)
            {
                btnexcluirusuario.Visible = true;
            }
        }

        private void Frmacesso_UsuarioCadastrado(object sender, EventArgs e)
        {
            // Atualize o DataGridView ou faça qualquer ação necessária
            AtualizarDadosUsuarios();
        }

        public void InscreverEventoUsuarioCadastrado(Frmacesso frmacesso)
        {
            frmacesso.UsuarioCadastrado += Frmacesso_UsuarioCadastrado;
        }

        private void Frmcadastrousuario_Load(object sender, EventArgs e)
        {
            AtualizarDadosUsuarios();
            cboperfil.DataSource = uscontroller.ObterDados("select  * from perfil");
            cboperfil.DisplayMember = "perfil";
            cboperfil.ValueMember = "idperfil";
        }

        public void AtualizarDadosUsuarios()
        {
            dtusuario.DataSource = uscontroller.ObterDados("SELECT idusuario, nome, senha, email,perfil FROM usuario");
            // Atualizar outras configurações ou manipulações de dados, se necessário
        }

        private void btncadastrarusuario_Click(object sender, EventArgs e)
        {
            usuariomodelo usmodelo = new usuariomodelo();
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.email = txtemail.Text;
            usmodelo.perfil = idperfil;

            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(usmodelo.nome) || string.IsNullOrWhiteSpace(usmodelo.senha) || string.IsNullOrWhiteSpace(usmodelo.email))
            {
                errorProvider.SetError(txtnome, "Preencha um nome válido!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtnome, "");
            }

            if (usmodelo.senha.Length < 4 || !Regex.IsMatch(usmodelo.senha, @"^(?=.*[a-zA-Z])(?=.*\d).{4,}$"))
            {
                errorProvider.SetError(txtsenha, "A senha deve ter pelo menos 5 caracteres e incluir letras e números.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtsenha, "");
            }

            if (!IsValidEmail(usmodelo.email))
            {
                errorProvider.SetError(txtemail, "Insira um endereço de e-mail válido.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtemail, "");
            }

            if (idperfil <= 0)
            {
                MessageBox.Show("Selecione um perfil válido.");
                isValid = false;
            }

            if (isValid)
            {
                if (uscontroller.cadastrar(usmodelo))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso, bem-vindo(a) " + txtnome.Text);
                    AtualizarDadosUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");
                }
            }
        }

        private void LimparCampos()
        {
            txtnome.Text = string.Empty;
            txtsenha.Text = string.Empty;
            txtemail.Text = string.Empty;
            cboperfil.SelectedIndex = 1;
        }

        private void btneditarusuario_Click(object sender, EventArgs e)
        {
            usuariomodelo usmodelo = new usuariomodelo();
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.idusuario = codigo;
            usmodelo.perfil = idperfil;
            usmodelo.email = txtemail.Text;

            errorProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(usmodelo.nome) || string.IsNullOrWhiteSpace(usmodelo.senha) || string.IsNullOrWhiteSpace(usmodelo.email))
            {
                errorProvider.SetError(txtnome, "Preencha todos os campos obrigatórios!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtnome, "");
            }

            if (usmodelo.senha.Length < 4 || !usmodelo.senha.Any(char.IsLetter) || !usmodelo.senha.Any(char.IsDigit))
            {
                errorProvider.SetError(txtsenha, "A senha deve ter pelo menos 4 caracteres e incluir letras e números.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtsenha, "");
            }

            if (!IsValidEmail(usmodelo.email))
            {
                errorProvider.SetError(txtemail, "Insira um endereço de e-mail válido.");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtemail, "");
            }

            if (idperfil <= 0)
            {
                MessageBox.Show("Selecione um perfil válido.");
                isValid = false;
            }

            if (isValid)
            {
                if (uscontroller.editar(usmodelo))
                {
                    MessageBox.Show("Usuário atualizado com sucesso");
                    AtualizarDadosUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar usuário.");
                }
            }
        }

        private void btnexcluirusuario_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirme a exclusão",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                if (uscontroller.Excluir(codigo))
                {
                    MessageBox.Show("Usuário excluído com sucesso");
                    AtualizarDadosUsuarios();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir usuário.");
                }
            }
        }

        private void cboperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            idperfil = Convert.ToInt32(((DataRowView)cboperfil.SelectedItem)["idperfil"]);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void dtusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                codigo = Convert.ToInt32(dtusuario.Rows[e.RowIndex].Cells["idusuario"].Value);
                txtnome.Text = dtusuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtsenha.Text = dtusuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                txtemail.Text = dtusuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
                cboperfil.SelectedValue = dtusuario.Rows[e.RowIndex].Cells["perfil"].Value;
            }
        }

        private void dtusuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtusuario.Columns["senha"].Index && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
    }
}
