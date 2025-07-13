using eBelediyeSistemi;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace eBelediye
{
    public partial class FrmKariyerMerkezi : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=sspi";

        public FrmKariyerMerkezi()
        {
            InitializeComponent();
        }

        private void FrmKariyerMerkezi_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadKariyerData();
        }
        private void LoadKariyerData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT KariyerID, IsID, Pozisyon, Tarih, Detay FROM KariyerMerkezi";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                dataGridViewKariyer.Rows.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridViewKariyer.Rows.Add(
                            reader["KariyerID"].ToString(),
                            reader["IsID"].ToString(), // Güncellenmiş sütun adı
                            reader["Pozisyon"].ToString(),
                            reader["Tarih"].ToString(),
                            reader["Detay"].ToString()
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Henüz kariyer merkezi verisi bulunmamaktadır.");
                }
                reader.Close();
            }
        }
        private void InitializeDataGridView()
        {
            dataGridViewKariyer.Columns.Add("KariyerID", "Kariyer ID");
            dataGridViewKariyer.Columns.Add("IsID", "Is ID"); // Güncellenmiş sütun adı
            dataGridViewKariyer.Columns.Add("Pozisyon", "Pozisyon");
            dataGridViewKariyer.Columns.Add("Tarih", "Tarih");
            dataGridViewKariyer.Columns.Add("Detay", "Detay");
        }
        private void btnPozisyonEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVacantID.Text) || string.IsNullOrEmpty(txtPozisyon.Text) || string.IsNullOrEmpty(txtDetay.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            string vacantID = txtVacantID.Text;
            string pozisyon = txtPozisyon.Text;
            DateTime tarih = dateTimePickerTarih.Value;  // Vatandaşın seçtiği tarih
            string detay = txtDetay.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KariyerMerkezi (IsID, Pozisyon, Tarih, Detay) VALUES (@IsID, @Pozisyon, @Tarih, @Detay)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IsID", vacantID); // Güncellenmiş sütun adı
                cmd.Parameters.AddWithValue("@Pozisyon", pozisyon);
                cmd.Parameters.AddWithValue("@Tarih", tarih);  // Seçilen tarih veritabanına eklenir
                cmd.Parameters.AddWithValue("@Detay", detay);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pozisyon başarıyla eklendi.");
                ClearFields();
                LoadKariyerData();
            }
        }
        private void ClearFields()
        {
            txtVacantID.Clear();
            txtPozisyon.Clear();
            txtDetay.Clear();
            dateTimePickerTarih.Value = DateTime.Now;  // Tarih alanını sıfırla
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }
        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {
            if (dataGridViewKariyer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen başvurmak istediğiniz pozisyonu seçiniz.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewKariyer.SelectedRows[0];
            int kariyerID = Convert.ToInt32(selectedRow.Cells["KariyerID"].Value);
            string vacantID = selectedRow.Cells["IsID"].Value.ToString();
            string pozisyon = selectedRow.Cells["Pozisyon"].Value.ToString();
            DateTime tarih = Convert.ToDateTime(selectedRow.Cells["Tarih"].Value);
            string detay = selectedRow.Cells["Detay"].Value.ToString();

            
            MessageBox.Show($"Başvurunuz başarıyla yapılmıştır.\nPozisyon: {pozisyon}\nİş ID: {vacantID}");
        }
    }
}