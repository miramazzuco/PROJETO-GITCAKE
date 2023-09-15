using controller;
using modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJETO_PPRT
{
    public partial class Frmcadastrousuario : Form
    {
        int idperfil;
        int codigo;
        usuariocontroller uscontroller = new usuariocontroller();
        public Frmcadastrousuario()
        {
            InitializeComponent();
        }

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
            //declarei o modelo de cada campo
            usmodelo.nome = txtnome.Text;
            usmodelo.senha = txtsenha.Text;
            usmodelo.email = txtemail.Text;
            usmodelo.perfil = idperfil;

            //condicional para preenchimento
            if(usmodelo.nome != "" && usmodelo.senha != "")
            {
                if(uscontroller.cadastrar(usmodelo) == true)
                {
                    MessageBox.Show("usuario cadastrado com sucesso, bem-vindo(a) " + txtnome.Text);
                    //confirmação de cadastro
                }
                else
                {
                    MessageBox.Show("usuario não encontrado :(");
                }

            }
            else
            {
                MessageBox.Show("os campos estão vazios :(");
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
            if (uscontroler.editar(usmodelo) == true)
            {
                MessageBox.Show("Usuario Atualizando Com sucesso");
                dtusuario.DataSource = uscontroler.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");

            }
            else
            {
                MessageBox.Show("Erro ao atualizar");
            }
        }

        private void btnexcluirusuario_Click(object sender, EventArgs e)
        {
            //chamando o metodo excluir do usuario controler de verdade
            usuariocontroller uscontroller = new usuariocontroller();
            if (uscontroller.Excluir(codigo) == true)
            { //excluir o usuario
                MessageBox.Show("codigo do usuario " + codigo + "excluido");
                dtusuario.DataSource = uscontroller.ObterDados("select usuario.idusuario, usuario.nome,usuario.senha,perfil.perfil,usuario.email from usuario inner join perfil on usuario.perfil=perfil.idperfil");

            }
            else
            { // falso erro ao excluir 
                MessageBox.Show("erro ao excluir usuario");
            }
        }

        //apresentar somente o id do perfil no datagridview
        private void cboperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            idperfil = Convert.ToInt32(((DataRowView)cboperfil.SelectedItem)["idperfil"]);

        }

        //aviso sobre senha
        private void txtsenha_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtsenha, "Tamanmho 8 carcteres letras e numeros");
        }

        private void dtusuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dtusuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
