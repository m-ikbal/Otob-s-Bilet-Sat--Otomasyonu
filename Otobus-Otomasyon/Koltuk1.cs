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
    public partial class Koltuk1 : Form
    {
        private int seferId; // Sefer ID için değişken

        public Koltuk1(int seferId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.seferId = seferId;
        }

        OBSODBEntities db = new OBSODBEntities();
        BiletEkle biletEkle = new BiletEkle();

        private void KoltukGuncelle(int aracId)
        {
            try
            {

                var doluKoltuklar = (from b in db.Biletler
                                     join k in db.Koltuklar on b.koltukId equals k.koltukId
                                     where k.koltukDurum == "Dolu" && b.aracId == aracId
                                     select new
                                     {
                                         k.koltukNo,
                                         b.Yolcular.yolcuCinsiyet
                                     }).ToList();

                if (!doluKoltuklar.Any())
                {
                    MessageBox.Show("Dolu koltuk bulunamadı veya araç ID'si yanlış!");
                    return;
                }

                foreach (var koltuk in doluKoltuklar)
                {
                    // Koltuk butonunu bul
                    var button = Controls.Find($"btnKoltuk{koltuk.koltukNo}", true).FirstOrDefault() as Guna.UI2.WinForms.Guna2Button;

                    if (button != null)
                    {
                        // Cinsiyete göre buton rengini güncelle
                        if (koltuk.yolcuCinsiyet == "Erkek")
                        {
                            button.FillColor = Color.Blue;
                        }
                        else if (koltuk.yolcuCinsiyet == "Kadın")
                        {
                            button.FillColor = Color.Pink;
                        } 
                    }
                    else
                    {
                        MessageBox.Show($"Buton bulunamadı: btnKoltuk{koltuk.koltukNo}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void Koltuk1_Load(object sender, EventArgs e)
        {
            try
            {
                if (seferId <= 0)
                {
                    MessageBox.Show("Sefer ID geçerli bir sayı olmalıdır!");
                    return;
                }

                var aracId = db.Seferler
                               .Where(s => s.seferId == seferId)
                               .Select(s => s.aracId)
                               .FirstOrDefault();

                if (aracId != null)
                {
                    KoltukGuncelle(Convert.ToInt32(aracId));
                    AttachButtonClickEvent(this);
                }
                else
                {
                    MessageBox.Show("Belirtilen Sefer ID'ye ait bir Araç ID bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void GunaButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button clickedButton)
            {
                try
                {
                    string koltukNo = clickedButton.Name.Replace("btnKoltuk", "");
                    var aracId = db.Seferler.Where(s => s.seferId == seferId).Select(s => s.aracId).FirstOrDefault();

                    var koltukDurum = db.Koltuklar
                                        .Where(k => k.koltukNo.ToString() == koltukNo && k.aracId == aracId)
                                        .Select(k => k.koltukDurum)
                                        .FirstOrDefault();

                    if (koltukDurum == "Dolu")
                    {
                        MessageBox.Show("Bu koltuk zaten dolu! Başka bir koltuk seçiniz.");
                        return;
                    }

                    if (Application.OpenForms["BiletEkle"] is BiletEkle openForm)
                    {
                        biletEkle = openForm;
                    }
                    else
                    {
                        biletEkle = new BiletEkle();
                        biletEkle.Show();
                    }

                    KoltukSecim koltukSecim = new KoltukSecim(biletEkle);
                    if (koltukSecim.ShowDialog() == DialogResult.OK)
                    {
                        string cinsiyet = KoltukSecim.Cinsiyet;
                        biletEkle.txtCinsiyet.Text = cinsiyet;

                        if (cinsiyet == "Erkek")
                        {
                            clickedButton.FillColor = Color.Blue;
                        }
                        else if (cinsiyet == "Kadın")
                        {
                            clickedButton.FillColor = Color.Pink;
                        }
                    }

                    if (!string.IsNullOrEmpty(koltukNo))
                    {
                        biletEkle.txtKoltukNo.Text = koltukNo;
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir koltuk numarası bulunamadı!");
                    }

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}");
                }
            }
        }

        private void AttachButtonClickEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button gunaButton)
                {
                    gunaButton.Click += GunaButton_Click;
                }
                else if (control.HasChildren)
                {
                    AttachButtonClickEvent(control);
                }
            }
        }
    }
}
