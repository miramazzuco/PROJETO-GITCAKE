using controller;
using gitcake;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Adicione esta referência para a validação de email
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJETO_PPRT
{
    public partial class Frmcadastrousuario : Form
    {
        int idperfil = 1;
        int codigo;
        int nome;

        usuariocontroller uscontroller = new usuariocontroller();

        private ErrorProvider errorProvider = new ErrorProvider();
       
        public Frmcadastrousuario()
        {
            InitializeComponent();
        }
        conexao com = new conexao();


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frmcadastrousuario_Load(object sender, EventArgs e)
        {
            usuariocontroller usControle = new usuariocontroller();
            dtusuario.DataSource = usControle.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");
            cboperfil.DataSource = usControle.ObterDados("select  * from perfil");
            cboperfil.DisplayMember = "perfil";
            cboperfil.ValueMember = "idperfil";



        }

        private void btncadastrarusuario_Click(object sender, EventArgs e)
        {
            usuariocontroller usControle = new usuariocontroller();
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
                errorProvider.SetError(txtemail, "Insira um endereço de email válido.");
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
            if (isValid == true)
            {

                if (uscontroller.cadastrar(usmodelo) == true)
                {

                    MessageBox.Show("Usuário cadastrado com sucesso, bem-vindo(a) " + txtnome.Text);
                    dtusuario.DataSource = uscontroller.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");
                    txtnome.Text = string.Empty;
                    txtsenha.Text = string.Empty;
                    txtemail.Text = string.Empty;
                    cboperfil.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");
                }
            }
        }

        private void btneditarusuario_Click(object sender, EventArgs e)
        {
            usuariocontroller uscontroler = new usuariocontroller();
            usuariomodelo usmodelo = new usuariomodelo();
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.idusuario = codigo;
            usmodelo.perfil = idperfil;
            usmodelo.email = txtemail.Text;

            // Limpa os ícones de erro do ErrorProvider
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
                errorProvider.SetError(txtemail, "Insira um endereço de email válido.");
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
                if (uscontroler.editar(usmodelo) == true)
                {
                    MessageBox.Show("Usuário atualizado com sucesso");
                    dtusuario.DataSource = uscontroler.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");

                    // Limpa os campos após a edição
                    txtnome.Text = string.Empty;
                    txtsenha.Text = string.Empty;
                    txtemail.Text = string.Empty;
                    cboperfil.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário.");
            }

        }

        private void btnexcluirusuario_Click(object sender, EventArgs e)
        {
            usuariocontroller uscontroller = new usuariocontroller();

            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (uscontroller.Excluir(codigo) == true)
                {
                    MessageBox.Show("Código do usuário " + codigo + " excluído.");
                    dtusuario.DataSource = uscontroller.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");
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

        /*private void dtusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Verifica se a célula clicada é válida
            {


                //convertendo a primeira coleta em string
                codigo = Convert.ToInt32(dtusuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                //convert o inteiro para string
                MessageBox.Show("Usuario selecionado :  " + codigo.ToString());
                txtnome.Text = dtusuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtemail.Text = dtusuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtsenha.Text = dtusuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cboperfil.Text = dtusuario.Rows[e.RowIndex].Cells["perfil"].Value.ToString();
            }
        }*/

        private void Frmcadastrousuario_Click(object sender, EventArgs e)
        {

        }

        private void dtusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                codigo = Convert.ToInt32(dtusuario.Rows[e.RowIndex].Cells["idusuario"].Value);
                txtnome.Text = dtusuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtemail.Text = dtusuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtsenha.Text = dtusuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cboperfil.Text = dtusuario.Rows[e.RowIndex].Cells["perfil"].Value.ToString();
            }
        }

     
    }

}