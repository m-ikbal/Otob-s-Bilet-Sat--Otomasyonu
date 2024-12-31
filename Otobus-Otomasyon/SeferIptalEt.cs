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
    public partial class SeferIptalEt : Form
    {
        public SeferIptalEt()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void SeferListele()
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();
        }

        private void SeferIptalEt_Load(object sender, EventArgs e)
        {
            SeferListele();
        }

        private void btnSeferIptalEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSeferId.Text);
            var sefer = db.Seferler.FirstOrDefault(x => x.seferId == id);
            if (sefer != null)
            {
                sefer.seferDurum = "İptal Edildi";
                db.SaveChanges();
                MessageBox.Show("Sefer iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SeferListele();
            }
            else
            {
                MessageBox.Show("Belirtilen sefer numarasına ait bir sefer bulunamadı.");

            }
        }
    }
}
