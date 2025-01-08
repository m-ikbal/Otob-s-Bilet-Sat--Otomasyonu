﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Otobus_Otomasyon
{
    public partial class BiletEkle : Form
    {
        public BiletEkle()
        {
            InitializeComponent();
        }
        OBSODBEntities db = new OBSODBEntities();

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] code = new char[length];

            for (int i = 0; i < length; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            return new string(code);
        }

        private void KoltukDurumuGuncelle(int? aracId, int koltukNo)
        {
            var koltuk = db.Koltuklar.FirstOrDefault(x => x.aracId == aracId && x.koltukNo == koltukNo);
            if (koltuk != null)
            {
                koltuk.koltukDurum = "Dolu";
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Koltuk bulunamadı!");
            }
        }

        private void BiletEkle_Load(object sender, EventArgs e)
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();
        }

        private void dgwSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string seferId = dgwSeferler.Rows[e.RowIndex].Cells[6].Value.ToString();
                string aracTuru = dgwSeferler.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtSeferId.Text = seferId;
                txtAracTuru.Text = aracTuru;
            }
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (txtSeferId.Text == "")
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (txtAracTuru.Text == "2+2")
                {
                    int seferId = int.Parse(txtSeferId.Text);
                    Koltuk1 koltuk1 = new Koltuk1(seferId);
                    koltuk1.Show();
                }
                else
                {
                    int seferId = int.Parse(txtSeferId.Text);
                    Koltuk2 koltuk2 = new Koltuk2(seferId);
                    koltuk2.Show();
                }
            }
        }

        private void btnBiletEkle_Click(object sender, EventArgs e)
        {
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    // Yolcu bilgilerini oluştur
                    Yolcular yolcular = new Yolcular
                    {
                        yolcuAdi = txtYolcuAdi.Text,
                        yolcuSoyadi = txtYolcuSoyadi.Text,
                        yolcuCinsiyet = txtCinsiyet.Text,
                        yolcuTelNo = mskTelefon.Text,
                        yolcuTc = txtYolcuTc.Text,
                        yolcuEposta = txtYolcuEposta.Text
                    };

                    // Doğum tarihi kontrolü
                    string inputDate = mskDogumTarih.Text;
                    if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        yolcular.yolcuDogumTarihi = parsedDate;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen doğum tarihi formatını doğru girin (dd/MM/yyyy).");
                        return;
                    }

                    // Yolcuyu veritabanına ekle
                    db.Yolcular.Add(yolcular);
                    db.SaveChanges();

                    // Sefer ve koltuk bilgilerini al
                    int seferId = int.Parse(txtSeferId.Text);
                    int? aracId = db.Seferler
                    .Where(s => s.seferId == seferId)
                     .Select(s => s.aracId)
                    .FirstOrDefault();

                    if (!aracId.HasValue)
                    {
                        MessageBox.Show("Sefer bilgisi bulunamadı veya araç ID boş.");
                        return;
                    }

                    // Nullable olmayan int değerine erişim
                    int validAracId = aracId.Value;

                    int koltukNo = int.Parse(txtKoltukNo.Text);
                    int koltukId = db.Koltuklar
                                     .Where(k => k.aracId == aracId && k.koltukNo == koltukNo)
                                     .Select(k => k.koltukId)
                                     .FirstOrDefault();

                    // Yeni bilet oluştur
                    Biletler biletler = new Biletler
                    {
                        biletTarih = DateTime.Now,
                        kullaniciId = Session.KullaniciId,
                        yolcuId = yolcular.yolcuId,
                        aracId = aracId,
                        seferId = seferId,
                        koltukId = koltukId,
                        PnrNumarasi = GenerateRandomCode(8),
                        biletUcreti = 1000,
                        odemeYontemi = cmbOdemeTuru.Text,
                        BiletDurumu = "Aktif"
                    };
                    db.Biletler.Add(biletler);
                    KoltukDurumuGuncelle(aracId, koltukNo);

                    // Ödeme kaydı oluştur
                    OdemeKayitlari odemeKayitlari = new OdemeKayitlari
                    {
                        BiletId = biletler.biletId,
                        OdemeTarihi = DateTime.Now,
                        OdemeMiktari = biletler.biletUcreti,
                        OdemeYontemi = cmbOdemeTuru.Text
                    };
                    db.OdemeKayitlari.Add(odemeKayitlari);

                    // Tüm işlemleri kaydet
                    db.SaveChanges();

                    MessageBox.Show("Bilet başarıyla eklendi!");
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.InnerException?.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
                }
            }
        }


        private void mskTelefon_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan girdi
            string input = mskTelefon.Text;

            // Sadece sayıları al
            input = new string(input.Where(char.IsDigit).ToArray());

            // Maksimum 10 rakam sınırını uygula
            if (input.Length > 10)
            {
                input = input.Substring(0, 10);
            }

            // Formatlama
            if (input.Length > 0)
            {
                if (input.Length > 3)
                {
                    input = $"({input.Substring(0, 3)}) {input.Substring(3)}";
                }
                if (input.Length > 9)
                {
                    input = $"{input.Substring(0, 9)}-{input.Substring(9)}";
                }
            }

            // İmleç kaymasını önlemek için mevcut metni güncelle
            mskTelefon.Text = input;
            mskTelefon.SelectionStart = mskTelefon.Text.Length;
        }

        private void mskDogumTarih_TextChanged(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan girdi
            string input = mskDogumTarih.Text;

            // Sadece sayıları al
            input = new string(input.Where(char.IsDigit).ToArray());

            // Maksimum 8 rakam sınırını uygula
            if (input.Length > 8)
            {
                input = input.Substring(0, 8);
            }

            // Formatlama
            if (input.Length > 2)
            {
                input = $"{input.Substring(0, 2)}/{input.Substring(2)}";
            }
            if (input.Length > 5)
            {
                input = $"{input.Substring(0, 5)}/{input.Substring(5)}";
            }

            // İmleç kaymasını önlemek için mevcut metni güncelle
            mskDogumTarih.Text = input;
            mskDogumTarih.SelectionStart = mskDogumTarih.Text.Length;
        }
    }
}
