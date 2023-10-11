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
        int idperfil= 1;
        int codigo;

        usuariocontroller uscontroller = new usuariocontroller();
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
            usuariomodelo usmodelo = new usuariomodelo();
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.email = txtemail.Text;
            usmodelo.perfil = idperfil;

            if (string.IsNullOrWhiteSpace(usmodelo.nome) || string.IsNullOrWhiteSpace(usmodelo.senha) || string.IsNullOrWhiteSpace(usmodelo.email))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            if (usmodelo.senha.Length < 4 || !usmodelo.senha.Any(char.IsLetter) || !usmodelo.senha.Any(char.IsDigit))
            {
                MessageBox.Show("A senha deve ter pelo menos 4 caracteres e incluir letras e números.");
                return;
            }

            if (!IsValidEmail(usmodelo.email))
            {
                MessageBox.Show("Insira um endereço de email válido.");
                return;
            }

            if (idperfil <= 0)
            {
                MessageBox.Show("Selecione um perfil válido.");
                return;
            }

            if (uscontroller.cadastrar(usmodelo) == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso, bem-vindo(a) " + txtnome.Text);
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

        private void btneditarusuario_Click(object sender, EventArgs e)
        {
            usuariocontroller uscontroler = new usuariocontroller();
            usuariomodelo usmodelo = new usuariomodelo();
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.idusuario = codigo;
            usmodelo.perfil = idperfil;
            usmodelo.email = txtemail.Text;

            if (string.IsNullOrWhiteSpace(usmodelo.nome) || string.IsNullOrWhiteSpace(usmodelo.senha) || string.IsNullOrWhiteSpace(usmodelo.email))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            if (usmodelo.senha.Length < 4 || !usmodelo.senha.Any(char.IsLetter) || !usmodelo.senha.Any(char.IsDigit))
            {
                MessageBox.Show("A senha deve ter pelo menos 4 caracteres e incluir letras e números.");
                return;
            }

            if (!IsValidEmail(usmodelo.email))
            {
                MessageBox.Show("Insira um endereço de email válido.");
                return;
            }

            if (idperfil <= 0)
            {
                MessageBox.Show("Selecione um perfil válido.");
                return;
            }

            if (uscontroler.editar(usmodelo) == true)
            {
                MessageBox.Show("Usuário atualizado com sucesso");
                dtusuario.DataSource = uscontroler.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");
              
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

        private void dtusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }

}