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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        OBSODBEntities db = new OBSODBEntities();

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$*";

            Random random = new Random();
            char[] code = new char[length];

            for (int i = 0; i < length; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            return new string(code);
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    txtKullaniciIsim.TextChanged += txtKullaniciIsim_TextChanged;
                    txtKullaniciEposta.TextChanged += txtKullaniciAdi_TextChanged;
                    Kullanicilar kullanicilar = new Kullanicilar();
                    kullanicilar.kullaniciIsim = txtKullaniciIsim.Text;
                    kullanicilar.kullaniciSoyisim = txtKullaniciSoyisim.Text;
                    kullanicilar.kullaniciAdi = txtKullaniciAdi.Text;
                    kullanicilar.kullaniciSifre = txtKullaniciSifre.Text;
                    kullanicilar.kullaniciEposta = txtKullaniciEposta.Text;
                    kullanicilar.kullaniciRol = cmbKullaniciRol.Text.Trim();
                    kullanicilar.kullaniciDurumu = cmbKullaniciDurum.Text.Trim();

                    db.Kullanicilar.Add(kullanicilar);
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtKullaniciIsim_TextChanged(object sender, EventArgs e)
        {
            string randomCode;
            do
            {
                randomCode = GenerateRandomCode(6); // 6 haneli rastgele kod üret
            } while (txtKullaniciAdi.Text.EndsWith(randomCode)); // Aynı kod varsa tekrar üret

            txtKullaniciAdi.Text = txtKullaniciIsim.Text + randomCode;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciEposta.Text = txtKullaniciAdi.Text + "@yyuturizm.com";
            txtKullaniciSifre.Text = txtKullaniciAdi.Text;
        }

        private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciSifre.UseSystemPasswordChar = true;
        }
    }
}
