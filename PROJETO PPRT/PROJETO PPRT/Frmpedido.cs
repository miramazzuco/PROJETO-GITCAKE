using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using gitcake;
using modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using MySqlX.XDevAPI.Relational;
using System.IO;
using System.Drawing.Printing;
using MySqlX.XDevAPI;

namespace PROJETO_PPRT
{
    public partial class Frmpedido : Form
    {

        // Declaração de variáveis de classe e objetos.
        private Font printFont;
        private StreamReader StreamToPrint;
        decimal total = 0;
        int iditem;
        conexao com = new conexao();
        
        itemcontroller itcontroller = new itemcontroller();
       // itemmodelo itmodelo = new itemmodelo();
        pedidomodelo pdmodelo = new pedidomodelo();
      //  List<itemmodelo> list = new List<itemmodelo>();
        public Frmpedido()
        {
            InitializeComponent();
        }



        private void Frmpedido_Load(object sender, EventArgs e)
        {
            itemcontroller itcontroller = new itemcontroller();
            dtitem.DataSource = itcontroller.ObterDados("select item.iditem, produto.idproduto, item.quantidade, item.subtotal from item inner join produto on item.idproduto=produto.idproduto");
            

            //determinar como inicialmente invisivel o endereço
            textBox2.Visible = false;
            label8.Visible = false;

            // Criação de um DataTable para armazenar dados da consulta SQL.
            DataTable dt = new DataTable();

            dt = com.ObterDados("select  * from produto ");
            int registros;
            int x = 0, y = 0;
            int qtdeproduto;


            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                // Criação de um painel para exibir informações do produto.
                Panel produto = new Panel();
                produto.Location = new Point(x, y);
                produto.Height = 190;
                produto.Width = 115;


                Label idproduto = new Label();//crio uma label
                idproduto.Name = "idproduto";
                idproduto.Location = new Point(-2, 10);
                idproduto.Text = dt.Rows[registros][0].ToString();//mostra o registro


                PictureBox foto = new PictureBox();//crio a area da foto
                foto.Location = new Point(15, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][5].ToString());
                foto.Height = 90;


                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(10, 119);


                Label descricao = new Label();
                descricao.Name = "produto";
                descricao.Text = dt.Rows[registros][1].ToString();
                descricao.Location = new Point(15, 98);


                TextBox qtde = new TextBox();
                qtde.Name = "quantidade";
                qtdeproduto = Convert.ToInt32(dt.Rows[registros][3].ToString());
                qtde.Location = new Point(10, 138);

                if (!string.IsNullOrEmpty(qtde.Text))
                {


                    if (Convert.ToInt32(qtde) >= qtdeproduto)
                    {
                        MessageBox.Show("Quantidade indisponivel", "Alerta");
                    }
                }

                if (qtdeproduto < 1)
                {
                    qtde.Enabled = false;
                }
                else
                {
                    qtde.Enabled = true;
                }


