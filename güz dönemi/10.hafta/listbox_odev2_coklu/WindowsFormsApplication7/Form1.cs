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
                MessageBox.Show("TB1 giriniz/ LB1 Seçim Yapınız");
                this.textBox1.Focus();
            }
            else
            {
                this.listBox1.Items[this.listBox1.SelectedIndex] = this.textBox1.Text;
                this.textBox1.Text = "";
                this.adet1();
            }
        }
        private void button3_Click(object sender, EventArgs e)//seçili yer değiştir
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2 || this.listBox1.SelectedIndices.Count > 2;
            if (flag)
            {
                MessageBox.Show("LB1 den 2 tane seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int index = this.listBox1.SelectedIndices[0];
                int index2 = this.listBox1.SelectedIndices[1];
                string value = this.listBox1.Items[index].ToString();
                string value2 = this.listBox1.Items[index2].ToString();
                this.listBox1.Items[index] = value2;
                this.listBox1.Items[index2] = value;
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
        //******************
        private void button11_Click(object sender, EventArgs e)//kopyala_üstte
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(i, this.listBox1.SelectedItems[i]);
                }
                this.adet1();
            }
        }
        private void button12_Click(object sender, EventArgs e)//kopyala_altta
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(this.listBox2.Items.Count, this.listBox1.SelectedItems[i]);
                }
                this.adet1();
            }
        }
        private void button13_Click(object sender, EventArgs e)//kopyala_secili1
        {
            int count = this.listBox1.SelectedItems.Count;
            int selectedIndex = this.listBox1.SelectedIndex;
            int selectedIndex2 = this.listBox2.SelectedIndex;
            bool flag = count < 2 || selectedIndex2 == -1;
            if (flag)
            {
                MessageBox.Show("LB1 en az 2 seçiniz/ LB2 Seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(selectedIndex2, this.listBox1.SelectedItems[i]);
                }
                this.adet1();
            }
        }
        private void button19_Click(object sender, EventArgs e)//kopyala_secili2
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    bool selected = this.listBox1.GetSelected(i);
                    if (selected)
                    {
                        this.listBox2.Items.Insert(this.listBox2.SelectedIndex, this.listBox1.Items[i]);
                    }
                }
                this.adet1();
                this.textBox1.Focus();
            }
        }
        private void button14_Click(object sender, EventArgs e)//taşı_üstte1
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(i, this.listBox1.SelectedItems[0]);
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[0]);
                }
                this.adet1();
            }
        }
        private void button15_Click(object sender, EventArgs e)//taşı_üstte2
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(i, this.listBox1.SelectedItems[i]);
                }
                for (int j = 0; j < count; j++)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[0]);
                }
                this.adet1();
            }
        }
        private void button16_Click(object sender, EventArgs e)//taşı_üstte3
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(i, this.listBox1.SelectedItems[i]);
                }
                for (int j = count - 1; j >= 0; j--)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[j]);
                }
                this.adet1();
            }
        }
        private void button17_Click(object sender, EventArgs e)//taşı_alta1
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(this.listBox2.Items.Count, this.listBox1.SelectedItems[i]);
                }
                for (int j = 0; j < count; j++)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[j]);
                }
                this.adet1();
            }
        }
        private void button18_Click(object sender, EventArgs e)//taşı_secili
        {
            bool flag = this.listBox1.SelectedIndices.Count < 2;
            if (flag)
            {
                MessageBox.Show("LB1 En az 2 seçiniz");
                this.textBox1.Focus();
            }
            else
            {
                int count = this.listBox1.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    this.listBox2.Items.Insert(this.listBox2.SelectedIndex, this.listBox1.SelectedItems[i]);
                }
                for (int j = 0; j < count; j++)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[j]);
                }
                this.adet1();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.AddRange(new object[]
            {
                "KUTAHYA1",
                "KUTAHYA2",
                "KUTAHYA3",
                "KUTAHYA4",
                "KUTAHYA5"
            });
            this.listBox2.Items.AddRange(new object[]
            {
                "BURSA1",
                "BURSA2",
                "BURSA3",
                "BURSA4",
                "BURSA5"
            });
            this.adet1();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.adet1();
        }
        private void adet1()
        {
            this.label1.Text = this.listBox1.Items.Count.ToString();
            this.label3.Text = this.listBox2.Items.Count.ToString();
            this.label5.Text = this.listBox1.SelectedItems.Count.ToString();
            this.textBox1.Focus();
        }
        private void button40_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)//temizle
        {
            listBox1.Items.Clear();
            adet1();
        }

        
    }
}
