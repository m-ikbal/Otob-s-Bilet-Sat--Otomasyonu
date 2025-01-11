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
    public partial class MailDogrulama : Form
    {
        public MailDogrulama()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public static string Email { get; set; }

        OBSODBEntities db = new OBSODBEntities();

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            string kullaniciMail = txtKullaniciMail.Text.Trim();
            bool emailVarMi = db.Kullanicilar.Any(x => x.kullaniciEposta == kullaniciMail);

            if (emailVarMi) {
                MessageBox.Show("Mail doğrulandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Email = kullaniciMail;
                this.Close();
                SifreGuncelle sifreGuncelle = new SifreGuncelle();
                sifreGuncelle.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz e-posta adresi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
