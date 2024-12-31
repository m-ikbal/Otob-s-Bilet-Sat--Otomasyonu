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
        public Koltuk1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Koltuk1_Load(object sender, EventArgs e)
        {
            // Formdaki tüm kontrolleri kontrol et
            AttachButtonClickEvent(this);
        }
        private void GunaButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button clickedButton)
            {
                // Tıklanan butonun bilgilerini al
                MessageBox.Show($"Tıklanan Buton: {clickedButton.Name}, Metin: {clickedButton.Text}");

                // İstediğiniz işlemleri burada yapabilirsiniz
                KoltukSecim koltukSecim = new KoltukSecim();
                koltukSecim.Show();
            }
        }
        private void AttachButtonClickEvent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2Button gunaButton)
                {
                    // Click olayını bağla
                    gunaButton.Click += GunaButton_Click;
                }
                else if (control.HasChildren)
                {
                    // Alt kontrolleri kontrol et
                    AttachButtonClickEvent(control);
                }
            }
        }
    }
}
