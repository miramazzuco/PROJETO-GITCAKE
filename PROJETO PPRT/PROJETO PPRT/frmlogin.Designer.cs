using System;

namespace PROJETO_PPRT
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btnfecharlog = new System.Windows.Forms.Button();
            this.btnrecuperarsenha = new System.Windows.Forms.Button();
            this.btnlogar = new System.Windows.Forms.Button();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfecharlog
            // 
            this.btnfecharlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfecharlog.AutoSize = true;
            this.btnfecharlog.Location = new System.Drawing.Point(1795, 3);
            this.btnfecharlog.Name = "btnfecharlog";
            this.btnfecharlog.Size = new System.Drawing.Size(24, 23);
            this.btnfecharlog.TabIndex = 0;
            this.btnfecharlog.Text = "X";
            this.btnfecharlog.UseVisualStyleBackColor = true;
            this.btnfecharlog.Click += new System.EventHandler(this.btnfecharlog_Click);
            // 
            // btnrecuperarsenha
            // 
            this.btnrecuperarsenha.BackColor = System.Drawing.Color.Transparent;
            this.btnrecuperarsenha.BackgroundImage = global::PROJETO_PPRT.Properties.Resources.esqueceu;
            this.btnrecuperarsenha.FlatAppearance.BorderSize = 0;
            this.btnrecuperarsenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnrecuperarsenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnrecuperarsenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecuperarsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(3)))));
            this.btnrecuperarsenha.Location = new System.Drawing.Point(367, 498);
            this.btnrecuperarsenha.Name = "btnrecuperarsenha";
            this.btnrecuperarsenha.Size = new System.Drawing.Size(93, 21);
            this.btnrecuperarsenha.TabIndex = 5;
            this.btnrecuperarsenha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrecuperarsenha.UseVisualStyleBackColor = false;
            this.btnrecuperarsenha.Click += new System.EventHandler(this.btnrecuperarsenha_Click);
            // 
            // btnlogar
            // 
            this.btnlogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(16)))), ((int)(((byte)(3)))));
            this.btnlogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogar.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogar.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnlogar.Location = new System.Drawing.Point(219, 535);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(240, 64);
            this.btnlogar.TabIndex = 4;
            this.btnlogar.Text = "Logar";
            this.btnlogar.UseVisualStyleBackColor = false;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(218, 407);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(241, 28);
            this.txtsenha.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(219, 318);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(241, 28);
            this.txtusuario.TabIndex = 0;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmensagem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblmensagem.Location = new System.Drawing.Point(911, 611);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(0, 13);
            this.lblmensagem.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnrecuperarsenha);
            this.panel1.Controls.Add(this.btnlogar);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Location = new System.Drawing.Point(84, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 706);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 106);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sign in";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(742, 76);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(632, 706);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.btnfecharlog);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Button btnfecharlog;
        private System.Windows.Forms.Button btnrecuperarsenha;
        private System.Windows.Forms.Button btnlogar;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlanimatedPanel;
       
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}