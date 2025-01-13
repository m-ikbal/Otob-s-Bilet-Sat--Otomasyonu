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
    public partial class KullaniciSil : Form
    {
        public KullaniciSil()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();
        private void KullaniciSil_Load(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void KullaniciListele()
        {
            var query = from item in db.Kullanicilar
                        select new
                        {
                            KullanıcıId = item.kullaniciId,
                            Ad = item.kullaniciIsim,
                            Soyad = item.kullaniciSoyisim,
                            KullanıcıAdı = item.kullaniciAdi,
                            Şifre = item.kullaniciSifre,
                            Eposta = item.kullaniciEposta,
                            Rol = item.kullaniciRol,
                            SonGiris = item.sonGirisTarihi,
                            Durum = item.kullaniciDurumu
                        };
            dgwKullanicilar.DataSource = query.ToList();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            // Kullanıcı ID alanının boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(txtKullaniciId.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcı numarasını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = int.Parse(txtKullaniciId.Text);
                var kullanici = db.Kullanicilar.FirstOrDefault(x => x.kullaniciId == id);
                if (kullanici != null)
                {
                    // Kullanıcıyı pasif yap
                    kullanici.kullaniciDurumu = "Pasif";
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KullaniciListele(); // Kullanıcı listesini yenile
                    return;
                }
                else
                {
                    MessageBox.Show("Belirtilen kullanıcı numarasına ait bir kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
