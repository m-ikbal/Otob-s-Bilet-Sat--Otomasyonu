using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string seferId = dgwSeferler.Rows[e.RowIndex].Cells[7].Value.ToString();
                string aracTuru = dgwSeferler.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtSeferId.Text = seferId;
                txtAracTuru.Text = aracTuru;
            }
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if(txtSeferId.Text == "")
            {
                MessageBox.Show("Lütfen bir sefer seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
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
            try
            {
                Yolcular yolcular = new Yolcular();
                yolcular.yolcuAdi = txtYolcuAdi.Text;
                yolcular.yolcuSoyadi = txtYolcuSoyadi.Text;
                yolcular.yolcuCinsiyet = txtCinsiyet.Text;
                yolcular.yolcuDogumTarihi = DateTime.Parse(mskDogumTarih.Text);
                yolcular.yolcuTelNo = mskYolcuTelNo.Text;
                yolcular.yolcuTc = txtYolcuTc.Text;
                yolcular.yolcuEposta = txtYolcuEposta.Text;
                if (yolcular.yolcuAdi == "" || yolcular.yolcuSoyadi == "" || yolcular.yolcuCinsiyet == "" || yolcular.yolcuDogumTarihi == null || yolcular.yolcuTelNo == "" || yolcular.yolcuTc == "" || yolcular.yolcuEposta == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    db.Yolcular.Add(yolcular);
                    db.SaveChanges();
                }

                var yolcuAdi = txtYolcuAdi.Text;
                var yolcu = db.Yolcular
                           .Where(y => y.yolcuAdi == yolcuAdi)
                           .Select(y => new { y.yolcuId, y.yolcuAdi })
                           .FirstOrDefault();

                int seferId = int.Parse(txtSeferId.Text);
                var aracId = db.Seferler.Where(s => s.seferId == seferId)
                            .Select(s => s.aracId)
                            .FirstOrDefault();

                int koltukNo = int.Parse(txtKoltukNo.Text);
                var koltukId = db.Koltuklar
                               .Where(k => k.aracId == aracId && k.koltukNo == koltukNo)
                               .Select(k => k.koltukId)
                               .FirstOrDefault();

                Biletler biletler = new Biletler()
                {
                    biletTarih = DateTime.Now,
                    kullaniciId = Session.KullaniciId,
                    yolcuId = yolcu.yolcuId,
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
                db.SaveChanges();
                MessageBox.Show("Bilet başarıyla eklendi!");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                throw;
            }
        }
    }
}
