using controller;
using gitcake;
using modelo;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using System.Diagnostics;
using OfficeOpenXml;

namespace PROJETO_PPRT
{
    public partial class Frmprincipal : Form
    {
        int usi;


        public Frmprincipal(int usuario)
        {

            usi = usuario;// Inicializa a variável "usi" com o valor passado como argumento para o construtor.
            InitializeComponent();
        }


        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            // Inicializa um temporizador, exibe a hora atual e a data atual em labels.
            timer1.Start();
            label2.Text = DateTime.Now.ToString("HH:mm:ss");


            DateTime data = DateTime.Now;
            label3.Text = data.ToString("dd/MM/yyyy");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Remove todos os controles do painel "panel2" e adiciona uma instância de "Frmcadastrousuario" a ele.
            panel2.Controls.Clear();
            Frmcadastrousuario ad = new Frmcadastrousuario();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }

        private void Frmprincipal_Load(object sender, EventArgs e)
        {
            // Carrega informações do usuário logado e exibe o nome do usuário em uma label.
            usuariomodelo umodelo = new usuariomodelo();
            usuariocontroller ucontrole = new usuariocontroller();
            umodelo = ucontrole.CarregaUsuario(usi);
            label5.Text = umodelo.nome;

        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            // Remove todos os controles do painel "panel2" e adiciona uma instância de "Frmpedido" a ele.
            panel2.Controls.Clear();
            Frmpedido ad = new Frmpedido();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove todos os controles do painel "panel2" e adiciona uma instância de "Frmsobrenos" a ele.

            panel2.Controls.Clear();
            Frmsobrenos ad = new Frmsobrenos();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;

        }


        private void btnestoque_Click(object sender, EventArgs e)
        {
            // Remove todos os controles do painel "panel2" e adiciona uma instância de "Frmcadastro" a ele.
            panel2.Controls.Clear();
            Frmcadastro ad = new Frmcadastro();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }


        private void btnvendas_Click(object sender, EventArgs e)
        {


            // Remove todos os controles do painel "panel2" e adiciona uma instância de "Frmvendas" a ele.
            panel2.Controls.Clear();
            Frmvendas ad = new Frmvendas();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Caminho para o documento do Word que você deseja abrir
            string filePath = @"C:\Users\cunha\Downloads\Central de ajuda 🪄 (1).docx";

            // Verifique se o arquivo existe antes de tentar abrir
            if (System.IO.File.Exists(filePath))
            {
                // Abra o arquivo com o aplicativo padrão associado
                Process.Start(filePath);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Fecha o formulário atual e encerra a aplicação.
            Close();
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualiza a label com a hora atual a cada intervalo de tempo (tick) do temporizador.
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsobrenos_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frmsobrenos ad = new Frmsobrenos();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }
    }
}
