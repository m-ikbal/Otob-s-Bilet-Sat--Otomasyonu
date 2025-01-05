﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
        }
        private void SeferSorgula_Load(object sender, EventArgs e)
        {
            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            cmbNereden.DataSource = values;
            cmbNereden.DisplayMember = "sehirAdi";
            cmbNereden.ValueMember = "sehirId";

            cmbNereye.DataSource = values2;
            cmbNereye.DisplayMember = "sehirAdi";
            cmbNereye.ValueMember = "sehirId";
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
            DateTime tarih = dtpSeferTarihi.Value.Date;

            var secilenSefer = db.Seferler
    .Where(s =>
        s.Kalkis == kalkis &&
        s.Varis == varis &&
        s.seferTarihi == tarih && 
        s.seferDurum.ToLower() == "aktif")
    .FirstOrDefault(); 
            MessageBox.Show($"Kalkış: {kalkis}, Varış: {varis}, Tarih: {tarih}");

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
                                   Konum = koltuk.koltukKonum
                               };

            if (bosKoltuklar.Any())
            {
                dgwSeferler.DataSource = bosKoltuklar.ToList();
                MessageBox.Show("Seferde boş koltuklar mevcut. Koltuk seçimi yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seçtiğiniz sefere ait boş koltuk bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
