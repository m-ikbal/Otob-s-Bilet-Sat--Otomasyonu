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
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    int id = int.Parse(txtKullaniciId.Text);
                    var kullanici = db.Kullanicilar.FirstOrDefault(x => x.kullaniciId == id);
                    if (kullanici != null)
                    {
                        kullanici.kullaniciDurumu = "Pasif";
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        KullaniciListele();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen kullanıcı numarasına ait bir kullanıcı bulunamadı.");
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
