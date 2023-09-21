using gitcake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_PPRT
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToString("HH:mm:ss");

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
           
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
    }
}
