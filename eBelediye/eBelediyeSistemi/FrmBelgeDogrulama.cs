using eBelediyeSistemi;
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

namespace eBelediye
{
    public partial class FrmBelgeDogrulama : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";

        public FrmBelgeDogrulama()
        {
            InitializeComponent();
        }

        // Butona tıkladığında belgeyi doğrula
        private void btnDogrula_Click(object sender, EventArgs e)
        {
            // Belge ID veya Vatandaş ID alındıktan sonra doğrulama işlemi yapılacak
            int vatandasID;

            if (int.TryParse(txtVatandasID.Text, out vatandasID))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT BelgeID, BelgeTuru, BelgeYolu, YüklemeTarihi FROM Belge WHERE VatandasID = @VatandasID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VatandasID", vatandasID);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Veriler alınıyor
                            int belgeID = reader.GetInt32(0); // BelgeID
                            string belgeTuru = reader.GetString(1); // BelgeTuru
                            string belgeYolu = reader.GetString(2); // BelgeYolu
                            DateTime yuklemeTarihi = reader.GetDateTime(3); // YüklemeTarihi

                            // Verileri ekranda göster
                            lblSonuc.Text = $"Belge ID: {belgeID}\nTür: {belgeTuru}\nYükleme Tarihi: {yuklemeTarihi.ToShortDateString()}";
                        }
                    }
                    else
                    {
                        lblSonuc.Text = "Belge bulunamadı.";
                    }
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Vatandaş ID giriniz.");
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void FrmBelgeDogrulama_Load(object sender, EventArgs e)
        {

        }
    }
}

