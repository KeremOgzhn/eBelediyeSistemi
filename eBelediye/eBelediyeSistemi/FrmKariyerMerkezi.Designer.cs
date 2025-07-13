namespace eBelediye
{
    partial class FrmKariyerMerkezi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewKariyer;
        private System.Windows.Forms.Button btnPozisyonEkle;
        private System.Windows.Forms.TextBox txtVacantID;
        private System.Windows.Forms.TextBox txtPozisyon;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnBasvuruYap;

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
            this.dataGridViewKariyer = new System.Windows.Forms.DataGridView();
            this.btnPozisyonEkle = new System.Windows.Forms.Button();
            this.txtVacantID = new System.Windows.Forms.TextBox();
            this.txtPozisyon = new System.Windows.Forms.TextBox();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKariyer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKariyer
            // 
            this.dataGridViewKariyer.AllowUserToAddRows = false;
            this.dataGridViewKariyer.AllowUserToDeleteRows = false;
            this.dataGridViewKariyer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKariyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKariyer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKariyer.Name = "dataGridViewKariyer";
            this.dataGridViewKariyer.ReadOnly = true;
            this.dataGridViewKariyer.RowHeadersWidth = 51;
            this.dataGridViewKariyer.RowTemplate.Height = 24;
            this.dataGridViewKariyer.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewKariyer.TabIndex = 0;
            // 
            // btnPozisyonEkle
            // 
            this.btnPozisyonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnPozisyonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPozisyonEkle.ForeColor = System.Drawing.Color.White;
            this.btnPozisyonEkle.Location = new System.Drawing.Point(590, 553);
            this.btnPozisyonEkle.Name = "btnPozisyonEkle";
            this.btnPozisyonEkle.Size = new System.Drawing.Size(150, 40);
            this.btnPozisyonEkle.TabIndex = 1;
            this.btnPozisyonEkle.Text = "Pozisyon Ekle";
            this.btnPozisyonEkle.UseVisualStyleBackColor = false;
            this.btnPozisyonEkle.Click += new System.EventHandler(this.btnPozisyonEkle_Click);
            // 
            // txtVacantID
            // 
            this.txtVacantID.Location = new System.Drawing.Point(590, 381);
            this.txtVacantID.Name = "txtVacantID";
            this.txtVacantID.Size = new System.Drawing.Size(150, 22);
            this.txtVacantID.TabIndex = 2;
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(590, 436);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(150, 22);
            this.txtPozisyon.TabIndex = 3;
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(540, 494);
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(200, 22);
            this.txtDetay.TabIndex = 4;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(580, 320);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTarih.TabIndex = 5;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAnaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(12, 400);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(150, 40);
            this.btnAnaMenu.TabIndex = 6;
            this.btnAnaMenu.Text = "Ana Menüye Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnBasvuruYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasvuruYap.ForeColor = System.Drawing.Color.White;
            this.btnBasvuruYap.Location = new System.Drawing.Point(12, 320);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(150, 40);
            this.btnBasvuruYap.TabIndex = 7;
            this.btnBasvuruYap.Text = "Başvuru Yap";
            this.btnBasvuruYap.UseVisualStyleBackColor = false;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "İş Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pozisyon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarih";
            // 
            // FrmKariyerMerkezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasvuruYap);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtDetay);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.txtVacantID);
            this.Controls.Add(this.btnPozisyonEkle);
            this.Controls.Add(this.dataGridViewKariyer);
            this.Name = "FrmKariyerMerkezi";
            this.Text = "Kariyer Merkezi";
            this.Load += new System.EventHandler(this.FrmKariyerMerkezi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKariyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
