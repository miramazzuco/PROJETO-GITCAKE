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



namespace PROJETO_PPRT
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            
        }

       

        private void btnfecharlog_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(125, Color.White);

        }     

        private void frmlogin_Load(object sender, EventArgs e)
        {
            
        }

        

    }
}