                Button registrar = new Button();
                registrar.Name = "Selecionar";
                registrar.Text = "Selecionar";
                registrar.Font = new Font("Arial", 8, FontStyle.Bold);
                registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text, qtde.Text, preco.Text));
                registrar.Location = new Point(10, 162);
                registrar.Width = 100;
                registrar.FlatStyle = FlatStyle.Popup;
                registrar.ForeColor = Color.FromArgb(255, 255, 128);



                //adicionando os componentes ao painel
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                produto.Controls.Add(descricao);
                produto.Controls.Add(registrar);
                produto.Controls.Add(qtde);


                // Adiciona o painel ao painel de layout (flowLayoutPanel1)
                flowLayoutPanel1.Controls.Add(produto);


                // Calcula a posição para o próximo produto.
                y += 100;
                x = 0;
            }
        }



        private void SelecionarClick(object sender, EventArgs e, string idproduto, string quantidade, string preco)
        {
           
            itemmodelo itmodelo = new itemmodelo();
            itemcontroller itcontroller = new itemcontroller();
            dtitem.DataSource = itcontroller.ObterDados("select item.iditem, produto.idproduto, item.quantidade, item.subtotal from item inner join produto on item.idproduto=produto.idproduto");
            dtitem.Refresh();

            //condicional para quantidade nula
            if (String.IsNullOrEmpty(quantidade.ToString()))
                quantidade = "1";

            // Cálculo do subtotal do produto selecionado.
            decimal subTotal = Convert.ToInt32(quantidade.ToString()) * Convert.ToDecimal(preco.ToString());



            // Adiciona informações do produto à DataGridView e atualiza o total.
           // dtitem.Rows.Add(default, idproduto.ToString(), quantidade.ToString(), subTotal.ToString());
            total = total + subTotal;
            MessageBox.Show("Produto Selecionado" + total.ToString());
            textBox1.Text = total.ToString();
           

            itmodelo.idproduto = Convert.ToInt32(idproduto.ToString());
            itmodelo.quantidade = Convert.ToInt32(quantidade.ToString());
            itmodelo.subtotal = subTotal;
            itcontroller.cadastrarItem(itmodelo);
            
            // Grava as informações da DataGridView em um arquivo binário.
            string file = "C:\\Users\\aluno\\Documents\\GitHub\\PROJETO-GITCAKE\\PROJETO PPRT\\PROJETO PPRT\\bin\\Debug\\MyFile.txt.txt";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {

                // Grava informações sobre as colunas e as células na DataGridView.
                bw.Write(dtitem.Columns.Count);
                bw.Write(dtitem.Rows.Count);
                foreach (DataGridViewRow dgvR in dtitem.Rows)
                {
                    for (int j = 0; j < dtitem.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }

            }
            dtitem.DataSource = itcontroller.ObterDados("select item.iditem, produto.idproduto, item.quantidade, item.subtotal from item inner join produto on item.idproduto=produto.idproduto");
            dtitem.Refresh();
        }


        private void QtdeLeave(object sender, EventArgs e, string qtde, int qtdeprod)
        {
            // Método chamado quando ocorre um evento Leave em um campo de quantidade.
            if (!string.IsNullOrEmpty(qtde))
            {
                if (Convert.ToInt32(qtde) > qtdeprod || Convert.ToInt32(qtde) <= 0)
                {
                    MessageBox.Show("Quantidade indisponivel", "Alerta");
                }
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                StreamToPrint = new StreamReader
                   ("C:\\Users\\User\\Documents\\MyFile.txt.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.printDocument1_PrintPage);
                    pd.Print();
                }
                finally
                {
                    StreamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void GerarPDF()
        {

            // Método para gerar um PDF com base nos dados do DataGridView.
            //Exemplo de dados para o DataGridView
            dtitem.Columns.Add("idproduto", "coluna 1");
            dtitem.Columns.Add("Column2", "Coluna 2");
            dtitem.Rows.Add("Linha1Col1", "Linha1Col2");
            dtitem.Rows.Add("Linha2Col1", "Linha2Col2");

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = StreamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Visible = true;
                label8.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                label8.Visible = false;
            }

        }

        private void btn_excluiitem_Click(object sender, EventArgs e)
        {
            itemcontroller itcontroller = new itemcontroller();
            produtomodelo pdmodelo = new produtomodelo();
            //  iditem = Convert.ToInt32(com.ObterDados("select iditem from item where iditem = iditem"));

            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este produto do pedido?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (itcontroller.Excluiritem(iditem) == true)
                {
                    MessageBox.Show("Item " + pdmodelo.codigo + " excluído.");
                    dtitem.DataSource = itcontroller.ObterDados("select item.iditem, produto.idproduto,item.quantidade,item.subtotal from item inner join produto on item.idproduto=produto.idproduto");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir produto.");
                }
            }
        }

        private void btn_limpaitem_Click(object sender, EventArgs e)
        {
            limpartabelaitem();
        }

        //fun. limpar tds as informações do datagridview e do banco
        public void limpartabelaitem()
        {
            if (dtitem.Rows.Count > 0)
            {

                itcontroller.limparitem();

                // Limpa as linhas da DataGridView
                // dtitem.Controls.Clear();
                total = 0;
                textBox1.Text = "";
                dtitem.DataSource = null; //Remover a datasource
                dtitem.Columns.Clear(); //Remover as colunas
                dtitem.Rows.Clear();    //Remover as linhas
                dtitem.Refresh();    //Para a grid se actualizar
            }
        }

        //fun. para selecionar a celula da datagridview para pegar as informações A.E
        private void dtitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtém o valor da célula clicada
                iditem = Convert.ToInt32(dtitem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                // Faça algo com o valor da célula, por exemplo, exibindo-o em uma caixa de mensagem
                //  MessageBox.Show("Valor da célula clicada: " + cellValue.ToString());
            }

            MessageBox.Show("Produto selecionado");
        }
    }

}
