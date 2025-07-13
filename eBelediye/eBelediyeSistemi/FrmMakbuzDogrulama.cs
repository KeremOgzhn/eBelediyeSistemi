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
    public partial class FrmMakbuzDogrulama : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=eBelediye;Integrated Security=True";

        public FrmMakbuzDogrulama()
        {
            InitializeComponent();
        }

        // Doğrulama işlemi
        private void btnDogrula_Click(object sender, EventArgs e)
        {
            string makbuzNo = txtMakbuzNo.Text.Trim();

            if (!string.IsNullOrEmpty(makbuzNo))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT OdemeID FROM Odeme WHERE MakbuzNo = @MakbuzNo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MakbuzNo", makbuzNo);

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int odemeID = Convert.ToInt32(result);
                        lblSonuc.Text = "Makbuz doğrulandı!";
                        lblSonuc.ForeColor = System.Drawing.Color.Green;

                        // Makbuz doğrulama sonucunu kaydet
                        KaydetDogrulama(odemeID, "Başarılı");
                    }
                    else
                    {
                        lblSonuc.Text = "Makbuz bulunamadı.";
                        lblSonuc.ForeColor = System.Drawing.Color.Red;

                        // Başarısız doğrulama sonucunu kaydet
                        KaydetDogrulama(0, "Başarısız");
                    }

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen makbuz numarasını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Doğrulama sonucunu kaydetme
        private void KaydetDogrulama(int odemeID, string sonuc)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MakbuzDogrulama (OdemeID, DogrulamaTarihi, DogrulamaSonucu) " +
                               "VALUES (@OdemeID, @DogrulamaTarihi, @DogrulamaSonucu)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OdemeID", odemeID == 0 ? (object)DBNull.Value : odemeID);
                cmd.Parameters.AddWithValue("@DogrulamaTarihi", DateTime.Now);
                cmd.Parameters.AddWithValue("@DogrulamaSonucu", sonuc);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            FrmAnaMenu frm = new FrmAnaMenu();
            frm.Show();
            this.Hide();
        }
    }
}