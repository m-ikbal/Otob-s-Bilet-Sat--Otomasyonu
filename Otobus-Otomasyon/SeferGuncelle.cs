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
    public partial class SeferGuncelle : Form
    {
        public SeferGuncelle()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void SeferGuncelle_Load(object sender, EventArgs e)
        {

            dgwSeferler.DataSource = db.SeferListesi().ToList();

            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            var values3 = db.Araclar.ToList();
            cmbNereden.DataSource = values;
            cmbNereden.DisplayMember = "sehirAdi";
            cmbNereden.ValueMember = "sehirId";

            cmbNereye.DataSource = values2;
            cmbNereye.DisplayMember = "sehirAdi";
            cmbNereye.ValueMember = "sehirId";

            cmbAracId.DataSource = values3;
            cmbAracId.DisplayMember = "aracId";
            cmbAracId.ValueMember = "aracId";
        }

        private void dgwSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string varisSaati = dgwSeferler.Rows[e.RowIndex].Cells[0].Value.ToString();
                string kalkisSaati = dgwSeferler.Rows[e.RowIndex].Cells[1].Value.ToString();
                string seferTarihi = dgwSeferler.Rows[e.RowIndex].Cells[2].Value.ToString();
                string kalkisSehri = dgwSeferler.Rows[e.RowIndex].Cells[3].Value.ToString();
                string varisSehri = dgwSeferler.Rows[e.RowIndex].Cells[4].Value.ToString();
                string seferDurum = dgwSeferler.Rows[e.RowIndex].Cells[5].Value.ToString();

                mskVarisSaati.Text = varisSaati;
                mskKalkisSaati.Text = kalkisSaati;
                dtpTarih.Value = DateTime.Parse(seferTarihi);
                cmbNereden.Text = kalkisSehri;
                cmbNereye.Text = varisSehri;
                cmbSeferDurumu.Text = seferDurum;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    int seferId = Convert.ToInt32(dgwSeferler.CurrentRow.Cells[0].Value);
                    Seferler sefer = db.Seferler.Where(x => x.seferId == seferId).FirstOrDefault();
                    sefer.KalkisSaati = TimeSpan.Parse(mskKalkisSaati.Text);
                    sefer.VarisSaati = TimeSpan.Parse(mskVarisSaati.Text);
                    sefer.seferTarihi = dtpTarih.Value;
                    sefer.Kalkis = cmbNereden.Text;
                    sefer.Varis = cmbNereye.Text;
                    sefer.seferDurum = cmbSeferDurumu.Text;
                    sefer.aracId = Convert.ToInt32(cmbAracId.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("Sefer Güncellendi");
                    dgwSeferler.DataSource = db.SeferListesi().ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
            

        }
    }
}
