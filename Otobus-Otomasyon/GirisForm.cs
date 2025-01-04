using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Otobus_Otomasyon
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OBSODBEntities db = new OBSODBEntities();
        private void GirisForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.Sifre;
                chcBoxBeniHatirla.Checked = true;
            }
        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                string kullaniciAdi = txtKullaniciAdi.Text;
                string sifre = txtSifre.Text;


                // Boş alan kontrolü
                if (string.IsNullOrEmpty(kullaniciAdi))
                {
                    MessageBox.Show("Kullanıcı Adı kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Şifre kısmı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcı veya admin sorgusu
                var kullanici = db.Kullanicilar.FirstOrDefault(x => x.kullaniciAdi == kullaniciAdi && x.kullaniciSifre == sifre);

                if (kullanici == null)
                {
                    MessageBox.Show("Kullanıcı Adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                kullanici.sonGirisTarihi = DateTime.Now;
                db.SaveChanges();


                // Kullanıcı rolüne göre işlem yap
                Session.KullaniciId = kullanici.kullaniciId;
                Session.KullaniciAdi = kullanici.kullaniciAdi;

                string rolMesaji = kullanici.kullaniciRol == "admin" ? "admin" : "operatör";
                MessageBox.Show($"Başarılı Giriş Yaptınız İşlemler Menüsüne Yönlendiriliyorsunuz...\nKullanıcı Rol: {rolMesaji}", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana formu aç
                Islemler form1 = new Islemler();
                form1.Show();
                form1.KullaniciContainer.Visible = kullanici.kullaniciRol == "admin";
                this.Hide();

                // "Beni Hatırla" ayarlarını kaydet
                if (chcBoxBeniHatirla.Checked)
                {
                    Properties.Settings.Default.KullaniciAdi = kullaniciAdi;
                    Properties.Settings.Default.Sifre = sifre;
                    Properties.Settings.Default.BeniHatirla = true;
                }
                else
                {
                    Properties.Settings.Default.KullaniciAdi = "";
                    Properties.Settings.Default.Sifre = "";
                    Properties.Settings.Default.BeniHatirla = false;
                }
                Properties.Settings.Default.Save();
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
            
        }
    }
}

