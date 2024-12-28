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
            string aracAdi = cmbAracAdi.SelectedItem.ToString();
            string plaka = txtAracPlakasi.Text;
            string aracTipi = cmbAracTipi.SelectedItem.ToString();

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
                aracKapasitesi = kapasite
            };

            db.Araclar.Add(araclar);
            db.SaveChanges();

            var koltuklar = new List<Koltuklar>();

            if (aracTipi == "2+1")
            {
                int toplamKoltuk = 22; // Toplam eklenmesi gereken koltuk sayısı
                int koltukSayacı = 1; // Koltuk numaralarını doğru takip etmek için

                for (int sıra = 1; sıra <= 22; sıra++) // Koltukları sıraya göre ayarla
                {
                    if (sıra == 1 || sıra == 4 || sıra == 7 || sıra == 10 || sıra == 11 || sıra == 14 || sıra == 17 || sıra == 20)
                    {
                        // Sol tarafa koltuk ekle
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayacı++,
                            koltukKonum = "Sol",
                            koltukDurum = "Boş"
                        });
                    }
                    else if (sıra == 2 || sıra == 3 || sıra == 5 || sıra == 6 || sıra == 8 || sıra == 9 || sıra == 12 || sıra == 13 || sıra == 15 || sıra == 16 || sıra == 18 || sıra == 19 || sıra == 21 || sıra == 22)
                    {
                        // Sağ tarafa koltuk ekle
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayacı++,
                            koltukKonum = "Sağ",
                            koltukDurum = "Boş"
                        });
                    }
                }
            }
            else if (aracTipi == "2+2")
            {
                int toplamKoltuk = 30;
                int koltukSayacı = 1; // Koltuklar numaralarını doğru takip etmek için

                for (int sıra = 1; sıra <= 7; sıra++) // İlk 7 sıra tamamen dolu
                {
                    // Sol tarafta 2 Koltuklar
                    koltuklar.Add(new Koltuklar
                    {
                        aracId = araclar.aracId,
                        koltukNo = koltukSayacı++,
                        koltukKonum = "Sol",
                        koltukDurum = "Boş"
                    });
                    koltuklar.Add(new Koltuklar
                    {
                        aracId = araclar.aracId,
                        koltukNo = koltukSayacı++,
                        koltukKonum = "Sol",
                        koltukDurum = "Boş"
                    });

                    // Sağ tarafta 2 koltuk (Özel durum: 13 ve 14'ten sonra sağ taraf boş bırakılır)
                    if (koltukSayacı == 15 || koltukSayacı == 16)
                    {
                        continue; // Sağ tarafı boş geç
                    }

                    koltuklar.Add(new Koltuklar
                    {
                        aracId = araclar.aracId,
                        koltukNo = koltukSayacı++,
                        koltukKonum = "Sağ",
                        koltukDurum = "Boş"
                    });
                    koltuklar.Add(new Koltuklar
                    {
                        aracId = araclar.aracId,
                        koltukNo = koltukSayacı++,
                        koltukKonum = "Sağ",
                        koltukDurum = "Boş"
                    });
                }

                // 8. sırada sadece 2 koltuk ekle
                if (koltukSayacı <= toplamKoltuk)
                {
                    // Sol tarafta 2 koltuk
                    koltuklar.Add(new Koltuklar
                    {
                        aracId = araclar.aracId,
                        koltukNo = koltukSayacı++,
                        koltukKonum = "Sol",
                        koltukDurum = "Boş"
                    });
                    if (koltukSayacı <= toplamKoltuk)
                    {
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayacı++,
                            koltukKonum = "Sol",
                            koltukDurum = "Boş"
                        });
                    }
                    if (koltukSayacı <= toplamKoltuk)
                    {
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayacı++,
                            koltukKonum = "Sağ",
                            koltukDurum = "Boş"
                        });
                    }
                    if (koltukSayacı <= toplamKoltuk)
                    {
                        koltuklar.Add(new Koltuklar
                        {
                            aracId = araclar.aracId,
                            koltukNo = koltukSayacı++,
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
    }
}
