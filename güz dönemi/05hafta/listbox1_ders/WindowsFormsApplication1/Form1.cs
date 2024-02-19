using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cB1.DropDownStyle = ComboBoxStyle.DropDownList;

            cB1.Text = "İşlem Seçin";
            cB1.Items.Add("TOPLAMA(+)");
            cB1.Items.Add("CIKARMA(-)");
            cB1.Items.Add("(BOLME+)");
            cB1.Items.Add("CARPMA(+)");

            lB1.Items.Add("TOPLAMA(+)");
            lB1.Items.Add("CIKARMA(-)");
            lB1.Items.Add("(BOLME+)");
            lB1.Items.Add("CARPMA(+)");

            textBox1.Focus();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla2();//cB1.SelectedIndex e göre
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesapla4();
            label2.Text = lB1.SelectedIndex.ToString();
            label3.Text = lB1.Text;
        }
        private void button4_Click(object sender, EventArgs e)//hesapla
        {
            hesapla4();//listbox1+buton
        }
        private void hesapla4()//kısakod
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("lütfen sayilari giriniz");
                textBox1.Focus(); return;
            }
            if (lB1.SelectedIndex == -1)
            {
                MessageBox.Show("lütfen işlem seçiniz");
                textBox1.Focus(); return;
            }
            int t1, t2, cb1, lb1;
            int i = lB1.SelectedIndex;
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);
            if (i == 0)
            {
                label1.Text = (t1 + t2).ToString();
            }
            if (i == 1)
            {
                label1.Text = (t1 - t2).ToString();
            }
            if (i == 2)
            {
                label1.Text = (t1 / t2).ToString();
            }
            if (i == 3)
            {
                label1.Text = (t1 * t2).ToString();
            }
        }
        private void hesapla3()//kısa kod
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("lütfen sayilari giriniz");
                textBox1.Focus(); return;
            }
            int t1, t2,cb1,lb1;
            int i= cB1.SelectedIndex;//lb1 = lB1.SelectedIndex;
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);
            if (i == 0)
            {
                label1.Text = (t1 + t2).ToString();
            }
            if (i == 1)
            {
                label1.Text = (t1 - t2).ToString();
            }
            if (i == 2)
            {
                label1.Text = (t1 / t2).ToString();
            }
            if (i == 3)
            {
                label1.Text = (t1 * t2).ToString();
            }
        }
        private void hesapla2()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("lütfen sayilari giriniz");
                textBox1.Focus(); return;
            }
            int t1, t2;
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);
            if (cB1.SelectedIndex == 0)
            {
                label1.Text = (t1+t2).ToString();
            }
            if (cB1.SelectedIndex == 1)
            {
                label1.Text = (t1 - t2).ToString();
            }
            if (cB1.SelectedIndex == 2)
            {
                label1.Text = (t1 / t2).ToString();
            }
            if (cB1.SelectedIndex == 3)
            {
                label1.Text = (t1 * t2).ToString();
            }
        }
        private void hesapla1()//uzun/yapmayınız
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("lütfen sayilari giriniz");
            }
            else if (cB1.SelectedIndex == 0)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (cB1.SelectedIndex == 1)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (cB1.SelectedIndex == 2)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (cB1.SelectedIndex == 3)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            textBox1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
    }
