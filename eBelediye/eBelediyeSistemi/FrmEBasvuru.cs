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
    public partial class FrmEBasvuru : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";
        public FrmEBasvuru()
        {
            InitializeComponent();
        }
        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;
            DateTime basvuruTarihi = dtpBasvuruTarihi.Value;
            string basvuruDetay = txtBasvuruDetay.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EBasvuru (VatandasID, BasvuruTarihi, BasvuruDetay) VALUES (@VatandasID, @BasvuruTarihi, @BasvuruDetay)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);
                cmd.Parameters.AddWithValue("@BasvuruTarihi", basvuruTarihi);
                cmd.Parameters.AddWithValue("@BasvuruDetay", basvuruDetay);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başvurunuz başarıyla yapıldı.");
                con.Close();
            }
        }
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }
        private void FrmEBasvuru_Load(object sender, EventArgs e)
        {

        }
    }
}

