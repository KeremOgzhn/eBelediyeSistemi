namespace eBelediye
{
    partial class FrmEEksper
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpEksperTarihi;
        private System.Windows.Forms.TextBox txtEksperDetay;
        private System.Windows.Forms.Button btnBasvuruYap;
        private System.Windows.Forms.Label lblEksperTarihi;
        private System.Windows.Forms.Label lblEksperDetay;
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
            this.dtpEksperTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtEksperDetay = new System.Windows.Forms.TextBox();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.lblEksperTarihi = new System.Windows.Forms.Label();
            this.lblEksperDetay = new System.Windows.Forms.Label();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEksperTarihi
            // 
            this.dtpEksperTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEksperTarihi.Location = new System.Drawing.Point(150, 80);
            this.dtpEksperTarihi.Name = "dtpEksperTarihi";
            this.dtpEksperTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpEksperTarihi.TabIndex = 0;
            // 
            // txtEksperDetay
            // 
            this.txtEksperDetay.Location = new System.Drawing.Point(150, 120);
            this.txtEksperDetay.Multiline = true;
            this.txtEksperDetay.Name = "txtEksperDetay";
            this.txtEksperDetay.Size = new System.Drawing.Size(200, 80);
            this.txtEksperDetay.TabIndex = 1;
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnBasvuruYap.ForeColor = System.Drawing.Color.White;
            this.btnBasvuruYap.Location = new System.Drawing.Point(150, 210);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(200, 30);
            this.btnBasvuruYap.TabIndex = 2;
            this.btnBasvuruYap.Text = "Başvuruyu Kaydet";
            this.btnBasvuruYap.UseVisualStyleBackColor = false;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click);
            // 
            // lblEksperTarihi
            // 
            this.lblEksperTarihi.AutoSize = true;
            this.lblEksperTarihi.Location = new System.Drawing.Point(50, 85);
            this.lblEksperTarihi.Name = "lblEksperTarihi";
            this.lblEksperTarihi.Size = new System.Drawing.Size(90, 16);
            this.lblEksperTarihi.TabIndex = 3;
            this.lblEksperTarihi.Text = "Eksper Tarihi:";
            // 
            // lblEksperDetay
            // 
            this.lblEksperDetay.AutoSize = true;
            this.lblEksperDetay.Location = new System.Drawing.Point(50, 125);
            this.lblEksperDetay.Name = "lblEksperDetay";
            this.lblEksperDetay.Size = new System.Drawing.Size(92, 16);
            this.lblEksperDetay.TabIndex = 4;
            this.lblEksperDetay.Text = "Eksper Detay:";
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(150, 260);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(200, 30);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "Ana Menüye Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 48);
            this.panelHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(41, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(309, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "E-Eksper Başvurusu";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEEksper
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnBasvuruYap);
            this.Controls.Add(this.txtEksperDetay);
            this.Controls.Add(this.lblEksperDetay);
            this.Controls.Add(this.dtpEksperTarihi);
            this.Controls.Add(this.lblEksperTarihi);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmEEksper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Eksper Başvurusu";
            this.Load += new System.EventHandler(this.FrmEEksper_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
