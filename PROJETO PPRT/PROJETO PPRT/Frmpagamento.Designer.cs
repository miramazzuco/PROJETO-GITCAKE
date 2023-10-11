namespace PROJETO_PPRT
{
    partial class Frmpagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpagamento));
            this.dtppedido = new System.Windows.Forms.DateTimePicker();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbentrega = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_fecharpagamento = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtppedido
            // 
            this.dtppedido.Location = new System.Drawing.Point(202, 146);
            this.dtppedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtppedido.Name = "dtppedido";
            this.dtppedido.Size = new System.Drawing.Size(212, 20);
            this.dtppedido.TabIndex = 33;
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Location = new System.Drawing.Point(199, 187);
            this.cbstatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(92, 21);
            this.cbstatus.TabIndex = 32;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(188, 106);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(116, 20);
            this.txtcliente.TabIndex = 31;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(169, 272);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(135, 20);
            this.txtendereco.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Endereço :";
            // 
            // cbentrega
            // 
            this.cbentrega.AutoSize = true;
            this.cbentrega.Location = new System.Drawing.Point(133, 231);
            this.cbentrega.Margin = new System.Windows.Forms.Padding(2);
            this.cbentrega.Name = "cbentrega";
            this.cbentrega.Size = new System.Drawing.Size(15, 14);
            this.cbentrega.TabIndex = 28;
            this.cbentrega.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Entrega :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Status do pedido :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data de emissão :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Detalhes do pedido :\r\n";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(121, 375);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(98, 20);
            this.txttotal.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(19, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btn_fecharpagamento
            // 
            this.btn_fecharpagamento.Location = new System.Drawing.Point(769, 12);
            this.btn_fecharpagamento.Name = "btn_fecharpagamento";
            this.btn_fecharpagamento.Size = new System.Drawing.Size(19, 23);
            this.btn_fecharpagamento.TabIndex = 34;
            this.btn_fecharpagamento.Text = "x";
            this.btn_fecharpagamento.UseVisualStyleBackColor = true;
            this.btn_fecharpagamento.Click += new System.EventHandler(this.btn_fecharpagamento_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(526, 343);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(171, 49);
            this.btn_finalizar.TabIndex = 35;
            this.btn_finalizar.Text = "FINALIZAR EMISSAO";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // Frmpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_fecharpagamento);
            this.Controls.Add(this.dtppedido);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbentrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmpagamento";
            this.Text = "Frmpagamento";
            this.Load += new System.EventHandler(this.Frmpagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtppedido;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbentrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fecharpagamento;
        private System.Windows.Forms.Button btn_finalizar;
    }
}