using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Otobus_Otomasyon
{
    public partial class SeferSorgula : Form
    {
       
        OBSODBEntities db = new OBSODBEntities();
        public SeferSorgula()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cmbNereden.AutoCompleteCustomSource.AddRange(
                db.Sehirler.AsEnumerable().Select(s => s.sehirAdi.ToLower(new CultureInfo("tr-TR"))).ToArray()
            );
            cmbNereden.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNereden.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cmbNereye.AutoCompleteCustomSource.AddRange(
                db.Sehirler.AsEnumerable().Select(s => s.sehirAdi.ToLower(new CultureInfo("tr-TR"))).ToArray()
            );
            cmbNereye.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNereye.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void SeferSorgula_Load(object sender, EventArgs e)
        {
            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            
        }

        private void DegistirButton_Click(object sender, EventArgs e)
        {
            string temp = cmbNereden.Text;
            cmbNereden.Text = cmbNereye.Text;
            cmbNereye.Text = temp;
        }

        private void btnBiletAra_Click(object sender, EventArgs e)
        {
            string kalkis = cmbNereden.Text;
            string varis = cmbNereye.Text;
            string tarih = dtpSeferTarihi.Value.ToString("yyyy-MM-dd").Trim();

            var secilenSefer = db.Seferler.Where(s =>
                                s.Kalkis.ToLower() == kalkis.ToLower() &&
                                s.Varis.ToLower() == varis.ToLower() &&
                                s.SeferKalkisTarihi.Trim() == tarih.Trim() &&
                                s.seferDurum.Replace("\u00A0", "").Trim().ToLower() == "aktif")
                                .FirstOrDefault();


            if (secilenSefer == null)
            {
                MessageBox.Show("Seçtiğiniz kriterlere uygun aktif bir sefer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bosKoltuklar = from koltuk in db.Koltuklar
                               where koltuk.aracId == secilenSefer.aracId &&
                                     koltuk.koltukDurum == "Boş"
                               select new
                               {
                                   KoltukNo = koltuk.koltukNo,
                                   Konum = koltuk.koltukKonum,
                                   SeferKalkışSaati = secilenSefer.KalkisSaati,

                               };

            if (bosKoltuklar.Any())
            {
                dgwSeferler.DataSource = bosKoltuklar.ToList();
                MessageBox.Show("Sefer saati ve sefere ait boş koltuklar listelendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sefer bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
