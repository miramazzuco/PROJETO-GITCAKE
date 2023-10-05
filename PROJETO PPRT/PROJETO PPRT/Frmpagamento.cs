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
    public partial class Frmpagamento : Form
    {
        public Frmpagamento()
        {
            InitializeComponent();
        }

        private void btn_fecharpagamento_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
