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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // bosalankontrol sınıfındaki fonksiyonu çağırıyoruz
            if (bosalankontrol.AreFieldsValid(this))
            {
                // Alanlar doluysa işlemlere devam et
                // MessageBox.Show("Bilet sorgulandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Alanlar boşsa işlem yapılmaz
            }
        }
    }
}
