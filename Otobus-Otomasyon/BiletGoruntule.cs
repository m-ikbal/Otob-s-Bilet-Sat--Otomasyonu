using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class BiletGoruntule : Form
    {
        public BiletGoruntule()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void BiletGoruntule_Load(object sender, EventArgs e)
        {
            dgwBiletleriGoruntule.DataSource = db.BiletListesi().ToList();
        }

        private void btnSeciliListele_Click(object sender, EventArgs e)
        {
            if (chkboxBiletId.Checked)
            {
                int biletId = Convert.ToInt32(txtBiletId.Text);
                var arananId = db.Biletler.Where(x => x.biletId == biletId).ToList();
                if (arananId.Any())
                {
                    var query = from item in db.Biletler
                                where item.biletId == biletId
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
                    dgwBiletleriGoruntule.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu Id'ye ait bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkboxYolcuAdi.Checked)
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
                    dgwBiletleriGoruntule.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Bu yolcu adına ait bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkboxBiletTarihi.Checked)
            {
                var girilenTarih = DateTime.Parse(txtBiletTarihi.Text);
                var tarih = db.Biletler.Where(x => x.biletTarih == girilenTarih).FirstOrDefault();
                if (tarih != null)
                {
                    var query = from item in db.Biletler
                                where item.biletTarih == girilenTarih
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
                    dgwBiletleriGoruntule.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu tarihe ait bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkboxPnrNumarasi.Checked)
            {
                string pnrNumarasi = txtPnrNumarasi.Text;
                var value = db.Biletler.Where(x => x.PnrNumarasi == pnrNumarasi).FirstOrDefault().ToString();
                if (value != null)
                {
                    var query = from item in db.Biletler
                                where item.PnrNumarasi == pnrNumarasi
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
                    dgwBiletleriGoruntule.DataSource = query.ToList();
                }
                else
                {
                    MessageBox.Show("Bu PNR Numarasına ait bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (chkboxBiletDurumu.Checked)
            {
                var biletDurumu = cmbBiletDurumu.Text.Trim();
                var durum = db.Biletler.Where(x => x.BiletDurumu.ToLower() == biletDurumu.ToLower()).ToList();
                if (durum.Any())
                {
                    var query = from item in db.Biletler
                                where item.BiletDurumu == biletDurumu
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
                    dgwBiletleriGoruntule.DataSource = query.ToList();
                }
            }
        }

        private void btnBiletListele_Click(object sender, EventArgs e)
        {
            dgwBiletleriGoruntule.DataSource = db.BiletListesi().ToList();
        }
    }
}
