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

        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            string arama = txtAdSoyad.Text;
            dgwKullanicilar.DataSource = db.Kullanicilar.Where(x => x.kullaniciIsim.Contains(arama) || x.kullaniciSoyisim.Contains(arama)).ToList();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
