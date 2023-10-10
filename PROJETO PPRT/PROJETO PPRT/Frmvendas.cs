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
    public partial class Frmvendas : Form
    {
        conexao com = new conexao();
        public Frmvendas()
        {
            InitializeComponent();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * from pedido";
            dtpedidos.DataSource = com.ObterDados(sql);
        }
    }
}
