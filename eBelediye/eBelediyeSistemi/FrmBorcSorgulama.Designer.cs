namespace eBelediye
{
    partial class FrmBorcSorgulama
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblVatandasID;
        private System.Windows.Forms.TextBox txtVatandasID;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.DataGridView dgvBorclar;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVatandasID = new System.Windows.Forms.Label();
            this.txtVatandasID = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.dgvBorclar = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAnaSayfayaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVatandasID
            // 
            this.lblVatandasID.AutoSize = true;
            this.lblVatandasID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatandasID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVatandasID.Location = new System.Drawing.Point(27, 64);
            this.lblVatandasID.Name = "lblVatandasID";
            this.lblVatandasID.Size = new System.Drawing.Size(129, 24);
            this.lblVatandasID.TabIndex = 0;
            this.lblVatandasID.Text = "Vatandaş ID:";
            // 
            // txtVatandasID
            // 
            this.txtVatandasID.Location = new System.Drawing.Point(174, 64);
            this.txtVatandasID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVatandasID.Name = "txtVatandasID";
            this.txtVatandasID.Size = new System.Drawing.Size(134, 22);
            this.txtVatandasID.TabIndex = 1;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.Orange;
            this.btnSorgula.ForeColor = System.Drawing.Color.White;
            this.btnSorgula.Location = new System.Drawing.Point(361, 63);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(128, 24);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Borç Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // dgvBorclar
            // 
            this.dgvBorclar.BackgroundColor = System.Drawing.Color.White;
            this.dgvBorclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorclar.ColumnHeadersHeight = 29;
            this.dgvBorclar.Location = new System.Drawing.Point(27, 104);
            this.dgvBorclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBorclar.Name = "dgvBorclar";
            this.dgvBorclar.RowHeadersWidth = 51;
            this.dgvBorclar.Size = new System.Drawing.Size(640, 200);
            this.dgvBorclar.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(711, 48);
            this.panelHeader.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(229, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(245, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Borç Sorgulama";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnaSayfayaDon
            // 
            this.btnAnaSayfayaDon.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAnaSayfayaDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfayaDon.Location = new System.Drawing.Point(474, 319);
            this.btnAnaSayfayaDon.Name = "btnAnaSayfayaDon";
            this.btnAnaSayfayaDon.Size = new System.Drawing.Size(185, 29);
            this.btnAnaSayfayaDon.TabIndex = 5;
            this.btnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfayaDon.Click += new System.EventHandler(this.btnAnaSayfayaDon_Click);
            // 
            // FrmBorcSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnAnaSayfayaDon);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvBorclar);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtVatandasID);
            this.Controls.Add(this.lblVatandasID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBorcSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi - Borç Sorgulama";
            this.Load += new System.EventHandler(this.FrmBorcSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAnaSayfayaDon;
    }
}
