using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class KullaniciGoruntule : Form
    {
        public KullaniciGoruntule()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();
        private void Listele()
        {
            dgwKullanicilar.DataSource = db.Kullanicilar.ToList();
        }


        private void KullaniciGoruntule_Load(object sender, EventArgs e)
        {
            Listele();  
        }

        // Kullanıcı Ara Butonuna Tıklama
        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            string arama = txtAdSoyad.Text.Trim();  // Kullanıcıdan gelen değeri alıyoruz

            // Eğer arama alanı boşsa
            if (string.IsNullOrEmpty(arama))
            {
                MessageBox.Show("Lütfen bir ad veya soyad girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Arama işlemi
            dgwKullanicilar.DataSource = db.Kullanicilar
                .Where(x => x.kullaniciIsim.Contains(arama) || x.kullaniciSoyisim.Contains(arama))
                .ToList();
        }

        // Sıfırlama Butonuna Tıklama
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            // Listeyi sıfırlama işlemi
            Listele();
            MessageBox.Show("Kullanıcı listesi Yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
