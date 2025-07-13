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
    public partial class FrmEBilgi : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";
        public FrmEBilgi()
        {
            InitializeComponent();
        }
        private void FrmEBilgi_Load(object sender, EventArgs e)
        {
            // ApplicationSettings'den VatandasID'yi al
            int vatandasID = eBelediyeSistemi.Properties.Settings.Default.VatandasID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT BilgiTarihi, BilgiDetay FROM EBilgi WHERE VatandasID = @VatandasID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VatandasID", vatandasID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Bilgi detaylarını ekranda göster
                        ListViewItem item = new ListViewItem(reader["BilgiTarihi"].ToString());
                        item.SubItems.Add(reader["BilgiDetay"].ToString());
                        listViewBilgiler.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Bilgi bulunamadı.");
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
