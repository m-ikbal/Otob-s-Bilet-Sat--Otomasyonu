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
            var rezerve = db.RezervasyonListesi().AsQueryable();
            if (chkBoxRezerveNumarasi.Checked)
            {
                if (int.TryParse(txtRezerveNumarasi.Text, out int rezerveNumarasi))
                {
                    rezerve = rezerve.Where(x => x.Rezerve_Numarası == rezerveNumarasi);
                }
                else
                {
                    MessageBox.Show("Geçerli bir rezerve numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (chkBoxYolcuAdi.Checked)
                {
                    rezerve = rezerve.Where(x => x.Ad_Soyad == txtYolcuAdi.Text);
                }

                if (chkBoxRezerveTarihi.Checked)
                {
                    if (DateTime.TryParse(txtRezerveTarihi.Text, out DateTime rezerveTarihi))
                    {
                        rezerve = rezerve.Where(x => x.RezerveTarihi == rezerveTarihi);
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (chkBoxRezerveDurumu.Checked)
                {
                    rezerve = rezerve.Where(x => x.RezerveDurumu == cmbRezerveDurumu.Text);
                }

                var sonuc = rezerve.ToList();
                if (sonuc.Any())
                {
                    dgwRezervasyonGörüntüle.DataSource = sonuc;
                } else
                {
                    MessageBox.Show("Belirtilen kriterlere uygun rezervasyon bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtRezerveNumarasi.Clear();
                txtYolcuAdi.Clear();
                txtRezerveTarihi.Clear();
                cmbRezerveDurumu.SelectedIndex = -1;
            }
        }
    }
}