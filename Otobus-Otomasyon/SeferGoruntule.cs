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
    public partial class SeferGoruntule : Form
    {
        public SeferGoruntule()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void Seferler()
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();
        }

        private void SeferGoruntule_Load(object sender, EventArgs e)
        {
            Seferler();
        }

        private void btnSeferSifirla_Click(object sender, EventArgs e)
        {
            Seferler();
        }

        private void btnSeferListesi_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                var seferler = db.SeferListesi().AsQueryable();

                if (chkBoxSeferDurumu.Checked)
                {
                    seferler = seferler.Where(x => x.Sefer_Durumu == cmbSeferDurumu.Text);
                }

                if (chkBoxSeferSaati.Checked)
                {
                    if (DateTime.TryParse(txtSeferTarihi.Text, out DateTime seferTarihi))
                    {
                        seferler = seferler.Where(x => x.Sefer_Tarihi == seferTarihi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (chkBoxSeferNumarasi.Checked)
                {
                    if (int.TryParse(txtSeferNumarasi.Text, out int seferNumarasi))
                    {
                        seferler = seferler.Where(x => x.Sefer_Numarası == seferNumarasi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir numara giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var sonuc = seferler.ToList();

                if (sonuc.Any())
                {
                    dgwSeferler.DataSource = sonuc;
                }
                else
                {
                    MessageBox.Show("Belirtilen kriterlere uygun sefer bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtSeferNumarasi.Clear();
                txtSeferTarihi.Clear();
                cmbSeferDurumu.SelectedIndex = -1;
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
            
        }

    }
}