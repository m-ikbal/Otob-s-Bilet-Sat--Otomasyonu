using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public partial class BiletGuncelle : Form
    {
        public BiletGuncelle()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtCinsiyet.Clear();
            mskTelefon.Clear();
            txtTcNo.Clear();
            txtEposta.Clear();
            mskDogumTarih.Clear();
            txtSeferId.Clear();
            txtAracTuru.Clear();
            txtKoltukNo.Clear();
        }
        private void Yolcular()
        {
            var query = from yolcu in db.Yolcular
                        join Biletler in db.Biletler on yolcu.yolcuId equals Biletler.yolcuId
                        where Biletler.BiletDurumu.ToLower() == "aktif"
                        select new
                        {
                            Yolcu_Numarası = yolcu.yolcuId,
                            Yolcu_Ad = yolcu.yolcuAdi,
                            Yolcu_Soyad = yolcu.yolcuSoyadi,
                            TcNo = yolcu.yolcuTc,
                            Telefon = yolcu.yolcuTelNo,
                            E_Posta = yolcu.yolcuEposta,
                            Cinsiyet = yolcu.yolcuCinsiyet,
                            Doğum_Tarihi = yolcu.yolcuDogumTarihi,
                        };
            dgwYolcular.DataSource = query.ToList();
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

        private void BiletGuncelle_Load(object sender, EventArgs e)
        {
            dgwSeferler.DataSource = db.SeferListesi().ToList();
            Yolcular();
        }

        private void dgwYolcular_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string yolcuNo = dgwYolcular.CurrentRow.Cells[0].Value.ToString();
            string yolcuAd = dgwYolcular.CurrentRow.Cells[1].Value.ToString();
            string yolcuSoyad = dgwYolcular.CurrentRow.Cells[2].Value.ToString();
            string tcNo = dgwYolcular.CurrentRow.Cells[3].Value.ToString();
            string telefon = dgwYolcular.CurrentRow.Cells[4].Value.ToString();
            string ePosta = dgwYolcular.CurrentRow.Cells[5].Value.ToString();
            string cinsiyet = dgwYolcular.CurrentRow.Cells[6].Value.ToString();
            string dogumTarihi = dgwYolcular.CurrentRow.Cells[7].Value.ToString();

            txtTcNo.Text = tcNo;
            txtAd.Text = yolcuAd;
            txtSoyad.Text = yolcuSoyad;
            mskTelefon.Text = telefon;
            txtEposta.Text = ePosta;
            txtCinsiyet.Text = cinsiyet;
            mskDogumTarih.Text = dogumTarihi;

            string tcKimlikNo = txtTcNo.Text;

            var biletBilgileri = (from bilet in db.Biletler
                                  join sefer in db.Seferler
                                  on bilet.seferId equals sefer.seferId
                                  join yolcu in db.Yolcular on bilet.yolcuId equals yolcu.yolcuId
                                  where yolcu.yolcuTc == tcKimlikNo
                                  select new
                                  {
                                      bilet.seferId,
                                      bilet.Koltuklar.koltukNo,
                                      sefer.Araclar.aracTipi,
                                      bilet.biletUcreti
                                  }).FirstOrDefault();

            if (biletBilgileri != null)
            {
                txtSeferId.Text = biletBilgileri.seferId.ToString();
                txtKoltukNo.Text = biletBilgileri.koltukNo.ToString();
                txtAracTuru.Text = biletBilgileri.aracTipi;
                txtBiletUcreti.Text = biletBilgileri.biletUcreti.ToString();
            }
            else
            {
                MessageBox.Show("Seçilen yolcunun bilet bilgileri bulunamadı.");
            }
        }

        private void dgwSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string seferNo = dgwSeferler.CurrentRow.Cells[7].Value.ToString();
            string aracTuru = dgwSeferler.CurrentRow.Cells[6].Value.ToString();
            txtSeferId.Text = seferNo;
            txtAracTuru.Text = aracTuru;
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

        private void btnBiletAra_Click(object sender, EventArgs e)
        {
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txtSeferId.Text) ||
                    string.IsNullOrWhiteSpace(txtKoltukNo.Text) ||
                    string.IsNullOrWhiteSpace(txtTcNo.Text) ||
                    string.IsNullOrWhiteSpace(txtAd.Text) ||
                    string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                    string.IsNullOrWhiteSpace(mskTelefon.Text) ||
                    string.IsNullOrWhiteSpace(txtEposta.Text) ||
                    string.IsNullOrWhiteSpace(txtCinsiyet.Text) ||
                    string.IsNullOrWhiteSpace(mskDogumTarih.Text) ||
                    string.IsNullOrWhiteSpace(txtBiletUcreti.Text))
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                    return;
                }

                // Sefer ID ve Koltuk No dönüşüm kontrolü
                if (!int.TryParse(txtSeferId.Text, out int seferId) || !int.TryParse(txtKoltukNo.Text, out int koltukNo))
                {
                    MessageBox.Show("Sefer ID ve Koltuk No sayısal bir değer olmalıdır.");
                    return;
                }

                // Doğum tarihi formatı kontrolü
                if (!DateTime.TryParseExact(mskDogumTarih.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dogumTarihi))
                {
                    MessageBox.Show("Lütfen doğum tarihi formatını doğru girin (dd/MM/yyyy).");
                    return;
                }

                // Bilet ücreti format kontrolü
                if (!decimal.TryParse(txtBiletUcreti.Text, out decimal biletUcreti))
                {
                    MessageBox.Show("Bilet ücreti geçerli bir sayı olmalıdır.");
                    return;
                }

                // Güncelleme işlemleri
                var aracId = db.Seferler.Where(s => s.seferId == seferId)
                            .Select(s => s.aracId)
                            .FirstOrDefault();

                int yolcuId = db.Yolcular.Where(x => x.yolcuTc == txtTcNo.Text).Select(x => x.yolcuId).FirstOrDefault();
                Biletler bilet = db.Biletler.Where(x => x.yolcuId == yolcuId).FirstOrDefault();

                if (bilet == null)
                {
                    MessageBox.Show("Güncellenecek bilet bulunamadı.");
                    return;
                }

                bilet.yolcuId = yolcuId;
                bilet.biletUcreti = biletUcreti;
                bilet.seferId = seferId;
                bilet.koltukId = db.Koltuklar.Where(x => x.koltukNo == koltukNo).Select(x => x.koltukId).FirstOrDefault();

                Yolcular yolcular = db.Yolcular.Where(x => x.yolcuTc == txtTcNo.Text).FirstOrDefault();
                if (yolcular != null)
                {
                    yolcular.yolcuTc = txtTcNo.Text;
                    yolcular.yolcuAdi = txtAd.Text;
                    yolcular.yolcuSoyadi = txtSoyad.Text;
                    yolcular.yolcuTelNo = mskTelefon.Text;
                    yolcular.yolcuEposta = txtEposta.Text;
                    yolcular.yolcuCinsiyet = txtCinsiyet.Text;
                    yolcular.yolcuDogumTarihi = dogumTarihi;
                }

                KoltukDurumuGuncelle(aracId, koltukNo);
                db.SaveChanges();
                MessageBox.Show("Bilet güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
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

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir harf değilse, engelle
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Harf olmayan karakterlerin girişini engelle
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir harf değilse, engelle
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Harf olmayan karakterlerin girişini engelle
            }
        }
    }
}
