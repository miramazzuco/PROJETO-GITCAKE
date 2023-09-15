using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using controller;
using modelo;
using gitcake;

namespace PROJETO_PPRT
{
    public partial class frmlogin : Form
    {
        int codigousuario;
        //determino uma variavel e a mudança do modelo
        usuariomodelo us = new usuariomodelo();
        public frmlogin()
        {
            InitializeComponent();
            
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            usuariocontroller uscontrole = new usuariocontroller();
            //determino variaveis aos preenchimentos
            us.nome = txtusuario.Text;
            us.senha = con.getMD5Hash(txtsenha.Text);

            //condicional para caso os campos não forem preenchidos
            if (string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("preencha o usuario por favor");
                txtusuario.Focus();//retorna o campo vazio
            }

            if (string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("insira a senha por favor");
                txtsenha.Focus();
            }

            //guardando o id do usuario retornado da consulta
            codigousuario = uscontrole.logar(us);
            //apresenta na tela qual usuario acabou de logar no programa
            MessageBox.Show("USUARIO = " + codigousuario.ToString());
            //condicionais para entrar no programa
            if (uscontrole.logar(us) >= 1)
            {
                Frmprincipal principal = new Frmprincipal();
                principal.ShowDialog();//estabeleço qual pagina vai rodar apos o login
            }
            else
            {
                MessageBox.Show("Usuario ou senha não encontrados :(");
            }

        }


        private void btnfecharlog_Click(object sender, EventArgs e)
        {
            Close();
        }

           

        private void frmlogin_Load(object sender, EventArgs e)
        {
            
        }

      

        private void btnrecuperarsenha_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();

            lblmensagem.Text = com.recuperaremail(txtusuario.Text);
        }
    }
}
