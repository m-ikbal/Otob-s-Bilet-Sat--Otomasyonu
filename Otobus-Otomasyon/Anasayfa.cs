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
    public partial class Anasayfa : Form
    {
        OBSODBEntities db = new OBSODBEntities();
        public Anasayfa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            ZamanTimer.Start();
            lblKullaniciAdi.Text = $"Hoş geldin {Session.KullaniciIsim}, Otobüs Bilet Otomasyonu'na";
        }

        private void ZamanTimer_Tick_1(object sender, EventArgs e)
        {
            LabelZaman.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
