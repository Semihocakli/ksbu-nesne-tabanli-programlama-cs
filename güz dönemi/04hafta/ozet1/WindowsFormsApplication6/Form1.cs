using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int a=0, b=0, c=0,h=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "topla";
            radioButton2.Text = "Çıkar";
            //devamini sen yaz

            checkBox1.Text = "topla";
            checkBox2.Text = "Çıkar";
            //devamini sen yaz

            comboBox1.Items.Add("topla");
            comboBox1.Items.Add("Çıkar");
            // devamini sen yaz

            checkedListBox1.Items.Add("topla");
            checkedListBox1.Items.Add("Çıkar");
            //devamini sen yaz

            listBox1.Items.Add("topla");
            listBox1.Items.Add("Çıkar");
            //devamini sen yaz

            listBox1.SelectedIndex = -1;

            textBox1.Focus();
        }
        private void hata()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            { MessageBox.Show("hata1"); h = 1;}
            
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            { MessageBox.Show("hata2"); h = 1; }
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)//rb1 hesapla1
        {
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked == true)
            { c = a + b; }
            if (radioButton2.Checked)
            { c = a - b; }
            label6.Text = c.ToString();
            cik:;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//topla
        {
            /* button1_Click aynı anda çalıştırmayınız
            hata(); if (h == 1) { goto cik; }
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = a + b;
                if (radioButton1.Checked == true)
                { label1.Text = c.ToString(); }
            cik:;
            */
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)//çıkarma
        {
            /*
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            if (radioButton2.Checked)// dikkat
            { label1.Text = c.ToString(); }
            cik:;
            */
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)//çarpma
        {
            //siz yapın
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)//bölme
        {
            //siz yapın
        }
        private void button2_Click(object sender, EventArgs e)//cb1 hesapla2
        {
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            if (checkBox1.Checked == true)
            { label2.Text = c.ToString(); }
            cik:;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //............  siz yapın (label7.Text kullan)
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //siz yapın
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //siz yapın
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // siz yapın
        }
        private void button3_Click(object sender, EventArgs e)//cb hesapla3
        {
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            { c = a + b; label3.Text = c.ToString(); }
            if (comboBox1.SelectedIndex == 2)
            { c = a - b; label3.Text = c.ToString(); }
            //............devamini  siz yapın

            cik:;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //............  siz yapın (label8.Text kullan)
        }
        private void button4_Click(object sender, EventArgs e)//clb hesapla4
        {
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (checkedListBox1.SelectedIndex == 0)
            { c = a + b; label4.Text = c.ToString(); }
            if (checkedListBox1.SelectedIndex == 2)
            { c = a - b; label4.Text = c.ToString(); }
            //............ devamini siz yapın
            cik:;
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //............  siz yapın (label9.Text kullan)
        }
        private void button5_Click(object sender, EventArgs e)//lb hesapla5
        {
            h = 0; hata(); if (h == 1) { goto cik; }
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (listBox1.SelectedIndex == 0)
            { c = a + b; label5.Text = c.ToString(); }
            if (listBox1.SelectedIndex == 1)
            { c = a - b; label5.Text = c.ToString(); }
            //............ devamini siz yapın

            cik:;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //............  siz yapın (label10.Text kullan)  
        }
        private void button6_Click(object sender, EventArgs e)//temizle
        {
            temizle();
        }
        private void button7_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
        private void temizle()
        {
            label1.Text = "...";
            label2.Text = "...";//3,4,5,6,7,8,9,10>>devamini yaz
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            //............ devamini siz yapın

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            //............ devamini sen yaz

            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            //............ devamini sen yaz

            checkedListBox1.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            listBox1.SelectedIndex = -1;
        }
        
    }
}
