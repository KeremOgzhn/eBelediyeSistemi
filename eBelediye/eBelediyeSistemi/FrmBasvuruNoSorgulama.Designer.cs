namespace eBelediye
{
    partial class FrmBasvuruNoSorgulama
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtBasvuruNo;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblBasvuruNo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAnaSayfayaDon;

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
            this.txtBasvuruNo = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblBasvuruNo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBasvuruNo
            // 
            this.txtBasvuruNo.BackColor = System.Drawing.Color.White;
            this.txtBasvuruNo.ForeColor = System.Drawing.Color.Black;
            this.txtBasvuruNo.Location = new System.Drawing.Point(150, 98);
            this.txtBasvuruNo.Name = "txtBasvuruNo";
            this.txtBasvuruNo.Size = new System.Drawing.Size(200, 22);
            this.txtBasvuruNo.TabIndex = 0;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Location = new System.Drawing.Point(150, 136);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(200, 30);
            this.btnSorgula.TabIndex = 1;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(150, 180);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 3;
            // 
            // lblBasvuruNo
            // 
            this.lblBasvuruNo.AutoSize = true;
            this.lblBasvuruNo.ForeColor = System.Drawing.Color.Black;
            this.lblBasvuruNo.Location = new System.Drawing.Point(50, 98);
            this.lblBasvuruNo.Name = "lblBasvuruNo";
            this.lblBasvuruNo.Size = new System.Drawing.Size(80, 16);
            this.lblBasvuruNo.TabIndex = 2;
            this.lblBasvuruNo.Text = "Başvuru No:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 48);
            this.panelHeader.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(47, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(345, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Başvuru No Sorgulama";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaSayfayaDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(150, 220);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(200, 30);
            this.btnAnaSayfayaDon.TabIndex = 5;
            this.btnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfayaDon.Click += new System.EventHandler(this.btnAnaSayfayaDon_Click);
            // 
            // FrmBasvuruNoSorgulama
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblBasvuruNo);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.txtBasvuruNo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.lblSonuc);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmBasvuruNoSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi -Başvuru No Sorgulama";
            this.Load += new System.EventHandler(this.FrmBasvuruNoSorgulama_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
