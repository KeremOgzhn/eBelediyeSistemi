namespace eBelediyeSistemi
{
    partial class FrmGiris
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.lblTitle.Location = new System.Drawing.Point(49, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "  e-Belediye \r\nVatandaş Giriş";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTC.Location = new System.Drawing.Point(67, 98);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(133, 25);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSifre.Location = new System.Drawing.Point(67, 148);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 25);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(200, 98);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(265, 22);
            this.txtTC.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(200, 148);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(265, 22);
            this.txtSifre.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(200, 197);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(267, 49);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(200, 258);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(267, 49);
            this.btnKayitOl.TabIndex = 6;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::eBelediyeSistemi.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(333, 12);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(133, 78);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
