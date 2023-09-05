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
            this.btnfecharlog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnfecharlog
            // 
            this.btnfecharlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfecharlog.AutoSize = true;
            this.btnfecharlog.Location = new System.Drawing.Point(973, 12);
            this.btnfecharlog.Name = "btnfecharlog";
            this.btnfecharlog.Size = new System.Drawing.Size(24, 23);
            this.btnfecharlog.TabIndex = 0;
            this.btnfecharlog.Text = "X";
            this.btnfecharlog.UseVisualStyleBackColor = true;
            this.btnfecharlog.Click += new System.EventHandler(this.btnfecharlog_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(520, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 387);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROJETO_PPRT.Properties.Resources.vista_frontal_do_conceito_de_bolo_de_chocolate_delicioso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnfecharlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfecharlog;
        private System.Windows.Forms.Panel panel1;
    }
}