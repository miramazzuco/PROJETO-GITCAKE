namespace PROJETO_PPRT
{
    partial class Frmcadastrousuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcadastrousuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.dtusuario = new System.Windows.Forms.DataGridView();
            this.btneditarusuario = new System.Windows.Forms.Button();
            this.btnexcluirusuario = new System.Windows.Forms.Button();
            this.btncadastrarusuario = new System.Windows.Forms.Button();
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perfil :";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(347, 230);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(179, 22);
            this.txtnome.TabIndex = 4;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(347, 279);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(179, 22);
            this.txtsenha.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(347, 331);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(179, 22);
            this.txtemail.TabIndex = 7;
            // 
            // dtusuario
            // 
            this.dtusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtusuario.Location = new System.Drawing.Point(708, 206);
            this.dtusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtusuario.Name = "dtusuario";
            this.dtusuario.RowHeadersWidth = 51;
            this.dtusuario.RowTemplate.Height = 24;
            this.dtusuario.Size = new System.Drawing.Size(515, 281);
            this.dtusuario.TabIndex = 8;
            this.dtusuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtusuario_CellContentDoubleClick);
            this.dtusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtusuario_CellDoubleClick);
            // 
            // btneditarusuario
            // 
            this.btneditarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btneditarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditarusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btneditarusuario.Location = new System.Drawing.Point(669, 674);
            this.btneditarusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditarusuario.Name = "btneditarusuario";
            this.btneditarusuario.Size = new System.Drawing.Size(109, 44);
            this.btneditarusuario.TabIndex = 9;
            this.btneditarusuario.Text = "Editar";
            this.btneditarusuario.UseVisualStyleBackColor = false;
            this.btneditarusuario.Click += new System.EventHandler(this.btneditarusuario_Click);
            // 
            // btnexcluirusuario
            // 
            this.btnexcluirusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btnexcluirusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcluirusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnexcluirusuario.Location = new System.Drawing.Point(1057, 674);
            this.btnexcluirusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexcluirusuario.Name = "btnexcluirusuario";
            this.btnexcluirusuario.Size = new System.Drawing.Size(107, 44);
            this.btnexcluirusuario.TabIndex = 10;
            this.btnexcluirusuario.Text = "Excluir";
            this.btnexcluirusuario.UseVisualStyleBackColor = false;
            this.btnexcluirusuario.Click += new System.EventHandler(this.btnexcluirusuario_Click);
            // 
            // btncadastrarusuario
            // 
            this.btncadastrarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.btncadastrarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastrarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncadastrarusuario.Location = new System.Drawing.Point(251, 674);
            this.btncadastrarusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncadastrarusuario.Name = "btncadastrarusuario";
            this.btncadastrarusuario.Size = new System.Drawing.Size(120, 44);
            this.btncadastrarusuario.TabIndex = 11;
            this.btncadastrarusuario.Text = "Cadastrar";
            this.btncadastrarusuario.UseVisualStyleBackColor = false;
            this.btncadastrarusuario.Click += new System.EventHandler(this.btncadastrarusuario_Click);
            // 
            // cboperfil
            // 
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(347, 386);
            this.cboperfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(179, 24);
            this.cboperfil.TabIndex = 12;
            this.cboperfil.SelectedIndexChanged += new System.EventHandler(this.cboperfil_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(331, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Detalhes do usúario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(229, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Frmcadastrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1417, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboperfil);
            this.Controls.Add(this.btncadastrarusuario);
            this.Controls.Add(this.btnexcluirusuario);
            this.Controls.Add(this.btneditarusuario);
            this.Controls.Add(this.dtusuario);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmcadastrousuario";
            this.Text = "Frmcadastrousuario";
            this.Load += new System.EventHandler(this.Frmcadastrousuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.DataGridView dtusuario;
        private System.Windows.Forms.Button btneditarusuario;
        private System.Windows.Forms.Button btnexcluirusuario;
        private System.Windows.Forms.Button btncadastrarusuario;
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}