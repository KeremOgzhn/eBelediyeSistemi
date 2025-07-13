namespace eBelediye
{
    partial class FrmSSS
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewSSS;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnSSSGoster;
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
            this.dataGridViewSSS = new System.Windows.Forms.DataGridView();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnSSSGoster = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSS)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // dataGridViewSSS
            // 
            this.dataGridViewSSS.AllowUserToAddRows = false;
            this.dataGridViewSSS.AllowUserToDeleteRows = false;
            this.dataGridViewSSS.AllowUserToResizeColumns = false;
            this.dataGridViewSSS.AllowUserToResizeRows = false;
            this.dataGridViewSSS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSSS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "SSSID", HeaderText = "SSS ID", ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Soru", HeaderText = "Soru", ReadOnly = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "Cevap", HeaderText = "Cevap", ReadOnly = true }
            });
            this.dataGridViewSSS.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewSSS.Name = "dataGridViewSSS";
            this.dataGridViewSSS.ReadOnly = true;
            this.dataGridViewSSS.RowHeadersVisible = false;
            this.dataGridViewSSS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSSS.Size = new System.Drawing.Size(760, 320);
            this.dataGridViewSSS.TabIndex = 0;

            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.FromArgb(0, 146, 208); // Bağcılar Belediyesi mavi rengi
            this.btnAnaMenu.ForeColor = System.Drawing.Color.White;
            this.btnAnaMenu.Location = new System.Drawing.Point(687, 388);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(85, 30);
            this.btnAnaMenu.TabIndex = 1;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);

            // 
            // btnSSSGoster
            // 
            this.btnSSSGoster.BackColor = System.Drawing.Color.FromArgb(0, 146, 208); // Bağcılar Belediyesi mavi rengi
            this.btnSSSGoster.ForeColor = System.Drawing.Color.White;
            this.btnSSSGoster.Location = new System.Drawing.Point(596, 388);
            this.btnSSSGoster.Name = "btnSSSGoster";
            this.btnSSSGoster.Size = new System.Drawing.Size(85, 30);
            this.btnSSSGoster.TabIndex = 2;
            this.btnSSSGoster.Text = "SSS Göster";
            this.btnSSSGoster.UseVisualStyleBackColor = false;
            this.btnSSSGoster.Click += new System.EventHandler(this.btnSSSGoster_Click);

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 146, 208); // Bağcılar Belediyesi mavi rengi
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 50);
            this.panelHeader.TabIndex = 3;

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(243, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sıkça Sorulan Sorular";

            // 
            // FrmSSS
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSSSGoster);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dataGridViewSSS);
            this.Name = "FrmSSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağcılar Belediyesi - Sıkça Sorulan Sorular";
            this.Load += new System.EventHandler(this.FrmSSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSS)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
