﻿namespace PROJETO_PPRT
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
            this.btn_avancarpedido = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtitempedido = new System.Windows.Forms.DataGridView();
            this.btn_excluirprodpedido = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtitempedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_avancarpedido
            // 
            this.btn_avancarpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_avancarpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_avancarpedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_avancarpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avancarpedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_avancarpedido.Location = new System.Drawing.Point(482, 648);
            this.btn_avancarpedido.Margin = new System.Windows.Forms.Padding(2);
            this.btn_avancarpedido.Name = "btn_avancarpedido";
            this.btn_avancarpedido.Size = new System.Drawing.Size(141, 38);
            this.btn_avancarpedido.TabIndex = 5;
            this.btn_avancarpedido.Text = "Avançar";
            this.btn_avancarpedido.UseVisualStyleBackColor = false;
            this.btn_avancarpedido.Click += new System.EventHandler(this.btn_avancarpedido_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(482, 36);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(554, 574);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // dtitempedido
            // 
            this.dtitempedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.dtitempedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtitempedido.Location = new System.Drawing.Point(57, 36);
            this.dtitempedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtitempedido.Name = "dtitempedido";
            this.dtitempedido.RowHeadersWidth = 51;
            this.dtitempedido.RowTemplate.Height = 24;
            this.dtitempedido.Size = new System.Drawing.Size(380, 574);
            this.dtitempedido.TabIndex = 21;
            // 
            // btn_excluirprodpedido
            // 
            this.btn_excluirprodpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btn_excluirprodpedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluirprodpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_excluirprodpedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_excluirprodpedido.Location = new System.Drawing.Point(296, 648);
            this.btn_excluirprodpedido.Name = "btn_excluirprodpedido";
            this.btn_excluirprodpedido.Size = new System.Drawing.Size(141, 37);
            this.btn_excluirprodpedido.TabIndex = 25;
            this.btn_excluirprodpedido.Text = "Excluir";
            this.btn_excluirprodpedido.UseVisualStyleBackColor = false;
            this.btn_excluirprodpedido.Click += new System.EventHandler(this.btn_excluirprodpedido_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(130, 666);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(98, 20);
            this.txttotal.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 660);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total :";
            // 
            // Frmpedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1095, 748);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_excluirprodpedido);
            this.Controls.Add(this.dtitempedido);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_avancarpedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmpedido";
            this.Text = "Frmpedido";
            this.Load += new System.EventHandler(this.Frmpedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtitempedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_avancarpedido;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dtitempedido;
        private System.Windows.Forms.Button btn_excluirprodpedido;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label2;
    }
}