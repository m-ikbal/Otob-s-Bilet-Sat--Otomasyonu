using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OBSODBEntities db = new OBSODBEntities();

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string yeniSifre = txtSifre1.Text.Trim();
            string yeniSifreTekrar = txtSifre2.Text.Trim();
            string email = MailDogrulama.Email;

            // Şifrelerin aynı olup olmadığını kontrol et
            if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(yeniSifreTekrar))
            {
                MessageBox.Show("Şifre alanları boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Şifreler aynı değil, lütfen kontrol edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var kullanici = db.Kullanicilar.SingleOrDefault(x => x.kullaniciEposta == email);

                if (kullanici != null)
                {
                    kullanici.kullaniciSifre = yeniSifre;
                    db.SaveChanges();

                    MessageBox.Show("Şifre başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-posta adresiyle eşleşen kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
