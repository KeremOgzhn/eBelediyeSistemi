namespace eBelediye
{
    partial class FrmEBasvuru
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBasvuruDetay;
        private System.Windows.Forms.DateTimePicker dtpBasvuruTarihi;
        private System.Windows.Forms.Label lblBasvuruDetay;
        private System.Windows.Forms.Label lblBasvuruTarihi;
        private System.Windows.Forms.Button btnBasvuruYap;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;

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
            this.txtBasvuruDetay = new System.Windows.Forms.TextBox();
            this.dtpBasvuruTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBasvuruDetay = new System.Windows.Forms.Label();
            this.lblBasvuruTarihi = new System.Windows.Forms.Label();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBasvuruDetay
            // 
            this.txtBasvuruDetay.Location = new System.Drawing.Point(172, 100);
            this.txtBasvuruDetay.Multiline = true;
            this.txtBasvuruDetay.Name = "txtBasvuruDetay";
            this.txtBasvuruDetay.Size = new System.Drawing.Size(200, 100);
            this.txtBasvuruDetay.TabIndex = 0;
            // 
            // dtpBasvuruTarihi
            // 
            this.dtpBasvuruTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBasvuruTarihi.Location = new System.Drawing.Point(172, 70);
            this.dtpBasvuruTarihi.Name = "dtpBasvuruTarihi";
            this.dtpBasvuruTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBasvuruTarihi.TabIndex = 1;
            // 
            // lblBasvuruDetay
            // 
            this.lblBasvuruDetay.AutoSize = true;
            this.lblBasvuruDetay.ForeColor = System.Drawing.Color.Black;
            this.lblBasvuruDetay.Location = new System.Drawing.Point(45, 100);
            this.lblBasvuruDetay.Name = "lblBasvuruDetay";
            this.lblBasvuruDetay.Size = new System.Drawing.Size(101, 16);
            this.lblBasvuruDetay.TabIndex = 2;
            this.lblBasvuruDetay.Text = "Başvuru Detayı:";
            // 
            // lblBasvuruTarihi
            // 
            this.lblBasvuruTarihi.AutoSize = true;
            this.lblBasvuruTarihi.ForeColor = System.Drawing.Color.Black;
            this.lblBasvuruTarihi.Location = new System.Drawing.Point(50, 70);
            this.lblBasvuruTarihi.Name = "lblBasvuruTarihi";
            this.lblBasvuruTarihi.Size = new System.Drawing.Size(96, 16);
            this.lblBasvuruTarihi.TabIndex = 3;
            this.lblBasvuruTarihi.Text = "Başvuru Tarihi:";
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnBasvuruYap.ForeColor = System.Drawing.Color.White;
            this.btnBasvuruYap.Location = new System.Drawing.Point(172, 210);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(200, 30);
            this.btnBasvuruYap.TabIndex = 4;
            this.btnBasvuruYap.Text = "Başvuru Yap";
            this.btnBasvuruYap.UseVisualStyleBackColor = false;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(172, 250);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(200, 30);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "Ana Menüye Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(538, 48);
            this.panelHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(180, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(165, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "E-Başvuru";
            // 
            // FrmEBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 300);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnBasvuruYap);
            this.Controls.Add(this.lblBasvuruTarihi);
            this.Controls.Add(this.lblBasvuruDetay);
            this.Controls.Add(this.dtpBasvuruTarihi);
            this.Controls.Add(this.txtBasvuruDetay);
            this.Name = "FrmEBasvuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elektronik Başvuru";
            this.Load += new System.EventHandler(this.FrmEBasvuru_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
