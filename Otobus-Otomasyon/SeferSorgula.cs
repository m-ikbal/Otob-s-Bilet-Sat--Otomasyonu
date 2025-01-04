using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Otobus_Otomasyon
{
    public partial class SeferSorgula : Form
    {
        private string[] cities =
    {
        "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
        "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
        "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
        "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş",
        "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa",
        "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa",
        "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat",
        "Zonguldak"
    };
        private string lastFilteredCity = string.Empty;
        public SeferSorgula()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            guna2TextBox1.AutoCompleteCustomSource.AddRange(cities); // Şehir listemizi ekliyoruz
            guna2TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Tekrar yazıldıkça tamamlama
            guna2TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; // Kendi kaynağımızı kullanıyoruz


            guna2TextBox2.AutoCompleteCustomSource.AddRange(cities); // Şehir listemizi ekliyoruz
            guna2TextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Tekrar yazıldıkça tamamlama
            guna2TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource; // Kendi kaynağımızı kullanıyoruz
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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
