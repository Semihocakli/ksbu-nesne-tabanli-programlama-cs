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
        public Form1()
        {
            InitializeComponent();
        }

        int s1=0, s2=0, sonuc=0;
        int islem = 0;
        string islem1 = "";
        string yaz = "";
        private void button1_Click(object sender, EventArgs e)//1
        {
            textBox1.Text = textBox1.Text + "1";
            //textBox1.Text =  "1";
            //textBox1.Text = "1" + textBox1.Text ;
        }
        private void button2_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)//3
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
            
        }
        private void button11_Click(object sender, EventArgs e)//+
        {
            //git:
            if (textBox1.Text=="")
            {
                MessageBox.Show("ilk deger yok");
                // goto git;
                return;
            }
            s1 = Convert.ToInt32(textBox1.Text);

            islem = 1;
            islem1 = "toplama";
            islem1 = "+";
            label1.Text = s1 + "+";
            
            textBox1.Clear();
            textBox1.Focus();
            //git:
        }
        private void button15_Click_1(object sender, EventArgs e)// = sonuc
        {
            
			if (islem==0)
            {
                MessageBox.Show("islem yok");
				return;
            }
			if (textBox1.Text == "")
            {
                MessageBox.Show("ikinci deger yok");
				return;
            }
            s2 = Convert.ToInt32(textBox1.Text);
            if (islem1 == "+")//if (islem1 == "+")
            {
                sonuc = s1 + s2;
            }
            label1.Text = label1.Text + s2 + "=" + sonuc;
            label2.Text = sonuc.ToString();
			islem=0;
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button12_Click(object sender, EventArgs e)//-
        {
           
        }

        private void button13_Click(object sender, EventArgs e)//*
        {
           
        }

        private void button14_Click(object sender, EventArgs e)// /
        {
            
        }
       
        private void button15_Click(object sender, EventArgs e)
        {

        }
        private void button17_Click_1(object sender, EventArgs e)// clear
        {
            label1.Text = ""; label2.Text = "";
            textBox1.Clear();
            textBox1.Focus();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
        private void button16_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }

    }
}
