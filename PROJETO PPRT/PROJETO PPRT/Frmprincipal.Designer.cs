namespace PROJETO_PPRT
{
    partial class Frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprincipal));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsobrenos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnestoque = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnpedido = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(0)))));
            this.panelmenu.Controls.Add(this.btnsobrenos);
            this.panelmenu.Controls.Add(this.button5);
            this.panelmenu.Controls.Add(this.btnestoque);
            this.panelmenu.Controls.Add(this.btncadastrar);
            this.panelmenu.Controls.Add(this.btnvendas);
            this.panelmenu.Controls.Add(this.btnpedido);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(287, 827);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // btnsobrenos
            // 
            this.btnsobrenos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsobrenos.FlatAppearance.BorderSize = 0;
            this.btnsobrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsobrenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsobrenos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsobrenos.Image = ((System.Drawing.Image)(resources.GetObject("btnsobrenos.Image")));
            this.btnsobrenos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsobrenos.Location = new System.Drawing.Point(0, 495);
            this.btnsobrenos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsobrenos.Name = "btnsobrenos";
            this.btnsobrenos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsobrenos.Size = new System.Drawing.Size(287, 119);
            this.btnsobrenos.TabIndex = 7;
            this.btnsobrenos.Text = "   Sobre nós";
            this.btnsobrenos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsobrenos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsobrenos.UseVisualStyleBackColor = true;
            this.btnsobrenos.Click += new System.EventHandler(this.btnsobrenos_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 731);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(287, 96);
            this.button5.TabIndex = 6;
            this.button5.Text = "  Sair";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnestoque
            // 
            this.btnestoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnestoque.FlatAppearance.BorderSize = 0;
            this.btnestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnestoque.Image = ((System.Drawing.Image)(resources.GetObject("btnestoque.Image")));
            this.btnestoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestoque.Location = new System.Drawing.Point(0, 395);
            this.btnestoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnestoque.Size = new System.Drawing.Size(287, 100);
            this.btnestoque.TabIndex = 5;
            this.btnestoque.Text = "  Estoque";
            this.btnestoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnestoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnestoque.UseVisualStyleBackColor = true;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncadastrar.FlatAppearance.BorderSize = 0;
            this.btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btncadastrar.Image")));
            this.btncadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastrar.Location = new System.Drawing.Point(0, 279);
            this.btncadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btncadastrar.Size = new System.Drawing.Size(287, 116);
            this.btncadastrar.TabIndex = 4;
            this.btncadastrar.Text = "  Cadastrar";
            this.btncadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnvendas
            // 
            this.btnvendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvendas.FlatAppearance.BorderSize = 0;
            this.btnvendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvendas.Image = ((System.Drawing.Image)(resources.GetObject("btnvendas.Image")));
            this.btnvendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvendas.Location = new System.Drawing.Point(0, 180);
            this.btnvendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnvendas.Size = new System.Drawing.Size(287, 99);
            this.btnvendas.TabIndex = 3;
            this.btnvendas.Text = "  Vendas";
            this.btnvendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvendas.UseVisualStyleBackColor = true;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnpedido
            // 
            this.btnpedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpedido.FlatAppearance.BorderSize = 0;
            this.btnpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpedido.Image = ((System.Drawing.Image)(resources.GetObject("btnpedido.Image")));
            this.btnpedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpedido.Location = new System.Drawing.Point(0, 80);
            this.btnpedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnpedido.Size = new System.Drawing.Size(287, 100);
            this.btnpedido.TabIndex = 2;
            this.btnpedido.Text = "  Pedido";
            this.btnpedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panellogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panellogo.BackgroundImage")));
            this.panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panellogo.Controls.Add(this.label1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(287, 80);
            this.panellogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(67)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 80);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(287, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 1080);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(592, 276);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 359);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1460, 827);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmprincipal";
            this.Text = "Frmprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmprincipal_Load);
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button btnpedido;
        private System.Windows.Forms.Button btnestoque;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsobrenos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}