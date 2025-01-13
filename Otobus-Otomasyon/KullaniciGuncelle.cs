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
    public partial class KullaniciGuncelle : Form
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

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
                            KullanıcıDurumu = item.kullaniciDurumu
                        };
            dgwKullanicilar.DataSource = query.ToList();
        }

        private void KullaniciGuncelle_Load(object sender, EventArgs e)
        {
            KullaniciListele();
        }

        private void dgwKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ad = dgwKullanicilar.Rows[e.RowIndex].Cells[1].Value.ToString();
                string soyad = dgwKullanicilar.Rows[e.RowIndex].Cells[2].Value.ToString();
                string kullaniciAdi = dgwKullanicilar.Rows[e.RowIndex].Cells[3].Value.ToString();
                string kullaniciSifre = dgwKullanicilar.Rows[e.RowIndex].Cells[4].Value.ToString();
                string email = dgwKullanicilar.Rows[e.RowIndex].Cells[5].Value.ToString();
                string rol = dgwKullanicilar.Rows[e.RowIndex].Cells[6].Value.ToString();
                string durum = dgwKullanicilar.Rows[e.RowIndex].Cells[8].Value.ToString();

                txtKullaniciIsim.Text = ad;
                txtKullaniciSoyisim.Text = soyad;
                txtKullaniciAdi.Text = kullaniciAdi;
                txtKullaniciSifre.Text = kullaniciSifre;
                txtKullanciEposta.Text = email;
                cmbKullaniciRol.Text = rol;
                cmbKullaniciDurumu.Text = durum;
            }
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            // Boş alanları kontrol et
            if (string.IsNullOrWhiteSpace(txtKullaniciIsim.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSoyisim.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtKullaniciSifre.Text) ||
                string.IsNullOrWhiteSpace(txtKullanciEposta.Text) ||
                string.IsNullOrWhiteSpace(cmbKullaniciRol.Text) ||
                string.IsNullOrWhiteSpace(cmbKullaniciDurumu.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgwKullanicilar.SelectedRows[0].Cells[0].Value);
                var kullanici = db.Kullanicilar.Find(id);

                // Alanları güncelle
                kullanici.kullaniciIsim = txtKullaniciIsim.Text;
                kullanici.kullaniciSoyisim = txtKullaniciSoyisim.Text;
                kullanici.kullaniciAdi = txtKullaniciAdi.Text;
                kullanici.kullaniciSifre = txtKullaniciSifre.Text;
                kullanici.kullaniciEposta = txtKullanciEposta.Text;
                kullanici.kullaniciRol = cmbKullaniciRol.Text.Trim();
                kullanici.kullaniciDurumu = cmbKullaniciDurumu.Text.Trim();

                // Değişiklikleri kaydet
                db.SaveChanges();
                MessageBox.Show("Kullanıcı Güncellendi");
                KullaniciListele(); // Kullanıcı listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtKullaniciIsim_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir harf değilse, engelle
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Harf olmayan karakterlerin girişini engelle
            }
        }

        private void txtKullaniciSoyisim_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir harf değilse, engelle
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Harf olmayan karakterlerin girişini engelle
            }
        }
    }
}
