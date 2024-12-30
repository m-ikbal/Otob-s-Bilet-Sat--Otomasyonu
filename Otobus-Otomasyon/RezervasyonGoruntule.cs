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
    public partial class RezervasyonGoruntule : Form
    {
        public RezervasyonGoruntule()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();


        private void RezervasyonlariGoruntule()
        {
            dgwRezervasyonGörüntüle.DataSource = db.RezervasyonListesi().ToList();
        }

        private void RezervasyonGoruntule_Load(object sender, EventArgs e)
        {
            RezervasyonlariGoruntule();
        }



        private void btnRezerveGörüntüle_Click(object sender, EventArgs e)
        {
            RezervasyonlariGoruntule();
        }

        private void btnRezervasyonAra_Click(object sender, EventArgs e)
        {
            if (chkBoxRezerveNumarasi.Checked)
            {
                int rezerveId = Convert.ToInt32(txtRezerveNumarasi.Text);
                var arananId = db.Rezervasyon.Where(x => x.RezerveId == rezerveId).ToList();
                if (arananId.Any())
                {
                    var query = from item in db.Rezervasyon
                                where item.RezerveId == rezerveId
                                select new
                                {
                                    RezervasyonNumarası = item.RezerveId,
                                    AdSoyad = item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi,
                                    PNRNumarası = item.Biletler.PnrNumarasi,
                                    AraçPlakası = item.Araclar.aracPlakasi,
                                    KoltukNumarası = item.Koltuklar.FirstOrDefault().koltukNo,
                                    SeferTarihi = item.Seferler.seferTarihi,
                                    KalkisYeri = item.Seferler.Kalkis,
                                    VarisYeri = item.Seferler.Varis,
                                    item.RezerveTarihi,
                                    item.RezerveDurumu
                                };
                    dgwRezervasyonGörüntüle.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu Rezervasyon Numarasına ait rezervasyon bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkBoxYolcuAdi.Checked)
            {
                string yolcuAdi = txtYolcuAdi.Text;
                var query = from item in db.Rezervasyon
                            where item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi == yolcuAdi
                            select new
                            {
                                RezervasyonNumarası = item.RezerveId,
                                AdSoyad = item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi,
                                PNRNumarası = item.Biletler.PnrNumarasi,
                                AraçPlakası = item.Araclar.aracPlakasi,
                                KoltukNumarası = item.Koltuklar.FirstOrDefault().koltukNo,
                                SeferTarihi = item.Seferler.seferTarihi,
                                KalkisYeri = item.Seferler.Kalkis,
                                VarisYeri = item.Seferler.Varis,
                                item.RezerveTarihi,
                                item.RezerveDurumu
                            };
                var result = query.ToList();
                if (result.Any())
                {
                    dgwRezervasyonGörüntüle.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Bu yolcu adına ait rezervasyon bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkBoxRezerveTarihi.Checked)
            {
                var girilenTarih = DateTime.Parse(txtRezerveTarihi.Text);
                var tarih = db.Rezervasyon.Where(x => x.RezerveTarihi == girilenTarih).FirstOrDefault();
                if (tarih != null)
                {
                    var query = from item in db.Rezervasyon
                                where item.RezerveTarihi == girilenTarih
                                select new
                                {
                                    RezervasyonNumarası = item.RezerveId,
                                    AdSoyad = item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi,
                                    PNRNumarası = item.Biletler.PnrNumarasi,
                                    AraçPlakası = item.Araclar.aracPlakasi,
                                    KoltukNumarası = item.Koltuklar.FirstOrDefault().koltukNo,
                                    SeferTarihi = item.Seferler.seferTarihi,
                                    KalkisYeri = item.Seferler.Kalkis,
                                    VarisYeri = item.Seferler.Varis,
                                    item.RezerveTarihi,
                                    item.RezerveDurumu
                                };
                    dgwRezervasyonGörüntüle.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu tarihe ait rezervasyon bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (chkBoxRezerveDurumu.Checked)
            {
                var rezerveDurumu = cmbRezerveDurumu.Text.Trim();
                var durum = db.Rezervasyon.Where(x => x.RezerveDurumu.ToLower() == rezerveDurumu.ToLower()).ToList();
                if (durum.Any())
                {
                    var query = from item in db.Rezervasyon
                                where item.RezerveDurumu.ToLower() == rezerveDurumu.ToLower()
                                select new
                                {
                                    RezervasyonNumarası = item.RezerveId,
                                    AdSoyad = item.Yolcular.yolcuAdi + " " + item.Yolcular.yolcuSoyadi,
                                    PNRNumarası = item.Biletler.PnrNumarasi,
                                    AraçPlakası = item.Araclar.aracPlakasi,
                                    KoltukNumarası = item.Koltuklar.FirstOrDefault().koltukNo,
                                    SeferTarihi = item.Seferler.seferTarihi,
                                    KalkisYeri = item.Seferler.Kalkis,
                                    VarisYeri = item.Seferler.Varis,
                                    item.RezerveTarihi,
                                    item.RezerveDurumu
                                };
                    dgwRezervasyonGörüntüle.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu durumda rezervasyon bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}