using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Otobus_Otomasyon
{
    public class bosalankontrol
    {
        // Formdaki tüm TextBox, ComboBox, Guna2TextBox ve Guna2ComboBox'ları kontrol eder
        public static bool AreFieldsValid(Form form)
        {
            // Formdaki tüm kontrolleri gez
            foreach (Control control in form.Controls)
            {
                // Guna2TextBox kontrollerini kontrol et
                if (control is Guna2TextBox guna2TextBox)
                {
                    if (string.IsNullOrWhiteSpace(guna2TextBox.Text))
                    {
                        MessageBox.Show("Lütfen gerekli tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Eğer bir alan boşsa false döner
                    }
                }

                // Guna2ComboBox kontrollerini kontrol et
                if (control is Guna2ComboBox guna2ComboBox)
                {
                    if (guna2ComboBox.SelectedIndex == -1) // Seçim yapılmamışsa
                    {
                        MessageBox.Show("Lütfen gerekli tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Eğer bir alan boşsa false döner
                    }
                }

                // TextBox kontrollerini kontrol et
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Lütfen gerekli tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Eğer bir alan boşsa false döner
                    }
                }

                // ComboBox kontrollerini kontrol et
                if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1) // Seçim yapılmamışsa
                    {
                        MessageBox.Show("Lütfen gerekli tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false; // Eğer bir alan boşsa false döner
                    }
                }
            }

            // Eğer tüm alanlar doldurulmuşsa
            return true;
        }
    }
}
