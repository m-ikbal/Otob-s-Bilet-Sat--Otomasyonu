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
    public partial class BiletIptalEt : Form
    {
        public BiletIptalEt()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void BiletIptalEt_Load(object sender, EventArgs e)
        {
            dgwBiletIptalEt.DataSource = db.BiletListesi().ToList();
        }

        private void btnBiletAra_Click(object sender, EventArgs e)
        {
            // Alanların doluluğunu kontrol et
            if (string.IsNullOrWhiteSpace(txtPnrNumarasi.Text) || string.IsNullOrWhiteSpace(txtYolcuAdi.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer alanlar boşsa işlemi sonlandır
            }
            if (bosalankontrol.AreFieldsValid(this))
            {
                string yolcuAdi = txtYolcuAdi.Text;
                var query = from item in db.Biletler
                            where item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi == yolcuAdi
                            select new
                            {
                                item.biletId,
                                AdSoyad = item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi,
                                KalkisYeri = item.Seferler.Kalkis,
                                VarisYeri = item.Seferler.Varis,
                                item.biletTarih,
                                item.Koltuklar.koltukNo,
                                item.PnrNumarasi,
                                item.biletUcreti,
                                item.BiletDurumu
                            };
                var result = query.ToList();
                if (result.Any())
                {
                    dgwBiletIptalEt.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Bu yolcu adına ait bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
            }
            
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            // Alanların doluluğunu kontrol et
            if (string.IsNullOrWhiteSpace(txtPnrNumarasi.Text) || string.IsNullOrWhiteSpace(txtYolcuAdi.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eğer alanlar boşsa işlemi sonlandır
            }

            // PNR numarasını al
            string pnrNumarasi = txtPnrNumarasi.Text;

            // Veritabanından PNR numarasına ait bileti bul
            var bilet = db.Biletler.FirstOrDefault(x => x.PnrNumarasi == pnrNumarasi);
            if (bilet != null)
            {
                // Bilet durumunu güncelle
                bilet.BiletDurumu = "İptal Edildi";
                bilet.Koltuklar.koltukDurum = "Boş";
                db.SaveChanges();
                MessageBox.Show("Bilet başarıyla iptal edildi.");
            }
            else
            {
                MessageBox.Show("Belirtilen PNR numarasına ait bir bilet bulunamadı.");
            }
        }
    }
}
