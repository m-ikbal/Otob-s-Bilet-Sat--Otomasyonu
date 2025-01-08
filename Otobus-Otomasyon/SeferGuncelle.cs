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
    public partial class SeferGuncelle : Form
    {
        public SeferGuncelle()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        OBSODBEntities db = new OBSODBEntities();

        private void SeferGuncelle_Load(object sender, EventArgs e)
        {
            // Sefer listesini doldur
            dgwSeferler.DataSource = db.SeferListesi().ToList();

            // Şehir ve araç listelerini doldur
            var values = db.Sehirler.ToList();
            var values2 = db.Sehirler.ToList();
            var values3 = db.Araclar.ToList();

            cmbNereden.DataSource = values;
            cmbNereden.DisplayMember = "sehirAdi";
            cmbNereden.ValueMember = "sehirId";

            cmbNereye.DataSource = values2;
            cmbNereye.DisplayMember = "sehirAdi";
            cmbNereye.ValueMember = "sehirId";

            cmbAracId.DataSource = values3;
            cmbAracId.DisplayMember = "aracPlaka";
            cmbAracId.ValueMember = "aracId";
        }

        private void dgwSeferler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Hücre değerlerini al ve kontrol et
                var seferKalkisSaati = dgwSeferler.Rows[e.RowIndex].Cells["Kalkış_Saati"].Value;
                var seferVarisSaati = dgwSeferler.Rows[e.RowIndex].Cells["Varış_Saati"].Value;

                // Kalkış saati
                if (seferKalkisSaati is TimeSpan kalkisSaati)
                {
                    mskKalkisSaati.Text = kalkisSaati.ToString(@"hh\:mm");
                }
                else
                {
                    mskKalkisSaati.Text = seferKalkisSaati?.ToString();
                }

                // Varış saati
                if (seferVarisSaati is TimeSpan varisSaati)
                {
                    mskVarisSaati.Text = varisSaati.ToString(@"hh\:mm");
                }
                else
                {
                    mskVarisSaati.Text = seferVarisSaati?.ToString();
                }

                // Diğer alanlar
                dtpKalkisTarihi.Value = DateTime.Parse(dgwSeferler.Rows[e.RowIndex].Cells["Sefer_Kalkış_Tarihi"].Value.ToString());
                dtpVarisTarihi.Value = DateTime.Parse(dgwSeferler.Rows[e.RowIndex].Cells["Sefer_Varış_Tarihi"].Value.ToString());
                cmbNereden.Text = dgwSeferler.Rows[e.RowIndex].Cells["Kalkış_Yeri"].Value.ToString();
                cmbNereye.Text = dgwSeferler.Rows[e.RowIndex].Cells["Varış_Yeri"].Value.ToString();
                cmbSeferDurumu.Text = dgwSeferler.Rows[e.RowIndex].Cells["Sefer_Durumu"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (bosalankontrol.AreFieldsValid(this))
            {
                try
                {
                    // Tarihleri al
                    DateTime tarih = dtpKalkisTarihi.Value;
                    DateTime tarih2 = dtpVarisTarihi.Value;

                    // Sefer ID
                    int seferId = Convert.ToInt32(dgwSeferler.CurrentRow.Cells["Sefer_Numarası"].Value);
                    Seferler sefer = db.Seferler.FirstOrDefault(x => x.seferId == seferId);

                    // Kalkış saati
                    if (TimeSpan.TryParse(mskKalkisSaati.Text, out TimeSpan kalkisSaati))
                    {
                        sefer.KalkisSaati = kalkisSaati;
                    }
                    else
                    {
                        MessageBox.Show("Kalkış saati geçerli bir formatta değil!");
                        return;
                    }

                    // Varış saati
                    if (TimeSpan.TryParse(mskVarisSaati.Text, out TimeSpan varisSaati))
                    {
                        sefer.VarisSaati = varisSaati;
                    }
                    else
                    {
                        MessageBox.Show("Varış saati geçerli bir formatta değil!");
                        return;
                    }

                    // Diğer alanları güncelle
                    sefer.SeferKalkisTarihi = tarih.ToString("yyyy-MM-dd");
                    sefer.SeferVarisTarihi = tarih2.ToString("yyyy-MM-dd");
                    sefer.Kalkis = cmbNereden.Text;
                    sefer.Varis = cmbNereye.Text;
                    sefer.seferDurum = cmbSeferDurumu.Text;
                    sefer.aracId = Convert.ToInt32(cmbAracId.SelectedValue);

                    // Değişiklikleri kaydet
                    db.SaveChanges();
                    MessageBox.Show("Sefer Güncellendi");

                    // Listeyi yenile
                    dgwSeferler.DataSource = db.SeferListesi().ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }


        private void mskKalkisSaati_TextChanged(object sender, EventArgs e)
        {
            // Kalkış saati formatını kontrol et
            string text = mskKalkisSaati.Text;

            // Eğer saat metni 2 karakterden küçükse, kullanıcıya daha fazla karakter girmesi için izin ver
            if (text.Length == 2 && !text.Contains(":"))
            {
                mskKalkisSaati.Text = text.Insert(2, ":"); // 2. karakterden sonra ':' ekle
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length;  // Kursoru sona getir
            }

            // Saat formatının 5 karakter olmasını kontrol et (örneğin: __:__)
            if (text.Length > 5)
            {
                mskKalkisSaati.Text = text.Substring(0, 5); // 5 karakterden fazla girişi engelle
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length; // Kursoru sona getir
            }

            // Eğer kullanıcı silme işlemi yaparsa (boşluğu kaldırmak için), ":"'yi de silmek için kontrol et
            if (text.Length == 4 && text.EndsWith(":"))
            {
                mskKalkisSaati.Text = text.Substring(0, 4); // ":" karakterini sil
                mskKalkisSaati.SelectionStart = mskKalkisSaati.Text.Length; // Kursoru sona getir
            }
        }

        private void mskVarisSaati_TextChanged(object sender, EventArgs e)
        {
            // Varış saati formatını kontrol et
            string text = mskVarisSaati.Text;

            if (text.Length == 2 && !text.Contains(":"))
            {
                mskVarisSaati.Text = text.Insert(2, ":"); // 5 karakterden fazla girişi engelle
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length; // Kursoru sona getir
            }

            // Saat formatının 5 karakter olmasını kontrol et (örneğin: __:__)

            if (text.Length > 5)
            {
                mskVarisSaati.Text = text.Substring(0, 5);
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length;
            }

            // Eğer kullanıcı silme işlemi yaparsa (boşluğu kaldırmak için), ":"'yi de silmek için kontrol et

            if (text.Length == 4 && text.EndsWith(":"))
            {
                mskVarisSaati.Text = text.Substring(0, 4); // ":" karakterini sil
                mskVarisSaati.SelectionStart = mskVarisSaati.Text.Length; // Kursoru sona getir
            }
        }
    }
}
