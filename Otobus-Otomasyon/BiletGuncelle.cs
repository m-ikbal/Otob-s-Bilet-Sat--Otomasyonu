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
    public partial class BiletGuncelle : Form
    {
        public BiletGuncelle()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
