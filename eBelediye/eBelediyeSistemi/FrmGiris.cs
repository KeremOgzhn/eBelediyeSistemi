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


namespace eBelediyeSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTC.Text;
            string sifre = txtSifre.Text;

            // TC Kimlik No ve Şifre boş mu kontrol et
            if (string.IsNullOrEmpty(tcKimlikNo) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen TC Kimlik No ve Şifre girin.");
                return;
            }

            // Eğer bilgiler doğrulanırsa ana menüye yönlendirme
            if (Dogrula(tcKimlikNo, sifre))
            {
                FrmAnaMenu anaMenu = new FrmAnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                // Kullanıcı kaydı yoksa kayıt ekranına yönlendirme teklifi
                DialogResult result = MessageBox.Show("TC Kimlik No veya Şifre yanlış. Kayıt işlemi yapmak ister misiniz?", "Hata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmKayitOl kayitFormu = new FrmKayitOl();
                    kayitFormu.Show();
                    this.Hide();
                }
            }
        }

        // Kayıt Ol butonuna tıklama işlemi
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl kayitFormu = new FrmKayitOl();
            kayitFormu.Show();
            this.Hide();
        }

        // Giriş doğrulama metodu
        private bool Dogrula(string tcKimlikNo, string sifre)
        {
            // Bağlantı dizgenizin doğru olduğundan emin olun
            string connectionString = "server=.;initial catalog=eBelediye;integrated security=sspi";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT VatandasID FROM Vatandas WHERE TC_KimlikNo = @tcKimlikNo AND Sifre = @sifre";
                    SqlCommand command = new SqlCommand(query, con);

                    // Parametreleri ekleyelim
                    command.Parameters.AddWithValue("@tcKimlikNo", tcKimlikNo);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int vatandasID = Convert.ToInt32(result);

                        // Kullanıcı ID'sini ApplicationSettings'e kaydet
                        Properties.Settings.Default.VatandasID = vatandasID;
                        Properties.Settings.Default.Save();

                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    return false;
                }
            }
        }
    }
}




