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
    public partial class Frmpedido : Form
    {
        public Frmpedido()
        {
            InitializeComponent();
        }

        private void Frmpedido_Load(object sender, EventArgs e)
        {
            txtendereco.Visible = false;
            lblendereco.Visible = false;
        }

        private void chkentrega_CheckedChanged(object sender, EventArgs e)
        {

            if (chkentrega.Checked)
            {
                txtendereco.Visible = true;
                lblendereco.Visible = true;

            }



            else
            {
                txtendereco.Visible = false;
                lblendereco.Visible = false;
            }

        }
    }
}
