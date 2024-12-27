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

        private void BiletEkle_Load(object sender, EventArgs e)
        {
            dtwSeferler.DataSource = db.SeferListesi().ToList();
        }

        private void dtwSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string seferId = dtwSeferler.Rows[e.RowIndex].Cells[0].Value.ToString();
                string aracTuru = dtwSeferler.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtSeferId.Text = seferId;
                txtAracTuru.Text = aracTuru;
            }
        }

        private void btnKoltukSec_Click(object sender, EventArgs e)
        {
            if (txtAracTuru.Text == "2+2")
            {
                Koltuk1 koltuk1 = new Koltuk1();
                koltuk1.Show();
            }
            else
            {
                Koltuk2 koltuk2 = new Koltuk2();
                koltuk2.Show();
            }
        }

        private void btnBiletEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Yolcular yolcular = new Yolcular();
                yolcular.yolcuAdi = txtYolcuAdi.Text;
                yolcular.yolcuSoyadi = txtYolcuSoyadi.Text;
                yolcular.yolcuCinsiyet = cmbYolcuCinsiyet.Text;
                yolcular.yolcuDogumTarihi = DateTime.Parse(mskDogumTarih.Text);
                yolcular.yolcuTelNo = mskYolcuTelNo.Text;
                yolcular.yolcuTc = txtYolcuTc.Text;
                db.Yolcular.Add(yolcular);
                db.SaveChanges();

                var yolcuAdi = txtYolcuAdi.Text;
                var yolcu = db.Yolcular
                           .Where(y => y.yolcuAdi == yolcuAdi)
                           .Select(y => new { y.yolcuId, y.yolcuAdi })
                           .FirstOrDefault();
                int seferId = int.Parse(txtSeferId.Text);
                var aracId = db.Seferler.Where(s => s.seferId == seferId)
                            .Select(s => s.aracId)
                            .FirstOrDefault();
                Biletler biletler = new Biletler()
                {
                    
                    biletTarih = DateTime.Now,
                    kullaniciId = Session.KullaniciId,
                    yolcuId = yolcu.yolcuId,
                    aracId = aracId,
                    seferId = seferId,
                    PnrNumarasi = GenerateRandomCode(8),
                    biletUcreti = 1000,
                    odemeYontemi = cmbOdemeTuru.Text,
                    BiletDurumu = "Aktif"
                };
                db.Biletler.Add(biletler);
                db.SaveChanges();
                MessageBox.Show("Bilet başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
