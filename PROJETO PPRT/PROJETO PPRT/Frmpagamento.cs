using controller;
using DocumentFormat.OpenXml.EMMA;
using gitcake;
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

namespace PROJETO_PPRT
{
    public partial class Frmpagamento : Form
    {
        pedidocontroller pdcontroller = new pedidocontroller();
        pedidomodelo pdmodelo = new pedidomodelo();
        conexao com = new conexao();
        public Frmpagamento()
        {
            InitializeComponent();
        }

        private void btn_fecharpagamento_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            Frmvendas fv = new Frmvendas();
            fv.ShowDialog();

           // produtocontroller pController = new produtocontroller();
            if (pdmodelo.cliente != "" && pdmodelo.status != "" )
            {
                pdmodelo.cliente = txtcliente.Text;
                pdmodelo.emissao = dtppedido.Value;
                pdmodelo.status = cbstatus.Text;
                pdmodelo.entrega = cbentrega.Checked;
                pdmodelo.endereco = txtendereco.Text;

                if (pdcontroller.cadastrarPedido(pdmodelo, 1) == true)
                {

                    MessageBox.Show("Pedido emitido com sucesso!");
                    string sql = "SELECT * from pedido";
                    //dtpedidos.DataSource = com.ObterDados(sql);
                }
                else
                {
                    MessageBox.Show("Erro ao emitir pedido");
                }

            }
            else
            {
                MessageBox.Show("Informações insuficientes");
            }

        }

        private void Frmpagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
