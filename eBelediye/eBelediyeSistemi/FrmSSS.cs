using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using eBelediyeSistemi;


namespace eBelediye
{
    public partial class FrmSSS : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=sspi";
        public FrmSSS()
        {
            InitializeComponent();
        }
        private void FrmSSS_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadSSSData();
        }
        private void InitializeDataGridView()
        {
            dataGridViewSSS.Columns.Add("SSSID", "SSS ID");
            dataGridViewSSS.Columns.Add("Soru", "Soru");
            dataGridViewSSS.Columns.Add("Cevap", "Cevap");
        }
        private void LoadSSSData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SSSID, Soru, Cevap FROM SSS";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridViewSSS.Rows.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridViewSSS.Rows.Add(
                            reader["SSSID"].ToString(),
                            reader["Soru"].ToString(),
                            reader["Cevap"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Henüz sıkça sorulan sorular bulunmamaktadır.");
                }
                reader.Close();
            }
        }
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }
        private void btnSSSGoster_Click(object sender, EventArgs e)
        {
            if (dataGridViewSSS.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewSSS.SelectedRows[0];
                string soru = selectedRow.Cells["Soru"].Value.ToString();
                string cevap = selectedRow.Cells["Cevap"].Value.ToString();

                MessageBox.Show($"Soru: {soru}\nCevap: {cevap}", "SSS Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir Sıkça Sorulan Soruyu seçin.", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

