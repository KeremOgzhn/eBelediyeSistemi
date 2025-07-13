namespace eBelediye
{
    partial class FrmBelgeDogrulama
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtVatandasID;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblVatandasID;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAnaMenu;

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
            this.txtVatandasID = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblVatandasID = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVatandasID
            // 
            this.txtVatandasID.BackColor = System.Drawing.Color.White;
            this.txtVatandasID.ForeColor = System.Drawing.Color.Black;
            this.txtVatandasID.Location = new System.Drawing.Point(150, 80);
            this.txtVatandasID.Name = "txtVatandasID";
            this.txtVatandasID.Size = new System.Drawing.Size(200, 22);
            this.txtVatandasID.TabIndex = 0;
            // 
            // btnDogrula
            // 
            this.btnDogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnDogrula.ForeColor = System.Drawing.Color.White;
            this.btnDogrula.Location = new System.Drawing.Point(150, 120);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(200, 30);
            this.btnDogrula.TabIndex = 1;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(150, 160);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 3;
            // 
            // lblVatandasID
            // 
            this.lblVatandasID.AutoSize = true;
            this.lblVatandasID.ForeColor = System.Drawing.Color.Black;
            this.lblVatandasID.Location = new System.Drawing.Point(50, 80);
            this.lblVatandasID.Name = "lblVatandasID";
            this.lblVatandasID.Size = new System.Drawing.Size(84, 16);
            this.lblVatandasID.TabIndex = 2;
            this.lblVatandasID.Text = "Vatandaş ID:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 50);
            this.panelHeader.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(60, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(260, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Belge Doğrulama";
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(150, 200);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(200, 30);
            this.btnAnaMenu.TabIndex = 4;
            this.btnAnaMenu.Text = "Ana Menüye Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // FrmBelgeDogrulama
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.lblVatandasID);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.txtVatandasID);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmBelgeDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi - Belge Doğrulama";
            this.Load += new System.EventHandler(this.FrmBelgeDogrulama_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
