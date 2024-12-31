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
        private void KullaniciListele()
        {
            var query = from item in db.Kullanicilar
                        select new
                        {
                            KullanıcıId = item.kullaniciId,
                            Ad = item.kullaniciAd,
                            Soyad = item.kullaniciSoyad,
                            KullanıcıAdı = item.kullaniciAdi,
                            Şifre = item.kullaniciSifre,
                            Eposta = item.kullaniciEposta,
                            Rol = item.kullaniciRol,
                            SonGiris = item.sonGirisTarihi
                        };
            dgwKullanicilar.DataSource = query.ToList();
        }

        private void dgwKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KullaniciListele();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtKullaniciId.Text);
                var kullanici = db.Kullanicilar.Find(id);
                db.Kullanicilar.Remove(kullanici);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı Silindi");
                KullaniciListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata", ex.Message);
            }

        }
    }
}
