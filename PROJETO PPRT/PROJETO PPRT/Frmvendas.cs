﻿using gitcake;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROJETO_PPRT
{
    public partial class Frmvendas : Form
    {
        private Color ColorLightGray;

        public Frmvendas()
        {
            InitializeComponent();
        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            conexao com = new conexao();

            // Obtenha os dados do banco de dados
            DataTable dataTable = com.ObterDados("SELECT produto, quantidade FROM produto");

            // Configure o tipo de gráfico (no exemplo, estou usando um gráfico de barras)
            chart1.Series.Clear();
            chart1.Series.Add("Quantidade de Produtos ");
            chart1.Series["Quantidade de Produtos "].Points.DataBind(dataTable.AsEnumerable(), "produto", "quantidade", "");

            // Configure o título do gráfico
            chart1.Titles.Add(" Produtos");

            // Personalize a aparência do gráfico
            chart1.BackColor = Color.White;
            chart1.ChartAreas[0].BackColor = Color.LightGray;
            chart1.Series["Quantidade de Produtos "].BorderWidth = 2;
            chart1.Series["Quantidade de Produtos "].BorderColor = Color.Black;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chart2.Series.Clear();
            chart2.Series.Add("Produtos");
            chart2.Series["Produtos"].Points.DataBind(dataTable.AsEnumerable(), "produto", "quantidade", "");
            chart2.Series["Produtos"].ChartType = SeriesChartType.Pie; // Definir o tipo de gráfico como Pie
            chart2.Titles.Add("Produtos (Gráfico de Pizza)"); // Título diferente
            chart2.BackColor = Color.LightGray; // Fundo cinza claro
            chart2.Series["Produtos"]["PieLabelStyle"] = "Outside"; // Colocar os rótulos fora das fatias

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
