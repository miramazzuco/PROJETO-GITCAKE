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

namespace PROJETO_PPRT
{
    public partial class Frmprincipal : Form
    {
        int usi;
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public Frmprincipal(int usuario)
        {

            usi = usuario;
            InitializeComponent();
        }


        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToString("HH:mm:ss");


            DateTime data = DateTime.Now;
            label3.Text = data.ToString("dd/MM/yyyy");

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            usuariomodelo umodelo = new usuariomodelo();
            usuariocontroller ucontrole = new usuariocontroller();
            umodelo = ucontrole.CarregaUsuario(usi);
            label5.Text = umodelo.nome;

        }



        private void btnpedido_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frmpedido ad = new Frmpedido();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }

        private void btnsobrenos_Click(object sender, EventArgs e)
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



        private void btnestoque_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frmcadastro ad = new Frmcadastro();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Close();

            Application.Exit();

        }



        private void btnvendas_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Frmvendas ad = new Frmvendas();

            ad.TopLevel = false;
            ad.Dock = DockStyle.Fill;
            ad.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ad);
            ad.Show();
            pictureBox1.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Caminho para o documento do Word que você deseja abrir
            string filePath = @"C:\Users\cunha\Downloads\Documento 10.docx";

            // Verifique se o arquivo existe antes de tentar abrir
            if (System.IO.File.Exists(filePath))
            {
                // Abra o arquivo com o aplicativo padrão associado
                Process.Start(filePath);
            }
        }

      
    }
}
