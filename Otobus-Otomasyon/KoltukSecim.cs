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
    public partial class KoltukSecim : Form
    {
        public static string Cinsiyet { get; set; }
        public KoltukSecim()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public KoltukSecim(BiletEkle biletEkle)
        {
            InitializeComponent();
        }

        private void btnErkek_Click(object sender, EventArgs e)
        {
            Cinsiyet = "Erkek";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKadin_Click(object sender, EventArgs e)
        {
            Cinsiyet = "Kadın";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {

        }
    }
}
