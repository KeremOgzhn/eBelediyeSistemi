namespace eBelediye
{
    partial class FrmOdeme
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblVatandasID;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Label lblOdemeYontemi;
        private System.Windows.Forms.Label lblMakbuzNo;
        private System.Windows.Forms.Label lblOdemeTarihi;
        private System.Windows.Forms.TextBox txtVatandasID;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.TextBox txtOdemeYontemi;
        private System.Windows.Forms.TextBox txtMakbuzNo;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVatandasID = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.lblOdemeYontemi = new System.Windows.Forms.Label();
            this.lblMakbuzNo = new System.Windows.Forms.Label();
            this.txtVatandasID = new System.Windows.Forms.TextBox();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.txtOdemeYontemi = new System.Windows.Forms.TextBox();
            this.txtMakbuzNo = new System.Windows.Forms.TextBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblOdemeTarihi = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVatandasID
            // 
            this.lblVatandasID.AutoSize = true;
            this.lblVatandasID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblVatandasID.Location = new System.Drawing.Point(50, 70);
            this.lblVatandasID.Name = "lblVatandasID";
            this.lblVatandasID.Size = new System.Drawing.Size(84, 16);
            this.lblVatandasID.TabIndex = 1;
            this.lblVatandasID.Text = "Vatandaş ID:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblOdemeTutari.Location = new System.Drawing.Point(42, 100);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(92, 16);
            this.lblOdemeTutari.TabIndex = 2;
            this.lblOdemeTutari.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeYontemi
            // 
            this.lblOdemeYontemi.AutoSize = true;
            this.lblOdemeYontemi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblOdemeYontemi.Location = new System.Drawing.Point(27, 130);
            this.lblOdemeYontemi.Name = "lblOdemeYontemi";
            this.lblOdemeYontemi.Size = new System.Drawing.Size(107, 16);
            this.lblOdemeYontemi.TabIndex = 3;
            this.lblOdemeYontemi.Text = "Ödeme Yöntemi:";
            // 
            // lblMakbuzNo
            // 
            this.lblMakbuzNo.AutoSize = true;
            this.lblMakbuzNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblMakbuzNo.Location = new System.Drawing.Point(56, 160);
            this.lblMakbuzNo.Name = "lblMakbuzNo";
            this.lblMakbuzNo.Size = new System.Drawing.Size(78, 16);
            this.lblMakbuzNo.TabIndex = 4;
            this.lblMakbuzNo.Text = "Makbuz No:";
            // 
            // txtVatandasID
            // 
            this.txtVatandasID.Location = new System.Drawing.Point(150, 70);
            this.txtVatandasID.Name = "txtVatandasID";
            this.txtVatandasID.Size = new System.Drawing.Size(180, 22);
            this.txtVatandasID.TabIndex = 5;
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.Location = new System.Drawing.Point(150, 100);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(180, 22);
            this.txtOdemeTutari.TabIndex = 6;
            // 
            // txtOdemeYontemi
            // 
            this.txtOdemeYontemi.Location = new System.Drawing.Point(150, 130);
            this.txtOdemeYontemi.Name = "txtOdemeYontemi";
            this.txtOdemeYontemi.Size = new System.Drawing.Size(180, 22);
            this.txtOdemeYontemi.TabIndex = 7;
            // 
            // txtMakbuzNo
            // 
            this.txtMakbuzNo.Location = new System.Drawing.Point(150, 160);
            this.txtMakbuzNo.Name = "txtMakbuzNo";
            this.txtMakbuzNo.Size = new System.Drawing.Size(180, 22);
            this.txtMakbuzNo.TabIndex = 8;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(399, 92);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(109, 30);
            this.btnOdemeYap.TabIndex = 9;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(399, 160);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(109, 30);
            this.btnAnaMenu.TabIndex = 10;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // dgvOdemeler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOdemeler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOdemeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOdemeler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOdemeler.Location = new System.Drawing.Point(35, 250);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.Size = new System.Drawing.Size(500, 200);
            this.dgvOdemeler.TabIndex = 11;
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(150, 190);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(180, 22);
            this.dtpOdemeTarihi.TabIndex = 13;
            // 
            // lblOdemeTarihi
            // 
            this.lblOdemeTarihi.Location = new System.Drawing.Point(50, 190);
            this.lblOdemeTarihi.Name = "lblOdemeTarihi";
            this.lblOdemeTarihi.Size = new System.Drawing.Size(100, 23);
            this.lblOdemeTarihi.TabIndex = 14;
            this.lblOdemeTarihi.Text = "Ödeme Tarihi:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(584, 50);
            this.panelHeader.TabIndex = 12;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(193, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(201, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Ödeme Ekranı";
            // 
            // FrmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.txtMakbuzNo);
            this.Controls.Add(this.txtOdemeYontemi);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.txtVatandasID);
            this.Controls.Add(this.lblMakbuzNo);
            this.Controls.Add(this.lblOdemeYontemi);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.lblVatandasID);
            this.Controls.Add(this.dtpOdemeTarihi);
            this.Controls.Add(this.lblOdemeTarihi);
            this.Name = "FrmOdeme";
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.FrmOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}