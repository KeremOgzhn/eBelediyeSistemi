namespace eBelediye
{
    partial class FrmEBeyan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewBeyanlar;
        private System.Windows.Forms.ColumnHeader colTarih;
        private System.Windows.Forms.ColumnHeader colDetay;
        private System.Windows.Forms.TextBox txtBeyanDetay;
        private System.Windows.Forms.Label lblBeyanDetay;
        private System.Windows.Forms.Button btnBeyanEkle;
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
            this.listViewBeyanlar = new System.Windows.Forms.ListView();
            this.colTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBeyanDetay = new System.Windows.Forms.TextBox();
            this.lblBeyanDetay = new System.Windows.Forms.Label();
            this.btnBeyanEkle = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewBeyanlar
            // 
            this.listViewBeyanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTarih,
            this.colDetay});
            this.listViewBeyanlar.FullRowSelect = true;
            this.listViewBeyanlar.GridLines = true;
            this.listViewBeyanlar.Location = new System.Drawing.Point(12, 60);
            this.listViewBeyanlar.Name = "listViewBeyanlar";
            this.listViewBeyanlar.Size = new System.Drawing.Size(560, 200);
            this.listViewBeyanlar.TabIndex = 0;
            this.listViewBeyanlar.UseCompatibleStateImageBehavior = false;
            this.listViewBeyanlar.View = System.Windows.Forms.View.Details;
            // 
            // colTarih
            // 
            this.colTarih.Text = "Tarih";
            this.colTarih.Width = 150;
            // 
            // colDetay
            // 
            this.colDetay.Text = "Beyan Detay";
            this.colDetay.Width = 400;
            // 
            // txtBeyanDetay
            // 
            this.txtBeyanDetay.Location = new System.Drawing.Point(12, 290);
            this.txtBeyanDetay.Multiline = true;
            this.txtBeyanDetay.Name = "txtBeyanDetay";
            this.txtBeyanDetay.Size = new System.Drawing.Size(560, 60);
            this.txtBeyanDetay.TabIndex = 1;
            // 
            // lblBeyanDetay
            // 
            this.lblBeyanDetay.AutoSize = true;
            this.lblBeyanDetay.Location = new System.Drawing.Point(12, 270);
            this.lblBeyanDetay.Name = "lblBeyanDetay";
            this.lblBeyanDetay.Size = new System.Drawing.Size(76, 13);
            this.lblBeyanDetay.TabIndex = 2;
            this.lblBeyanDetay.Text = "Beyan Detayı:";
            // 
            // btnBeyanEkle
            // 
            this.btnBeyanEkle.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBeyanEkle.ForeColor = System.Drawing.Color.White;
            this.btnBeyanEkle.Location = new System.Drawing.Point(487, 360);
            this.btnBeyanEkle.Name = "btnBeyanEkle";
            this.btnBeyanEkle.Size = new System.Drawing.Size(85, 30);
            this.btnBeyanEkle.TabIndex = 3;
            this.btnBeyanEkle.Text = "Beyan Ekle";
            this.btnBeyanEkle.UseVisualStyleBackColor = false;
            this.btnBeyanEkle.Click += new System.EventHandler(this.btnBeyanEkle_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(396, 360);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(85, 30);
            this.btnAnaMenu.TabIndex = 4;
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
            this.panelHeader.TabIndex = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Beyan Bilgileri";
            // 
            // FrmEBeyan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnBeyanEkle);
            this.Controls.Add(this.lblBeyanDetay);
            this.Controls.Add(this.txtBeyanDetay);
            this.Controls.Add(this.listViewBeyanlar);
            this.Name = "FrmEBeyan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi - Beyan Bilgileri";
            this.Load += new System.EventHandler(this.FrmEBeyan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
