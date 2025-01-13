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
    public partial class Anasayfa : Form
    {
        OBSODBEntities db = new OBSODBEntities();
        public Anasayfa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            ZamanTimer.Start();
            lblKullaniciAdi.Text = $"Hoş geldin {Session.KullaniciIsim}, Otobüs Bilet Otomasyonu'na";
            // PanelSorgu içeriğini temizle
            PanelSorgu.Controls.Clear();

            // SeferSorgula formunun yeni bir örneğini oluştur
            SeferSorgula seferSorgula = new SeferSorgula();

            // SeferSorgula formunun özelliklerini ayarla
            seferSorgula.TopLevel = false; // Form bağımsız pencere olmamalı
            seferSorgula.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            seferSorgula.Dock = DockStyle.Fill; // Paneli tam doldur

            // SeferSorgula formunu panelin içine ekle
            PanelSorgu.Controls.Add(seferSorgula);
            PanelSorgu.Tag = seferSorgula; // Panelin Tag'ine SeferSorgula formunu ekle

            // SeferSorgula formunu göster
            seferSorgula.Show();
        }

        private void ZamanTimer_Tick_1(object sender, EventArgs e)
        {
            LabelZaman.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
    }
}
