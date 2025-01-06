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
    public partial class Islemler : Form
    {
        bool siderbarExpand;
        bool biletcollapsed;
        bool sefercollapsed;
        bool rezervasyoncollapsed;
        bool kullanicicollapsed;
        public Islemler()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormGoster(Form childForm)
        {
            // Panel24'ün içeriğini temizle
            PanelContainer.Controls.Clear();

            // Alt formun özelliklerini ayarla
            childForm.TopLevel = false; // Formun bağımsız pencere olmamasını sağla
            childForm.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            childForm.Dock = DockStyle.Fill; // Panelin tamamını kapla

            // Panel24 içine alt formu ekle
            PanelContainer.Controls.Add(childForm);
            PanelContainer.Tag = childForm;

            // Formu göster
            childForm.Show();
        }

        //private void PanelGöster(Panel selectedPanel)
        //{
        //    // Gizlemek istediğiniz panellerin listesini fonksiyon içinde tanımlayın
        //    List<Panel> panelsToHide = new List<Panel> { /*paneldenem1,*/ /*PanelSeferGoruntule, PanelSeferSil, PanelSeferEkle, PanelBiletSil, PanelAnasayfa, PanelSeferGuncelle, PanelKullaniciEkle, PanelKullaniciGoruntule, PanelKullaniciGuncelle, PanelKullaniciSil*/ /*panel4*/ }; // Burada panelleri listeye ekleyin

        //    // Seçilen paneli belirtilen konuma taşı
        //    selectedPanel.Location = new Point(278, 0);

        //    // Seçilen panelin yüksekliğini ve genişliğini maksimum değerlere ayarla
        //    selectedPanel.Height = selectedPanel.MaximumSize.Height;
        //    selectedPanel.Width = selectedPanel.MaximumSize.Width;

        //    // Seçilen panelin görünürlüğünü tersine çevir
        //    selectedPanel.Visible = true;

        //    // Seçilen paneli en öne getir
        //    selectedPanel.BringToFront();

        //    // Seçilen panel hariç tüm panelleri gizle ve arka plana at
        //    foreach (Panel panel in panelsToHide)
        //    {
        //        if (panel != selectedPanel)
        //        {
        //            panel.Visible = false;  // Panelleri gizler
        //            panel.SendToBack();     // Panelleri arka plana gönderir
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            KullaniciContainer.Visible = false;
        }

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            Anasayfa AnasayfaForn= new Anasayfa();
            FormGoster(AnasayfaForn);
        }

        private void BiletButton_Click(object sender, EventArgs e)
        {
            BiletTimer.Start();
        }

        private void BiletEkleButton_Click(object sender, EventArgs e)
        {
            BiletEkle BiletEkleForm = new BiletEkle();
            FormGoster(BiletEkleForm);
        }

        private void BiletSilButton_Click(object sender, EventArgs e)
        {
            BiletIptalEt BiletSilForm =new BiletIptalEt();
            FormGoster(BiletSilForm);
        }

        private void BiletGuncelleButton_Click(object sender, EventArgs e)
        {
            BiletGuncelle BiletGuncelleForm = new BiletGuncelle();
            FormGoster(BiletGuncelleForm);
        }

        private void BiletGoruntuleButton_Click(object sender, EventArgs e)
        {
            BiletGoruntule BiletGoruntuleForm = new BiletGoruntule();
            FormGoster(BiletGoruntuleForm);
        }

        private void SeferButton_Click(object sender, EventArgs e)
        {
            SeferTimer.Start();
        }

        private void SeferEkleButton_Click(object sender, EventArgs e)
        {
            SeferEkle SeferEkleForn = new SeferEkle();
            FormGoster(SeferEkleForn);
        }

        private void SeferSilButton_Click(object sender, EventArgs e)
        {
            SeferIptalEt SeferSilForn = new SeferIptalEt();
            FormGoster(SeferSilForn);
        }

        private void SeferGuncelleButton_Click(object sender, EventArgs e)
        {
            SeferGuncelle SeferGuncelleForn = new SeferGuncelle();
            FormGoster(SeferGuncelleForn);
        }

        private void SeferGoruntuleButton_Click(object sender, EventArgs e)
        {
            SeferGoruntule SeferGoruntuleForn = new SeferGoruntule();
            FormGoster(SeferGoruntuleForn);
        }

        private void KullaniciButton_Click(object sender, EventArgs e)
        {
            KullaniciTimer.Start();
        }

        private void KullaniciEkleButton_Click(object sender, EventArgs e)
        {
            KullaniciEkle KullaniciEkleForm= new KullaniciEkle();
            FormGoster(KullaniciEkleForm);
        }

        private void KullaniciSilButton_Click(object sender, EventArgs e)
        {
            KullaniciSil KullaniciSilForm = new KullaniciSil();
            FormGoster(KullaniciSilForm);
        }

        private void KullaniciGuncelleButton_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle KullaniciGuncelleForm = new KullaniciGuncelle();
            FormGoster(KullaniciGuncelleForm);
        }

        private void KullaniciGoruntuleButton_Click(object sender, EventArgs e)
        {
            KullaniciGoruntule KullaniciGoruntuleForm = new KullaniciGoruntule();
            FormGoster(KullaniciGoruntuleForm);
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void BiletTimer_Tick(object sender, EventArgs e)
        {
            if (biletcollapsed)
            {
                BiletContainer.Height += 10;
                if (BiletContainer.Height == BiletContainer.MaximumSize.Height)
                {
                    biletcollapsed = false;
                    BiletTimer.Stop();
                }
            }
            else
            {
                BiletContainer.Height -= 10;
                if (BiletContainer.Height == BiletContainer.MinimumSize.Height)
                {
                    biletcollapsed = true;
                    BiletTimer.Stop();
                }
            }
        }

        private void SeferTimer_Tick(object sender, EventArgs e)
        {
            if (sefercollapsed)
            {
                SeferContainer.Height += 10;
                if (SeferContainer.Height == SeferContainer.MaximumSize.Height)
                {
                    sefercollapsed = false;
                    SeferTimer.Stop();
                }
            }
            else
            {
                SeferContainer.Height -= 10;
                if (SeferContainer.Height == SeferContainer.MinimumSize.Height)
                {
                    sefercollapsed = true;
                    SeferTimer.Stop();
                }
            }
        }

        private void RezervasyonTimer_Tick(object sender, EventArgs e)
        {
            if (rezervasyoncollapsed)
            {
                RezervasyonContainer.Height += 10;
                if (RezervasyonContainer.Height == RezervasyonContainer.MaximumSize.Height)
                {
                    rezervasyoncollapsed = false;
                    RezervasyonTimer.Stop();
                }
            }
            else
            {
                RezervasyonContainer.Height -= 10;
                if (RezervasyonContainer.Height == RezervasyonContainer.MinimumSize.Height)
                {
                    rezervasyoncollapsed = true;
                    RezervasyonTimer.Stop();
                }
            }
        }

        private void KullaniciTimer_Tick(object sender, EventArgs e)
        {
            if (kullanicicollapsed)
            {
                KullaniciContainer.Height += 10;
                if (KullaniciContainer.Height == RezervasyonContainer.MaximumSize.Height)
                {
                    kullanicicollapsed = false;
                    KullaniciTimer.Stop();
                }
            }
            else
            {
                KullaniciContainer.Height -= 10;
                if (KullaniciContainer.Height == KullaniciContainer.MinimumSize.Height)
                {
                    kullanicicollapsed = true;
                    KullaniciTimer.Stop();
                }
            }
        }

        //private void EKranBoyutPanelFonk(Panel panel)
        //{
        //    if (this.WindowState == FormWindowState.Normal)
        //    {
        //        // Form normal boyuta döndü; panelin eski boyut ve konumunu ayarlıyoruz
        //        panel.Width = 1110;  // Panelin eski genişliği
        //        panel.Height = 914;  // Panelin eski yüksekliği
        //        panel.Left = 278;    // Panelin eski konumu (soldan)
        //        panel.Top = 0;       // Panelin eski konumu (yukarıdan)
        //    }
        //    else if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        // Form tam ekran; paneli ortalamak
        //        panel.Left = (this.ClientSize.Width - panel.Width) / 2; // Paneli yatayda ortala
        //        panel.Top = (this.ClientSize.Height - panel.Height) / 2; // Paneli dikeyde ortala
        //    }
        //}

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*EKranBoyutPanelFonk(PanelBiletSil);
            EKranBoyutPanelFonk(PanelSeferEkle);
            EKranBoyutPanelFonk(PanelSeferGuncelle);
            EKranBoyutPanelFonk(PanelAnasayfa);
            EKranBoyutPanelFonk(PanelKullaniciEkle);
            EKranBoyutPanelFonk(PanelKullaniciGoruntule);
            EKranBoyutPanelFonk(PanelKullaniciGuncelle);
            EKranBoyutPanelFonk(PanelKullaniciSil);
            EKranBoyutPanelFonk(PanelSeferGoruntule);
            EKranBoyutPanelFonk(PanelSeferSil);*/
        }

        private void CikisYapButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AracButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AracIslemleri AracIslemleriForm = new AracIslemleri();
            FormGoster(AracIslemleriForm);
        }
    }
}
