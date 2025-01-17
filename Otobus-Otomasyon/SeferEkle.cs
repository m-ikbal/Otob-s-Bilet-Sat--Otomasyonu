﻿using System;
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
    public partial class SeferEkle : Form
    {
        public SeferEkle()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void SeferListele()
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();
        }
        private void SeferEkle_Load(object sender, EventArgs e)
        {
            SeferListele();

            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            var values3 = db.Araclar.ToList();
            cmbSeferNereden.DataSource = values;
            cmbSeferNereden.DisplayMember = "sehirAdi";
            cmbSeferNereden.ValueMember = "sehirId";

            cmbSeferNereye.DataSource = values2;
            cmbSeferNereye.DisplayMember = "sehirAdi";
            cmbSeferNereye.ValueMember = "sehirId";

            cmbOtobusTipi.DataSource = values3;
            cmbOtobusTipi.DisplayMember = "aracPlakasi";
            cmbOtobusTipi.ValueMember = "aracId";
        }


        private void btnSeferEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(cmbSeferNereden.Text) ||
                    string.IsNullOrWhiteSpace(cmbSeferNereye.Text) ||
                    string.IsNullOrWhiteSpace(mskKalkisSaati.Text) ||
                    string.IsNullOrWhiteSpace(mskVarisSaati.Text) ||
                    string.IsNullOrWhiteSpace(cmbSeferDurumu.Text) ||
                    cmbOtobusTipi.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                // Tarihlerin kontrolü
                string kalkisTarih = dtpKalkisTarihi.Value.ToString("yyyy-MM-dd");
                string varisTarih = dtpVarisTarihi.Value.ToString("yyyy-MM-dd");

                // Sefer oluşturma ve kaydetme
                Seferler seferler = new Seferler()
                {
                    Kalkis = cmbSeferNereden.Text.Trim(),
                    Varis = cmbSeferNereye.Text.Trim(),
                    SeferKalkisTarihi = kalkisTarih,
                    SeferVarisTarihi = varisTarih,
                    KalkisSaati = TimeSpan.Parse(mskKalkisSaati.Text),
                    VarisSaati = TimeSpan.Parse(mskVarisSaati.Text),
                    seferDurum = cmbSeferDurumu.Text.Trim(),
                    aracId = Convert.ToInt32(cmbOtobusTipi.SelectedValue)
                };

                db.Seferler.Add(seferler);
                db.SaveChanges();
                MessageBox.Show("Sefer Eklendi");
                SeferListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtSaat_TextChanged(object sender, EventArgs e)
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

        private void txtSaat_TextChanged_1(object sender, EventArgs e)
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

        private void mskKalkisSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara (0-9) ve Backspace tuşuna izin ver
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Eğer geçersiz bir karakter girildiyse, yazılmasını engelle
            }
        }

        private void mskVarisSaati_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakamlara (0-9) ve Backspace tuşuna izin ver
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Eğer geçersiz bir karakter girildiyse, yazılmasını engelle
            }
        }
    }
}
