using eBelediye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eBelediyeSistemi
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }
        // Borç Sorgulama Butonu Tıklama Olayı
        private void btnBorcSorgulama_Click(object sender, EventArgs e)
        {
            FrmBorcSorgulama frm = new FrmBorcSorgulama();
            frm.Show();
            this.Hide();
        }

        // Ödeme Butonu Tıklama Olayı
        private void btnOdeme_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme();
            frm.Show();
            this.Hide();
        }

        // Makbuz Doğrulama Butonu Tıklama Olayı
        private void btnMakbuzDogrulama_Click(object sender, EventArgs e)
        {
            FrmMakbuzDogrulama frm = new FrmMakbuzDogrulama();
            frm.Show();
            this.Hide();
        }

        // Başvuru No ile Sorgulama Butonu Tıklama Olayı
        private void btnBasvuruNoSorgulama_Click(object sender, EventArgs e)
        {
            FrmBasvuruNoSorgulama frm = new FrmBasvuruNoSorgulama();
            frm.Show();
            this.Hide();
        }

        // Belge Doğrulama Butonu Tıklama Olayı
        private void btnBelgeDogrulama_Click(object sender, EventArgs e)
        {
            FrmBelgeDogrulama frm = new FrmBelgeDogrulama();
            frm.Show();
            this.Hide();
        }

        // Bilgilerim Butonu Tıklama Olayı
        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            FrmBilgilerim frm = new FrmBilgilerim();
            frm.Show();
            this.Hide();
        }

        // E-Başvuru Butonu Tıklama Olayı
        private void btnEBasvuru_Click(object sender, EventArgs e)
        {
            FrmEBasvuru frm = new FrmEBasvuru();
            frm.Show();
            this.Hide();
        }

        // E-Eksper Butonu Tıklama Olayı
        private void btnEEksper_Click(object sender, EventArgs e)
        {
            FrmEEksper frm = new FrmEEksper();
            frm.Show();
            this.Hide();
        }

        // E-Bilgi Butonu Tıklama Olayı
        private void btnEBilgi_Click(object sender, EventArgs e)
        {
            FrmEBilgi frm = new FrmEBilgi();
            frm.Show();
            this.Hide();
        }
        // E-Beyan Butonu Tıklama Olayı
        private void btnEBeyan_Click(object sender, EventArgs e)
        {
            FrmEBeyan frm = new FrmEBeyan();
            frm.Show();
            this.Hide();
        }
        // Kariyer Merkezi Butonu Tıklama Olayı
        private void btnKariyerMerkezi_Click(object sender, EventArgs e)
        {
            FrmKariyerMerkezi frm = new FrmKariyerMerkezi();
            frm.Show();
            this.Hide();
        }
   
        // Sıkça Sorulan Sorular Butonu Tıklama Olayı
        private void btnSSS_Click(object sender, EventArgs e)
        {
            FrmSSS frm = new FrmSSS();
            frm.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Hide();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }

}

