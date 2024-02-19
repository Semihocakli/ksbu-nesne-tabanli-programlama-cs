using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//ekle1
        {
            bool flag = this.textBox1.Text == "";
            if (flag)
            {
                MessageBox.Show("TB1 giriniz");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Add(this.textBox1.Text);
                this.textBox1.Text = "";
                this.adet1();
            }
        }
        private void button2_Click(object sender, EventArgs e)//degistir
        {
            bool flag = this.textBox1.Text == "" || this.listBox1.SelectedIndex == -1;
            if (flag)
            {
                MessageBox.Show("TB1 giriniz/LB1 Seçim Yapınız");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items[this.listBox1.SelectedIndex] = this.textBox1.Text;
                this.textBox1.Text = "";
                this.adet1();
            }
        }
        private void button3_Click(object sender, EventArgs e)//Araya Ekle (Seçili Üstü)
        {
            bool flag = this.textBox1.Text == "" || this.listBox1.SelectedIndex == -1;
            if (flag)
            {
                MessageBox.Show("TB1 giriniz/ LB1 Seçim Yapınız");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex, this.textBox1.Text);
                this.adet1();
            }
        }
        private void button4_Click(object sender, EventArgs e)//Araya Ekle (Seçili Alta)
        {
            bool flag = this.textBox1.Text == "" || this.listBox1.SelectedIndex == -1;
            if (flag)
            {
                MessageBox.Show("TB1 giriniz/LB1 Seçim Yapınız");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex + 1, this.textBox1.Text);
                this.adet1();
            }
        }
        private void button5_Click(object sender, EventArgs e)//Araya Ekle (En Üste)
        {
            bool flag = this.textBox1.Text == "";
            if (flag)
            {
                MessageBox.Show("TB1 giriniz");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(0, this.textBox1.Text);
                this.adet1();
            }
        }
        private void button6_Click(object sender, EventArgs e)//Araya Ekle (En Alta)
        {
            bool flag = this.textBox1.Text == "";
            if (flag)
            {
                MessageBox.Show("TB1 giriniz");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(this.listBox1.Items.Count, this.textBox1.Text);
                this.adet1();
            }
        }
        private void button7_Click(object sender, EventArgs e)//sil
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                this.adet1();
            }
        }
        private void button11_Click(object sender, EventArgs e)//kopyala_üstte
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(0, this.listBox1.SelectedItem);
                this.adet1();
            }
        }
        private void button12_Click(object sender, EventArgs e)//kopyala_altta
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(this.listBox2.Items.Count, this.listBox1.SelectedItem);
                this.adet1();
            }
        }
        private void button13_Click(object sender, EventArgs e)//kopyal_secili
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0 || this.listBox2.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1/LB2 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(this.listBox2.SelectedIndex, this.listBox1.SelectedItem);
                this.adet1();
            }
        }
        private void button14_Click(object sender, EventArgs e)//taşı_üstte
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(0, this.listBox1.SelectedItem);
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                this.adet1();
            }
        }
        private void button15_Click(object sender, EventArgs e)//taşı_altta
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(this.listBox2.Items.Count, this.listBox1.SelectedItem);
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                this.adet1();
            }
        }
        private void button16_Click(object sender, EventArgs e)//taşı_secili
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0 || this.listBox2.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1/LB2 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox2.Items.Insert(this.listBox2.SelectedIndex, this.listBox1.SelectedItem);
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
                this.adet1();
            }
        }
        private void button9_Click(object sender, EventArgs e)//<< Kopyala (Seçili) 
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0 || this.listBox2.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1/LB2 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex, this.listBox2.SelectedItem);
                this.adet1();
            }
        }
        private void button10_Click(object sender, EventArgs e)//<< Taşı (Seçili) 
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0 || this.listBox2.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1/LB2 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items.Insert(this.listBox1.SelectedIndex, this.listBox2.SelectedItem);
                this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
                this.adet1();
            }
        }
        private void button17_Click(object sender, EventArgs e)//yer değiştir
        {
            bool flag = this.listBox1.SelectedIndices.Count == 0 || this.listBox2.SelectedIndices.Count == 0;
            if (flag)
            {
                MessageBox.Show("LB1/LB2 Seçim yapınız...");
                this.textBox1.Focus();
            }
            else
            {
                int selectedIndex = this.listBox1.SelectedIndex;
                int selectedIndex2 = this.listBox2.SelectedIndex;
                object value = this.listBox1.Items[selectedIndex];
                object value2 = this.listBox2.Items[selectedIndex2];
                this.listBox1.Items[selectedIndex] = value2;
                this.listBox2.Items[selectedIndex2] = value;
                this.adet1();
            }
        }
        //****************
        private void Form1_Load(object sender, EventArgs e)
        {
            object[] items = new object[]
             {
                "KUTAHYA1",
                "KUTAHYA2",
                "KUTAHYA3",
                "KUTAHYA4",
                "KUTAHYA5"
             };
            object[] items2 = new object[]
            {
                "BURSA1",
                "BURSA2",
                "BURSA3"
            };
            this.listBox1.Items.AddRange(items);
            this.listBox2.Items.AddRange(items2);
            this.adet1();
        }
        private void button8_Click(object sender, EventArgs e)//temizle
        {
            listBox1.Items.Clear();
            adet1();
        }
        private void adet1()
        {
            this.label1.Text = this.listBox1.Items.Count.ToString();
            this.label3.Text = this.listBox2.Items.Count.ToString();
            this.textBox1.Focus();
        }
        private void button40_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
