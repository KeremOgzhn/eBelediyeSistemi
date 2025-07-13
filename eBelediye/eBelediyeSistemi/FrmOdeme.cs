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
    public partial class FrmOdeme : Form
    {
        // SQL bağlantısı için connection string
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";

        public FrmOdeme()
        {
            InitializeComponent();
            LoadOdemeData(); // Ödemeleri yükle
        }

        // Ödeme ekleme
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            int vatandasID;
            decimal odemeTutari;

            if (int.TryParse(txtVatandasID.Text, out vatandasID) &&
                decimal.TryParse(txtOdemeTutari.Text, out odemeTutari))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Odeme (VatandasID, OdemeTarihi, OdemeTutari, OdemeYontemi, MakbuzNo) " +
                                   "VALUES (@VatandasID, @OdemeTarihi, @OdemeTutari, @OdemeYontemi, @MakbuzNo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VatandasID", vatandasID);
                    cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@OdemeTutari", odemeTutari);
                    cmd.Parameters.AddWithValue("@OdemeYontemi", txtOdemeYontemi.Text);
                    cmd.Parameters.AddWithValue("@MakbuzNo", txtMakbuzNo.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Ödeme başarıyla kaydedildi.");
                    LoadOdemeData(); // Ödeme listesini yenile
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir Vatandaş ID ve Ödeme Tutarı giriniz.");
            }
        }

        // Ödeme verilerini DataGridView'e yükle
        private void LoadOdemeData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT OdemeID, VatandasID, OdemeTarihi, OdemeTutari, OdemeYontemi, MakbuzNo FROM Odeme";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdemeler.DataSource = dt;
            }
        }

        // Ana menüye geri dönüş
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {

        }
    }
}

