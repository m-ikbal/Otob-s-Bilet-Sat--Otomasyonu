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
                string kalkisSehri = dgwSeferler.Rows[e.RowIndex].Cells[2].Value.ToString();
                string varisSehri = dgwSeferler.Rows[e.RowIndex].Cells[3].Value.ToString();
                string seferDurum = dgwSeferler.Rows[e.RowIndex].Cells[4].Value.ToString();
                string seferKalkisTarihi = dgwSeferler.Rows[e.RowIndex].Cells[7].Value.ToString();
                string seferVarisTarihi = dgwSeferler.Rows[e.RowIndex].Cells[8].Value.ToString();


                mskVarisSaati.Text = varisSaati;
                mskKalkisSaati.Text = kalkisSaati;
                dtpKalkisTarihi.Value = DateTime.Parse(seferKalkisTarihi);
                dtpVarisTarihi.Value = DateTime.Parse(seferVarisTarihi);
                cmbNereden.Text = kalkisSehri;
                cmbNereye.Text = varisSehri;
                cmbSeferDurumu.Text = seferDurum;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    DateTime tarih = dtpKalkisTarihi.Value;
                    DateTime tarih2 = dtpVarisTarihi.Value;
                    string sadeceTarih = tarih.ToString("yyyy-MM-dd");
                    string sadeceTarih2 = tarih2.ToString("yyyy-MM-dd");
                    int seferId = Convert.ToInt32(dgwSeferler.CurrentRow.Cells[0].Value);
                    Seferler sefer = db.Seferler.Where(x => x.seferId == seferId).FirstOrDefault();
                    sefer.KalkisSaati = TimeSpan.Parse(mskKalkisSaati.Text);
                    sefer.VarisSaati = TimeSpan.Parse(mskVarisSaati.Text);
                    sefer.SeferKalkisTarihi = sadeceTarih;
                    sefer.SeferVarisTarihi = sadeceTarih2;
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
            }
            

        }

        private void mskKalkisSaati_TextChanged(object sender, EventArgs e)
        {
            string text = mskKalkisSaati.Text;

            // Eğer saat metni 2 karakterden küçükse, kullanıcıya daha fazla karakter girmesi için izin ver
            if (text.Length == 2 && !text.Contains(":"))
            {
                mskKalkisSaati.Text = text.Insert(2, ":");  // 2. karakterden sonra ':' ekle
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length;  // Kursoru sona getir
            }

            // Saat formatının 5 karakter olmasını kontrol et (örneğin: __:__)
            if (text.Length > 5)
            {
                mskKalkisSaati.Text = text.Substring(0, 5);  // 5 karakterden fazla girişi engelle
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length;  // Kursoru sona getir
            }

            // Eğer kullanıcı silme işlemi yaparsa (boşluğu kaldırmak için), ":"'yi de silmek için kontrol et
            if (text.Length == 4 && text.EndsWith(":"))
            {
                mskKalkisSaati.Text = text.Substring(0, 4);  // ":" karakterini sil
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length;  // Kursoru sona getir
            }
        }

        private void mskVarisSaati_TextChanged(object sender, EventArgs e)
        {
string text = mskVarisSaati.Text;

            // Eğer saat metni 2 karakterden küçükse, kullanıcıya daha fazla karakter girmesi için izin ver
            if (text.Length == 2 && !text.Contains(":"))
            {
                mskVarisSaati.Text = text.Insert(2, ":");  // 2. karakterden sonra ':' ekle
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length;  // Kursoru sona getir
            }

            // Saat formatının 5 karakter olmasını kontrol et (örneğin: __:__)
            if (text.Length > 5)
            {
                mskVarisSaati.Text = text.Substring(0, 5);  // 5 karakterden fazla girişi engelle
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length;  // Kursoru sona getir
            }

            // Eğer kullanıcı silme işlemi yaparsa (boşluğu kaldırmak için), ":"'yi de silmek için kontrol et
            if (text.Length == 4 && text.EndsWith(":"))
            {
                mskVarisSaati.Text = text.Substring(0, 4);  // ":" karakterini sil
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length;  // Kursoru sona getir
            }
        }
    }
}
