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
    public partial class FrmEEksper : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";
        public FrmEEksper()
        {
            InitializeComponent();
        }
        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;
            DateTime eksperTarihi = dtpEksperTarihi.Value;
            string eksperDetay = txtEksperDetay.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO EEksper (VatandasID, EksperTarihi, EksperDetay) VALUES (@VatandasID, @EksperTarihi, @EksperDetay)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);
                cmd.Parameters.AddWithValue("@EksperTarihi", eksperTarihi);
                cmd.Parameters.AddWithValue("@EksperDetay", eksperDetay);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başvurunuz başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Başvuru sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            FrmAnaMenu anaMenu = new FrmAnaMenu();
            anaMenu.Show();
            this.Hide();
        }
        private void FrmEEksper_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde gerekli işlemler yapılabilir
        }
    }
}

