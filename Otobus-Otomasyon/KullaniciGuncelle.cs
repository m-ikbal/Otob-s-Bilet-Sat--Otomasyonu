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
                            SonGiris = item.sonGirisTarihi
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

                txtKullaniciIsim.Text = ad;
                txtKullaniciSoyisim.Text = soyad;
                txtKullaniciAdi.Text = kullaniciAdi;
                txtKullaniciSifre.Text = kullaniciSifre;
                txtKullanciEposta.Text = email;
                cmbKullaniciRol.Text = rol;
            }
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    int id = Convert.ToInt32(dgwKullanicilar.SelectedRows[0].Cells[0].Value);
                    var kullanici = db.Kullanicilar.Find(id);
                    kullanici.kullaniciIsim = txtKullaniciIsim.Text;
                    kullanici.kullaniciSoyisim = txtKullaniciSoyisim.Text;
                    kullanici.kullaniciAdi = txtKullaniciAdi.Text;
                    kullanici.kullaniciSifre = txtKullaniciSifre.Text;
                    kullanici.kullaniciEposta = txtKullanciEposta.Text;
                    kullanici.kullaniciRol = cmbKullaniciRol.Text.Trim();
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı Güncellendi");
                    KullaniciListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
            }
           
        }
    }
}
