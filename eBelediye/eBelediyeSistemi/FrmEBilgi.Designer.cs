namespace eBelediye
{
    partial class FrmEBilgi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewBilgiler;
        private System.Windows.Forms.ColumnHeader colTarih;
        private System.Windows.Forms.ColumnHeader colDetay;
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
            this.listViewBilgiler = new System.Windows.Forms.ListView();
            this.colTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBilgiler
            // 
            this.listViewBilgiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTarih,
            this.colDetay});
            this.listViewBilgiler.FullRowSelect = true;
            this.listViewBilgiler.GridLines = true;
            this.listViewBilgiler.HideSelection = false;
            this.listViewBilgiler.Location = new System.Drawing.Point(12, 60);
            this.listViewBilgiler.Name = "listViewBilgiler";
            this.listViewBilgiler.Size = new System.Drawing.Size(560, 280);
            this.listViewBilgiler.TabIndex = 0;
            this.listViewBilgiler.UseCompatibleStateImageBehavior = false;
            this.listViewBilgiler.View = System.Windows.Forms.View.Details;
            // 
            // colTarih
            // 
            this.colTarih.Text = "Tarih";
            this.colTarih.Width = 150;
            // 
            // colDetay
            // 
            this.colDetay.Text = "Bilgi Detay";
            this.colDetay.Width = 400;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(487, 360);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(85, 30);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "Ana Menü";
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
            this.panelHeader.Size = new System.Drawing.Size(584, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(213, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(166, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Bilgi Alımı";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEBilgi
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.listViewBilgiler);
            this.Name = "FrmEBilgi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi - E-Bilgi ";
            this.Load += new System.EventHandler(this.FrmEBilgi_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
