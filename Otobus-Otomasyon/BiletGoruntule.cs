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
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                var bilet = db.BiletListesi().AsQueryable();

                if (chkboxBiletNumarasi.Checked)
                {
                    if (int.TryParse(txtBiletNumarasi.Text, out int biletNumarasi))
                    {
                        bilet = bilet.Where(x => x.Bilet_Numarası == biletNumarasi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir bilet numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (chkboxBiletDurumu.Checked)
                {
                    bilet = bilet.Where(x => x.BiletDurumu == cmbBiletDurumu.Text);
                }

                if (chkboxBiletTarihi.Checked)
                {
                    if (DateTime.TryParse(txtBiletTarihi.Text, out DateTime biletTarihi))
                    {
                        bilet = bilet.Where(x => x.biletTarih == biletTarihi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (chkboxYolcuAdi.Checked)
                {
                    string adSoyad = txtYolcuAdi.Text;
                    if (!string.IsNullOrEmpty(adSoyad))
                    {
                        bilet = bilet.Where(x => x.Ad_Soyad == adSoyad);
                    }
                }

                if (chkboxPnrNumarasi.Checked)
                {
                    string pnrNumarasi = txtPnrNumarasi.Text;
                    if (!string.IsNullOrEmpty(pnrNumarasi))
                    {
                        bilet = bilet.Where(x => x.PnrNumarasi == pnrNumarasi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir PNR numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var sonuc = bilet.ToList();
                if (sonuc.Any())
                {
                    dgwBiletleriGoruntule.DataSource = sonuc;
                }
                else
                {
                    MessageBox.Show("Belirtilen kriterlere uygun bilet bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtBiletNumarasi.Clear();
                txtBiletTarihi.Clear();
                txtPnrNumarasi.Clear();
                txtYolcuAdi.Clear();
                cmbBiletDurumu.SelectedIndex = -1;
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
           

        }

        private void btnBiletListele_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                dgwBiletleriGoruntule.DataSource = db.BiletListesi().ToList();
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
            
        }
    }
}
