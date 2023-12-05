using controller;
using gitcake;
using modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROJETO_PPRT
{
    public partial class frmlogin : Form
    {
        // private System.Windows.Forms.Timer timer;
        //  private Panel animatedPanel; // Renomeie a variável para evitar ambiguidade
        //  private Color[] colors = { Color.SaddleBrown };
        // private int currentColorIndex = 0;

        int codigousuario;
        usuariomodelo us = new usuariomodelo();

       

        public frmlogin()
        {
            InitializeComponent();


        }

        // Resto do código do seu formulário...

        private void btnlogar_Click(object sender, EventArgs e)
        {
            // Resto do código do evento btnlogar_Click
            conexao con = new conexao();
            usuariocontroller uscontrole = new usuariocontroller();
            //determino variáveis aos preenchimentos
            us.nome = txtusuario.Text;
            us.senha = txtsenha.Text;

            //condicional para caso os campos não forem preenchidos
            if (string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("preencha o usuário por favor");
                txtusuario.Focus();//retorna o campo vazio
                return; // Retorna para evitar continuar o processo de login
            }

            if (string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("insira a senha por favor");
                txtsenha.Focus();
                return; // Retorna para evitar continuar o processo de login
            }

            //guardando o id do usuário retornado da consulta
            codigousuario = uscontrole.logar(us);
            //apresenta na tela qual usuário acabou de logar no programa

            //condicionais para entrar no programa
            if (codigousuario >= 1)
            {
                int verifica = con.verificaperfil(codigousuario);

                Frmprincipal principal = new Frmprincipal(codigousuario, verifica);
                principal.ShowDialog();//estabeleço qual página vai rodar após o login
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrados :(");
            }
        }

        private void btnrecuperarsenha_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();
            lblesqueceu.Text = com.recuperaremail(txtusuario.Text);
        }

        private void btnfecharlog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LimparCampos()
        {
            txtusuario.Text = string.Empty;
            txtsenha.Text = string.Empty;
            // Adicione outros campos conforme necessário
        }
        private void btnloginin_Click(object sender, EventArgs e)
        {
            usuariomodelo usuariomodelo = new usuariomodelo();
            usuariocontroller usuarioController = new usuariocontroller();
            Frmacesso frmacesso = new Frmacesso();
          
            frmacesso.Show();

            
        

        }
    }
}