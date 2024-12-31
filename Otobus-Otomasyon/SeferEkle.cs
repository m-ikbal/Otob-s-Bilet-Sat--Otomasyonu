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
    public partial class SeferEkle : Form
    {
        public SeferEkle()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();
        private void SeferEkle_Load(object sender, EventArgs e)
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();

            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            var values3 = db.Araclar.ToList();
            cmbSeferNereden.DataSource = values;
            cmbSeferNereden.DisplayMember = "sehirAdi";
            cmbSeferNereden.ValueMember = "sehirId";

            cmbSeferNereye.DataSource = values2;
            cmbSeferNereye.DisplayMember = "sehirAdi";
            cmbSeferNereye.ValueMember = "sehirId";

            cmbOtobusTipi.DataSource = values3;
            cmbOtobusTipi.DisplayMember = "aracPlakasi";
            cmbOtobusTipi.ValueMember = "aracId";
        }


        private void btnSeferEkle_Click(object sender, EventArgs e)
        {

            try
            {
                Seferler seferler = new Seferler()
                {
                    Kalkis = cmbSeferNereden.Text,
                    Varis = cmbSeferNereye.Text,
                    seferTarihi = dtpTarih.Value,
                    KalkisSaati = TimeSpan.Parse(mskKalkisSaati.Text),
                    VarisSaati = TimeSpan.Parse(mskVarisSaati.Text),
                    seferDurum = cmbSeferDurumu.Text,
                    aracId = Convert.ToInt32(cmbOtobusTipi.SelectedValue)
                };
                db.Seferler.Add(seferler);
                db.SaveChanges();
                MessageBox.Show("Sefer Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
