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
    public partial class FrmBorcSorgulama : Form
    {
        // SQL bağlantısı için connection string
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=sspi";

        public FrmBorcSorgulama()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            // Vatandaş ID ile borçları sorgulama
            int vatandasID;
            if (int.TryParse(txtVatandasID.Text, out vatandasID))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT BorcID, BorcTarihi, BorcTutari, Aciklama FROM Borc WHERE VatandasID = @VatandasID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VatandasID", vatandasID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e verileri yükle
                    dgvBorclar.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Vatandaş ID giriniz.");
            }
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.ShowDialog();
            this.Hide();
        }

        private void FrmBorcSorgulama_Load(object sender, EventArgs e)
        {

        }
    }
}

