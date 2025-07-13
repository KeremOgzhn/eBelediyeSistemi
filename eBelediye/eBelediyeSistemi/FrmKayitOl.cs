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
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtTC.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sifre = txtSifre.Text;
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;

            if (string.IsNullOrEmpty(tcKimlikNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) ||
                string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Kayıt işlemi kodu
            if (KayitOl(tcKimlikNo, ad, soyad, sifre, email, telefon))
            {
                MessageBox.Show("Kayıt başarıyla tamamlandı!");
                FrmGiris girisFormu = new FrmGiris();
                girisFormu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu.");
            }
        }
        private bool KayitOl(string tcKimlikNo, string ad, string soyad, string sifre, string email, string telefon)
        {
            using (SqlConnection con = new SqlConnection("server= .;initial catalog=eBelediye;integrated security=sspi"))
            {
                con.Open();
                string query = "INSERT INTO Vatandas (TC_KimlikNo, Ad, Soyad, Sifre, Email, TelefonNo) VALUES (@tcKimlikNo, @ad, @soyad, @sifre, @email, @telefon)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@tcKimlikNo", tcKimlikNo);
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyad", soyad);
                command.Parameters.AddWithValue("@sifre", sifre);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@telefon", telefon);
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmGiris girisFormu = new FrmGiris();
            girisFormu.Show();
            this.Close();
        }

    }
}

