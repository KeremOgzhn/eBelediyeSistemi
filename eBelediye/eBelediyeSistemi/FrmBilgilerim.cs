using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBelediyeSistemi;

namespace eBelediye
{
    public partial class FrmBilgilerim : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";

        public FrmBilgilerim()
        {
            InitializeComponent();
        }

        private void FrmBilgilerim_Load(object sender, EventArgs e)
        {
            // ApplicationSettings'den VatandasID'yi al
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT TC_KimlikNo, Ad, Soyad, Email, TelefonNo, Sifre FROM Vatandas WHERE VatandasID = @VatandasID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTCNo.Text = reader["TC_KimlikNo"].ToString();
                    txtAd.Text = reader["Ad"].ToString();
                    txtSoyad.Text = reader["Soyad"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtTelefonNo.Text = reader["TelefonNo"].ToString();
                    txtSifre.Text = reader["Sifre"].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgileri bulunamadı.");
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
    }
}

