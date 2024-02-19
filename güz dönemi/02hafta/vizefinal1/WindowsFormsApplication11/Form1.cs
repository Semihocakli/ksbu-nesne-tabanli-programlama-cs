using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ort1;
        int v1, f1; double ort;
        string harfnot="";
        //eksiklikler var.tamamlanacak.
        private void button1_Click(object sender, EventArgs e)//hesapla1
        {
            if (textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("boş");
                return;
            }
            v1 = Convert.ToInt32(textBox1.Text);
            f1 = Convert.ToInt32(textBox2.Text);
            if ((v1<0 || v1>100) || (f1 < 0 || f1 > 100))
            {
                MessageBox.Show("yanlış");
                return;
            }
            ort = (v1*0.4) + (f1*0.6);
            label1.Text = ort.ToString();
            if (ort<60)
            {
                //buraya
                MessageBox.Show("but gir");
                textBox3.Enabled = true;//büt text
                button2.Enabled = true;//hesapla2
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button2.BackColor = Color.Aqua;
                textBox3.Focus();
                //textBox3.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)//hesapla2
        {
            if (textBox3.Text == "")//but
            {
                MessageBox.Show("boş");
                return;
            }
            int b1;
            b1 = Convert.ToInt32(textBox3.Text);
           
            if (b1 < 0 || b1 > 100)
            {
                MessageBox.Show("yanlış");
                return;
            }
            
            ort = (v1 * 0.4) + (b1 * 0.6);
            label1.Text = ort.ToString();
        }
        private void harf()
        {
           
        }
        private void harf2()
        {
            //inceleyin??
            //**********************************
            if (ort < 60) { harfnot = "FF"; }
            else if (ort >= 60 && ort <= 65) { harfnot = "CC"; }
            else if (ort >= 66 && ort <= 75) { harfnot = "CB"; }
            else if (ort >= 76 && ort <= 85) { harfnot = "BB"; }
            //**********************************
            if (ort < 60) { harfnot = "FF"; }
            else if (ort <= 65) { harfnot = "CC"; }
            else if (ort <= 75) { harfnot = "CB"; }
            else if (ort <= 85) { harfnot = "BB"; }
            //**********************************
            if (ort < 60) { harfnot = "FF"; }
            if (ort <= 65) { harfnot = "CC"; }
            if (ort <= 75) { harfnot = "CB"; }
            if (ort <= 85) { harfnot = "BB"; }
            //**********************************
            if (ort >= 0 && ort < 60) { harfnot = "FF"; }
            else if (ort >= 60 && ort <= 65) { harfnot = "CC"; }
            else if (ort >= 66 && ort <= 75) { harfnot = "CB"; }
            else if (ort >= 76 && ort <= 85) { harfnot = "BB"; }
            //**********************************
            if (ort >= 76 && ort <= 85) { harfnot = "BB"; }
            else if (ort >= 66 && ort <= 75) { harfnot = "CB"; }
            else if (ort >= 60 && ort <= 65) { harfnot = "CC"; }
            else if (ort >= 0 && ort < 60) { harfnot = "FF"; }          
            //**********************************
        }
        private void button3_Click(object sender, EventArgs e)//temizle
        {
            textBox1.Enabled = true;//vize
            textBox2.Enabled = true;//final
            textBox3.Enabled = false;//büt
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = ""; label3.Text = "";
            label2.Text = ""; label4.Text = "";
            button1.Enabled = true;//hesapla1
            button2.Enabled = false;//hesapla2
            button1.BackColor = Color.SpringGreen;
            button2.BackColor = default(Color);
            textBox1.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;//büt text
            button2.Enabled = false;//hesapla2          
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }
        private void button4_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
