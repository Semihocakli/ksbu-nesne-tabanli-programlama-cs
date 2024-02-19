using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //sadece bu değişken kullanılacak.
        //isimlerini değiştirmeyin.ekleme yapmayın.
        double top; 
        private void button1_Click(object sender, EventArgs e)
        {
            this.LB9.Items.Clear();
	bool flag = this.hata() == 0;
	if (flag)
	{
		this.TB1.Focus();
	}
	else
	{
		this.hata();
		this.hesapla();
		this.yaz();
		this.TB1.Focus();
	}
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.LB1.Items.Add("Küçük Boy Pizza(50 TL)");
            this.LB1.Items.Add("Orta Boy Pizza(100 TL)");
            this.LB1.Items.Add("Büyük Boy Pizza(150 TL)");
            this.LB2.Items.Add("1");
            this.LB2.Items.Add("2");
            this.LB2.Items.Add("3");
            this.LB3.Items.Add("1");
            this.LB3.Items.Add("2");
            this.LB3.Items.Add("3");
            this.LB4.Items.Add("1");
            this.LB4.Items.Add("2");
            this.LB4.Items.Add("3");
            this.LB5.Items.Add("Su(10 TL)");
            this.LB5.Items.Add("Ayran(20 TL)");
            this.LB5.Items.Add("Kola(30 TL)");
            this.LB6.Items.Add("1");
            this.LB6.Items.Add("2");
            this.LB6.Items.Add("3");
            this.LB7.Items.Add("1");
            this.LB7.Items.Add("2");
            this.LB7.Items.Add("3");
            this.LB8.Items.Add("1");
            this.LB8.Items.Add("2");
            this.LB8.Items.Add("3");
            this.button1.Text = "Hesapla";
            this.button2.Text = "Temizle";
            this.button3.Text = "Kapat";
        }
        private void yaz()//en fazla 6 if
        {
            ListBox sourceListBox = this.LB1; 

            int itemCount = sourceListBox.SelectedIndices.Count;

            for (int i = 0; i < itemCount; i++)
            {
                int selectedIndex = sourceListBox.SelectedIndices[i];
                string itemText = sourceListBox.SelectedItems[i].ToString();

                if (i == 0)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB2.Text, " adet"));
                }
                else if (i == 1)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB3.Text, " adet"));
                }
                else if (i == 2)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB4.Text, " adet"));
                }               
                else if (i == 3)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB6.Text, " adet"));
                }
                else if (i == 4)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB7.Text, " adet"));
                }
                else if (i == 5)
                {
                    this.LB9.Items.Add(string.Concat(itemText, " - ", this.LB8.Text, " adet"));
                }
            }

            this.LB9.Items.Add("Toplam: " + this.top + " TL");
        }
        private void hesapla()//en fazla 6 if
        {
            this.top = 0.0;

            for (int i = 0; i < 3; i++)
            {
                if (i < this.LB1.SelectedIndices.Count)
                {
                    this.top += 50 * (i + 1) * Convert.ToInt32(this.LB1.SelectedIndices[i] + 1) * Convert.ToInt32(this.LB2.Text);
                }

                if (i < this.LB5.SelectedIndices.Count)
                {
                    this.top += 10 * (i + 1) * Convert.ToInt32(this.LB5.SelectedIndices[i] + 1) * Convert.ToInt32(this.LB6.Text);
                }
            }

            if (this.LB1.SelectedIndices.Count == 2)
            {
                this.top += 50 * (Convert.ToInt32(this.LB1.SelectedIndices[1] + 1) * Convert.ToInt32(this.LB3.Text));
            }

            if (this.LB1.SelectedIndices.Count == 3)
            {
                this.top += 50 * (Convert.ToInt32(this.LB1.SelectedIndices[2] + 1) * Convert.ToInt32(this.LB4.Text));
            }

            if (this.LB5.SelectedIndices.Count == 2)
            {
                this.top += 10 * (Convert.ToInt32(this.LB5.SelectedIndices[1] + 1) * Convert.ToInt32(this.LB7.Text));
            }

            if (this.LB5.SelectedIndices.Count == 3)
            {
                this.top += 10 * (Convert.ToInt32(this.LB5.SelectedIndices[2] + 1) * Convert.ToInt32(this.LB8.Text));
            }
        }
        private int hata() // en fazla 11 if
        {
            int hataIndex = -1;
            string[] messages = {
        "1. Ürün Seçin",
        "1. Ürün Adet seçin..",
        "2. Ürün seçin..",
        "2. Ürün Adet seçin..",
        "3. Ürün seçin..",
        "3. Ürün Adet seçin..",
        "1. İçecek Adet seçin..",
        "2. İçecek seçin..",
        "2. İçecek Adet seçin..",
        "3. İçecek seçin..",
        "3. İçecek Adet seçin.."
    };

            if (this.LB1.SelectedIndices.Count > 0 && this.LB1.SelectedIndex == -1)
                hataIndex = 0;
            else if (this.LB1.SelectedIndices.Count == 1 && this.LB2.SelectedIndex == -1)
                hataIndex = 1;
            else if (this.LB1.SelectedIndices.Count == 1 && this.LB3.SelectedIndex > 0)
                hataIndex = 2;
            else if (this.LB1.SelectedIndices.Count > 1 && this.LB3.SelectedIndex == -1)
                hataIndex = 3;
            else if (this.LB1.SelectedIndices.Count == 2 && this.LB4.SelectedIndex > 0)
                hataIndex = 4;
            else if (this.LB1.SelectedIndices.Count > 2 && this.LB4.SelectedIndex == -1)
                hataIndex = 5;
            else if (this.LB5.SelectedIndices.Count > 0 && this.LB6.SelectedIndex == -1)
                hataIndex = 6;
            else if (this.LB5.SelectedIndices.Count == 1 && this.LB7.SelectedIndex > 0)
                hataIndex = 7;
            else if (this.LB5.SelectedIndices.Count > 1 && this.LB7.SelectedIndex == -1)
                hataIndex = 8;
            else if (this.LB5.SelectedIndices.Count == 2 && this.LB8.SelectedIndex > 0)
                hataIndex = 9;
            else if (this.LB5.SelectedIndices.Count > 2 && this.LB8.SelectedIndex == -1)
                hataIndex = 10;

            if (hataIndex != -1)
            {
                MessageBox.Show($"H{hataIndex + 1}: {messages[hataIndex]}");
                return 0;
            }

            return 1;
        }

        private void LB1_Click(object sender, EventArgs e)
        {
            //Not:Çoklu seçimlerde seçili ürün tekrar tıklanırsa seçim kalkar.
            //LB1 de seçili ürünün seçimi kaldırılırsa, adet seçimi varsa kaldıracak.
            bool flag = this.LB1.SelectedIndices.Count == 0;
            if (flag)
            {
                this.LB2.SelectedIndex = -1;
                this.LB3.SelectedIndex = -1;
                this.LB4.SelectedIndex = -1;
            }
            bool flag2 = this.LB1.SelectedIndices.Count == 1;
            if (flag2)
            {
                this.LB3.SelectedIndex = -1;
                this.LB4.SelectedIndex = -1;
            }
            bool flag3 = this.LB1.SelectedIndices.Count == 2;
            if (flag3)
            {
                this.LB4.SelectedIndex = -1;
            }

        }
        private void LB5_Click(object sender, EventArgs e)
        {
            //LB5 de seçili ürünün seçimi kaldırılırsa, adet seçimi varsa kaldıracak
            bool flag = this.LB5.SelectedIndices.Count == 0;
            if (flag)
            {
                this.LB6.SelectedIndex = -1;
                this.LB7.SelectedIndex = -1;
                this.LB8.SelectedIndex = -1;
            }
            bool flag2 = this.LB5.SelectedIndices.Count == 1;
            if (flag2)
            {
                this.LB7.SelectedIndex = -1;
                this.LB8.SelectedIndex = -1;
            }
            bool flag3 = this.LB5.SelectedIndices.Count == 2;
            if (flag3)
            {
                this.LB8.SelectedIndex = -1;
            }
        }
        private void temizle()
        {
            this.TB1.Text = "";
            this.LB1.SelectedIndex = -1;
            this.LB2.SelectedIndex = -1;
            this.LB3.SelectedIndex = -1;
            this.LB4.SelectedIndex = -1;
            this.LB5.SelectedIndex = -1;
            this.LB6.SelectedIndex = -1;
            this.LB7.SelectedIndex = -1;
            this.LB8.SelectedIndex = -1;
            this.LB9.SelectedIndex = -1;
            this.label1.Text = "";
            this.label2.Text = "";
            this.label3.Text = "";
            this.TB1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
		private void button2_Click(object sender, EventArgs e)//temizle
        {
            this.temizle();
        }
    }
}
