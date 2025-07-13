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
    public partial class FrmBasvuruNoSorgulama : Form
    {
        public FrmBasvuruNoSorgulama()
        {
            InitializeComponent();
        }

        // SQL Bağlantı dizesi (veritabanı bağlantısını buraya eklemelisin)
        string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=sspi";

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği başvuru numarasını al
            string basvuruNo = txtBasvuruNo.Text;

            if (!string.IsNullOrEmpty(basvuruNo))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        // BaşvuruNo'ya göre sorgulama yap
                        string query = "SELECT SorgulamaSonucu FROM BasvuruNoSorgulama WHERE BasvuruID = @BasvuruID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BasvuruID", basvuruNo);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                // Sorgulama sonucunu etikete yaz
                                lblSonuc.Text = "Sonuç: " + reader["SorgulamaSonucu"].ToString();
                            }
                            else
                            {
                                lblSonuc.Text = "Başvuru bulunamadı.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir başvuru numarası girin.");
            }
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {           
            FrmAnaMenu anaSayfa = new FrmAnaMenu(); 
            anaSayfa.Show();
            this.Hide(); 
        }

        private void FrmBasvuruNoSorgulama_Load(object sender, EventArgs e)
        {

        }
    }
}

