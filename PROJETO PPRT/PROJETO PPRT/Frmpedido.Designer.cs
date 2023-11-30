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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pedido.Location = new System.Drawing.Point(983, 906);
            this.btn_pedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(285, 59);
            this.btn_pedido.TabIndex = 5;
            this.btn_pedido.Text = "Finalizar Pedido";
            this.btn_pedido.UseVisualStyleBackColor = false;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // dtitem
            // 
            this.dtitem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.dtitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtitem.Location = new System.Drawing.Point(568, 96);
            this.dtitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtitem.Name = "dtitem";
            this.dtitem.RowHeadersWidth = 51;
            this.dtitem.RowTemplate.Height = 24;
            this.dtitem.Size = new System.Drawing.Size(533, 737);
            this.dtitem.TabIndex = 21;
            this.dtitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtitem_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 898);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(29, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Entrega :";
            // 
            // ckbentrega
            // 
            this.ckbentrega.AutoSize = true;
            this.ckbentrega.Location = new System.Drawing.Point(196, 527);
            this.ckbentrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbentrega.Name = "ckbentrega";
            this.ckbentrega.Size = new System.Drawing.Size(18, 17);
            this.ckbentrega.TabIndex = 14;
            this.ckbentrega.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 608);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Endereço :";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Aguardando ",
            "Aprovado ",
            "Clacelado"});
            this.cmbstatus.Location = new System.Drawing.Point(265, 439);
            this.cmbstatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(121, 24);
            this.cmbstatus.TabIndex = 18;
            // 
            // dtpemissao
            // 
            this.dtpemissao.Location = new System.Drawing.Point(265, 350);
            this.dtpemissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpemissao.Name = "dtpemissao";
            this.dtpemissao.Size = new System.Drawing.Size(281, 22);
            this.dtpemissao.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 906);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detalhes do pedido :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de emissão :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Status do pedido :";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(265, 613);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(281, 22);
            this.txtendereco.TabIndex = 16;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(265, 261);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(281, 22);
            this.txtcliente.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1107, 96);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 737);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 867);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1885, 1004);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}