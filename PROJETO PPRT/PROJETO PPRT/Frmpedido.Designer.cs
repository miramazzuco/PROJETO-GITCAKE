namespace PROJETO_PPRT
{
    partial class Frmpedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpedido));
            this.btn_pedido = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtitem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbentrega = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.dtpemissao = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.btn_excluiritem = new System.Windows.Forms.Button();
            this.btn_limparitem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pedido.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pedido.Location = new System.Drawing.Point(737, 736);
            this.btn_pedido.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(214, 48);
            this.btn_pedido.TabIndex = 5;
            this.btn_pedido.Text = "Finalizar Pedido";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(830, 78);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 599);
            this.flowLayoutPanel1.TabIndex = 20;
           // this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // dtitem
            // 
            this.dtitem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.dtitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtitem.Location = new System.Drawing.Point(426, 78);
            this.dtitem.Margin = new System.Windows.Forms.Padding(2);
            this.dtitem.Name = "dtitem";
            this.dtitem.RowHeadersWidth = 51;
            this.dtitem.RowTemplate.Height = 24;
            this.dtitem.Size = new System.Drawing.Size(400, 599);
            this.dtitem.TabIndex = 21;
            this.dtitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtitem_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 730);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(22, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Entrega :";
            // 
            // ckbentrega
            // 
            this.ckbentrega.AutoSize = true;
            this.ckbentrega.Location = new System.Drawing.Point(147, 428);
            this.ckbentrega.Margin = new System.Windows.Forms.Padding(2);
            this.ckbentrega.Name = "ckbentrega";
            this.ckbentrega.Size = new System.Drawing.Size(15, 14);
            this.ckbentrega.TabIndex = 14;
            this.ckbentrega.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 494);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Endereço :";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Aprovado",
            "Aguardando",
            "Cancelado"});
            this.cmbstatus.Location = new System.Drawing.Point(199, 357);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(92, 21);
            this.cmbstatus.TabIndex = 18;
            // 
            // dtpemissao
            // 
            this.dtpemissao.Location = new System.Drawing.Point(199, 284);
            this.dtpemissao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpemissao.Name = "dtpemissao";
            this.dtpemissao.Size = new System.Drawing.Size(212, 20);
            this.dtpemissao.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 736);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 7;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detalhes do pedido :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de emissão :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status do pedido :";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(199, 498);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(212, 20);
            this.txtendereco.TabIndex = 16;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(199, 212);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(212, 20);
            this.txtcliente.TabIndex = 17;
            // 
            // btn_excluiritem
            // 
            this.btn_excluiritem.Location = new System.Drawing.Point(426, 682);
            this.btn_excluiritem.Name = "btn_excluiritem";
            this.btn_excluiritem.Size = new System.Drawing.Size(75, 23);
            this.btn_excluiritem.TabIndex = 22;
            this.btn_excluiritem.Text = "Excluir";
            this.btn_excluiritem.UseVisualStyleBackColor = true;
            this.btn_excluiritem.Click += new System.EventHandler(this.btn_excluiritem_Click);
            // 
            // btn_limparitem
            // 
            this.btn_limparitem.Location = new System.Drawing.Point(751, 682);
            this.btn_limparitem.Name = "btn_limparitem";
            this.btn_limparitem.Size = new System.Drawing.Size(75, 23);
            this.btn_limparitem.TabIndex = 23;
            this.btn_limparitem.Text = "Limpar";
            this.btn_limparitem.UseVisualStyleBackColor = true;
            this.btn_limparitem.Click += new System.EventHandler(this.btn_limparitem_Click);
            // 
            // Frmpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1414, 816);
            this.Controls.Add(this.btn_limparitem);
            this.Controls.Add(this.btn_excluiritem);
            this.Controls.Add(this.dtitem);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dtpemissao);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckbentrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmpedido";
            this.Text = "Frmpedido";
            this.Load += new System.EventHandler(this.Frmpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtitem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbentrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.DateTimePicker dtpemissao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btn_excluiritem;
        private System.Windows.Forms.Button btn_limparitem;
    }
}