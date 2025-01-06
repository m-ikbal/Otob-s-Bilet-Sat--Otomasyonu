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
    public partial class AracIslemleri : Form
    {
        public AracIslemleri()
        {
            InitializeComponent();
        }

        OBSODBEntities db = new OBSODBEntities();

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                string aracAdi = cmbAracAdi.SelectedItem.ToString();
                string plaka = txtAracPlakasi.Text;
                string aracTipi = cmbAracTipi.SelectedItem.ToString();
                string aracDurumu = cmbAracDurumu.SelectedItem.ToString();

                if (aracTipi == "2+2")
                {
                    txtAracKapasitesi.Text = "30";
                }
                else
                {
                    txtAracKapasitesi.Text = "22";
                }
                int kapasite = int.Parse(txtAracKapasitesi.Text);

                Araclar araclar = new Araclar()
                {
                    aracAdi = aracAdi,
                    aracPlakasi = plaka,
                    aracTipi = aracTipi,
                    aracKapasitesi = kapasite,
                    aracDurumu = aracDurumu
                };
                if (db.Araclar.Any(x => x.aracPlakasi == plaka))
                {
                    MessageBox.Show("Araç plakası zaten mevcut!");
                    return;
                }
                db.Araclar.Add(araclar);
                db.SaveChanges();

                var koltuklar = new List<Koltuklar>();

                if (aracTipi == "2+1")
                { // Toplam eklenmesi gereken koltuk sayısı
                    int koltukSayaci = 1; // Koltuk numaralarını doğru takip etmek için

                    for (int sira = 1; sira <= 22; sira++) // Koltukları siraya göre ayarla
                    {
                        if (sira == 1 || sira == 4 || sira == 7 || sira == 10 || sira == 11 || sira == 14 || sira == 17 || sira == 20)
                        {
                            // Sol tarafa koltuk ekle
                            koltuklar.Add(new Koltuklar
                            {
                                aracId = araclar.aracId,
                                koltukNo = koltukSayaci++,
                                koltukKonum = "Sol",
                                koltukDurum = "Boş"
                            });
                        }
                        else if (sira == 2 || sira == 3 || sira == 5 || sira == 6 || sira == 8 || sira == 9 || sira == 12 || sira == 13 || sira == 15 || sira == 16 || sira == 18 || sira == 19 || sira == 21 || sira == 22)
                        {
                            // Sağ tarafa koltuk ekle
                            koltuklar.Add(new Koltuklar
                            {
                                aracId = araclar.aracId,
                                koltukNo = koltukSayaci++,
                                koltukKonum = "Sağ",
                                koltukDurum = "Boş"
                            });
                        }
                    }
                }
                else if (aracTipi == "2+2")
                {
                    int toplamKoltuk = 30;
                    int koltukSayaci = 1; // Koltuklar numaralarını doğru takip etmek için

                    for (int sira = 1; sira <= 7; sira++) // İlk 7 sira tamamen dolu
                    {
                        // Sol tarafta 2 Koltuklar
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayaci++,
                            koltukKonum = "Sol",
                            koltukDurum = "Boş"
                        });
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayaci++,
                            koltukKonum = "Sol",
                            koltukDurum = "Boş"
                        });

                        // Sağ tarafta 2 koltuk (Özel durum: 13 ve 14'ten sonra sağ taraf boş bırakılır)
                        if (koltukSayaci == 15 || koltukSayaci == 16)
                        {
                            continue; // Sağ tarafı boş geç
                        }

                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayaci++,
                            koltukKonum = "Sağ",
                            koltukDurum = "Boş"
                        });
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayaci++,
                            koltukKonum = "Sağ",
                            koltukDurum = "Boş"
                        });
                    }

                    // 8. sirada sadece 2 koltuk ekle
                    if (koltukSayaci <= toplamKoltuk)
                    {
                        // Sol tarafta 2 koltuk
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayaci++,
                            koltukKonum = "Sol",
                            koltukDurum = "Boş"
                        });
                        if (koltukSayaci <= toplamKoltuk)
                        {
                            koltuklar.Add(new Koltuklar
                            {
                                aracId = araclar.aracId,
                                koltukNo = koltukSayaci++,
                                koltukKonum = "Sol",
                                koltukDurum = "Boş"
                            });
                        }
                        if (koltukSayaci <= toplamKoltuk)
                        {
                            koltuklar.Add(new Koltuklar
                            {
                                aracId = araclar.aracId,
                                koltukNo = koltukSayaci++,
                                koltukKonum = "Sağ",
                                koltukDurum = "Boş"
                            });
                        }
                        if (koltukSayaci <= toplamKoltuk)
                        {
                            koltuklar.Add(new Koltuklar
                            {
                                aracId = araclar.aracId,
                                koltukNo = koltukSayaci++,
                                koltukKonum = "Sağ",
                                koltukDurum = "Boş"
                            });
                        }
                    }
                }
                db.Koltuklar.AddRange(koltuklar);
                db.SaveChanges();

                MessageBox.Show("Araç ve koltuklar başarıyla eklendi!");
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
        }

        private void Temizle()
        {
            txtAracId.Clear();
            txtAraAracPlakasi.Clear();
            txtAracPlakasi.Clear();
            txtAracKapasitesi.Clear();
            cmbAracAdi.SelectedIndex = -1;
            cmbAracTipi.SelectedIndex = -1;
        }
        private void Araclar()
        {
            var query = from arac in db.Araclar
                        select new
                        {
                            arac.aracId,
                            arac.aracAdi,
                            arac.aracPlakasi,
                            arac.aracTipi,
                            arac.aracKapasitesi,
                            arac.aracDurumu
                        };
            var sonuc = query.Where(x => x.aracDurumu.ToLower() == "Aktif".ToLower()).ToList();
            dgwAraclar.DataSource = sonuc.ToList();
            Temizle();
        }

        private void AracIslemleri_Load(object sender, EventArgs e)
        {
            Araclar();
        }


        private void btnAracAra_Click(object sender, EventArgs e)
        {
            var query = from arac in db.Araclar
                        select new
                        {
                            arac.aracId,
                            arac.aracAdi,
                            arac.aracPlakasi,
                            arac.aracTipi,
                            arac.aracKapasitesi,
                            arac.aracDurumu
                        };
            var sonuc = query.Where(x => x.aracPlakasi.ToLower() == txtAraAracPlakasi.Text.ToLower()).ToList();
            dgwAraclar.DataSource = sonuc;
            Temizle();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtAracId.Text);
            var araclar = db.Araclar.Find(id);
            araclar.aracAdi = cmbAracAdi.Text;
            araclar.aracPlakasi = txtAracPlakasi.Text;
            araclar.aracTipi = cmbAracTipi.Text;
            if (cmbAracTipi.Text == "2+2")
            {
                txtAracKapasitesi.Text = "30";
            }
            else
            {
                txtAracKapasitesi.Text = "22";
            }
            araclar.aracKapasitesi = int.Parse(txtAracKapasitesi.Text);
            db.SaveChanges();
            MessageBox.Show("Araç bilgileri güncellendi!");
            Araclar();
            Temizle();
        }

        private void dgwAraclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string aracId = dgwAraclar.CurrentRow.Cells[0].Value.ToString();
            string aracAdi = dgwAraclar.CurrentRow.Cells[1].Value.ToString();
            string aracTipi = dgwAraclar.CurrentRow.Cells[3].Value.ToString();
            string aracPlakasi = dgwAraclar.CurrentRow.Cells[2].Value.ToString();
            string aracKapasitesi = dgwAraclar.CurrentRow.Cells[4].Value.ToString();

            txtAracId.Text = aracId;
            if (!string.IsNullOrEmpty(aracAdi))
            {
                // ComboBox'a ekleme (eğer listede yoksa)
                if (!cmbAracAdi.Items.Contains(aracAdi))
                {
                    cmbAracAdi.Items.Add(aracAdi);
                }

                // ComboBox'ta seçili hale getirme
                cmbAracAdi.SelectedItem = aracAdi;
            }
            txtAracPlakasi.Text = aracPlakasi;
            if (!string.IsNullOrEmpty(aracTipi))
            {
                // ComboBox'a ekleme (eğer listede yoksa)
                if (!cmbAracTipi.Items.Contains(aracTipi))
                {
                    cmbAracTipi.Items.Add(aracTipi);
                }

                // ComboBox'ta seçili hale getirme
                cmbAracTipi.SelectedItem = aracTipi;
            }
            txtAracKapasitesi.Text = aracKapasitesi;
        }

        private void btnAracIptalEt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtAracId.Text);
            var arac = db.Araclar.FirstOrDefault(x => x.aracId == id);
            if (arac != null)
            {
                arac.aracDurumu = "Pasif";
                db.SaveChanges();
                MessageBox.Show("Araç başarıyla silindi!");
                Araclar();
                Temizle();
            }
            else
            {
                MessageBox.Show("Belirtilen araç numarasına ait bir araç bulunamadı.");
                Temizle();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Araclar();
            Temizle();
        }

        private void btnTumAraclariListele_Click(object sender, EventArgs e)
        {
            var query = from arac in db.Araclar
                        select new
                        {
                            arac.aracId,
                            arac.aracAdi,
                            arac.aracPlakasi,
                            arac.aracTipi,
                            arac.aracKapasitesi,
                            arac.aracDurumu
                        };
            dgwAraclar.DataSource = query.ToList();
            Temizle();
        }
    }
}
