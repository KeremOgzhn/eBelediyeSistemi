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
    public partial class FrmEBeyan : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";

        public FrmEBeyan()
        {
            InitializeComponent();
        }

        private void FrmEBeyan_Load(object sender, EventArgs e)
        {
            // ApplicationSettings'den VatandasID'yi al
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT BeyanTarihi, BeyanDetay FROM EBeyan WHERE VatandasID = @VatandasID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                listViewBeyanlar.Items.Clear();  // Önceki verileri temizle

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["BeyanTarihi"].ToString());
                        item.SubItems.Add(reader["BeyanDetay"].ToString());
                        listViewBeyanlar.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Henüz beyan bulunmamaktadır.");
                }
                reader.Close();
            }
        }

        private void btnBeyanEkle_Click(object sender, EventArgs e)
        {
            // Beyan eklemek için gerekli alanlar boş mu kontrol et
            if (string.IsNullOrEmpty(txtBeyanDetay.Text))
            {
                MessageBox.Show("Lütfen beyan detayını giriniz.");
                return;
            }

            // Vatandaşın ID'sini ve yeni beyan detaylarını al
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;
            DateTime beyanTarihi = DateTime.Now;
            string beyanDetay = txtBeyanDetay.Text;

            // Beyanı veritabanına ekle
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EBeyan (VatandasID, BeyanTarihi, BeyanDetay) VALUES (@VatandasID, @BeyanTarihi, @BeyanDetay)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);
                cmd.Parameters.AddWithValue("@BeyanTarihi", beyanTarihi);
                cmd.Parameters.AddWithValue("@BeyanDetay", beyanDetay);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Beyan başarıyla eklendi.");
                txtBeyanDetay.Clear();  // Beyan detayını temizle
                FrmEBeyan_Load(sender, e);  // Beyanları tekrar yükle
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}

