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
    public partial class RezervasyonIptalEt : Form
    {
        public RezervasyonIptalEt()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void btnRezervasyonIptalEt_Click(object sender, EventArgs e)
        {
            int rezervasyonNo = int.Parse(txtRezervasyonNumarasi.Text);
            var rezervasyon = db.Rezervasyon.FirstOrDefault(x => x.RezerveId == rezervasyonNo);

            if (rezervasyon != null)
            {
                rezervasyon.RezerveDurumu = "İptal Edildi";
                db.SaveChanges();
                MessageBox.Show("Rezervasyon iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Belirtilen rezervasyon numarasına ait bir bilet bulunamadı.");
            }
        }

        private void RezervasyonIptalEt_Load(object sender, EventArgs e)
        {
            dgwRezervasyonListesi.DataSource = db.RezervasyonListesi().ToList();
        }
    }
}
