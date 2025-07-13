namespace eBelediye
{
    partial class FrmMakbuzDogrulama
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMakbuzNo;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblMakbuzNo;
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
            this.txtMakbuzNo = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblMakbuzNo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // txtMakbuzNo
            this.txtMakbuzNo.BackColor = System.Drawing.Color.White;
            this.txtMakbuzNo.ForeColor = System.Drawing.Color.Black;
            this.txtMakbuzNo.Location = new System.Drawing.Point(150, 98);
            this.txtMakbuzNo.Name = "txtMakbuzNo";
            this.txtMakbuzNo.Size = new System.Drawing.Size(200, 22);
            this.txtMakbuzNo.TabIndex = 0;

            // btnDogrula
            this.btnDogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(143)))));
            this.btnDogrula.ForeColor = System.Drawing.Color.White;
            this.btnDogrula.Location = new System.Drawing.Point(150, 136);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(200, 30);
            this.btnDogrula.TabIndex = 1;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);

            // lblSonuc
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(150, 180);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(200, 16);
            this.lblSonuc.TabIndex = 3;

            // lblMakbuzNo
            this.lblMakbuzNo.AutoSize = true;
            this.lblMakbuzNo.ForeColor = System.Drawing.Color.Black;
            this.lblMakbuzNo.Location = new System.Drawing.Point(50, 98);
            this.lblMakbuzNo.Name = "lblMakbuzNo";
            this.lblMakbuzNo.Size = new System.Drawing.Size(78, 16);
            this.lblMakbuzNo.TabIndex = 2;
            this.lblMakbuzNo.Text = "Makbuz No:";

            // btnAnaSayfayaDon
            this.btnAnaSayfayaDon.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaSayfayaDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(150, 220);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(200, 30);
            this.btnAnaSayfayaDon.TabIndex = 5;
            this.btnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfayaDon.Click += new System.EventHandler(this.btnAnaSayfayaDon_Click);

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(400, 48);
            this.panelHeader.TabIndex = 4;

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(47, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(289, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Makbuz Doğrulama";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FrmMakbuzDogrulama
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblMakbuzNo);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.txtMakbuzNo);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.lblSonuc);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmMakbuzDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi -Makbuz Doğrulama";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
