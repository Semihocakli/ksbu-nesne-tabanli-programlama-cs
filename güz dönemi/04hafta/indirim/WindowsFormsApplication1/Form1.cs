using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a,b;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="" || textBox3.Text == "")
            { MessageBox.Show("boş bırakılamaz");
                textBox2.Focus();
                return;
            }
            a = Convert.ToDouble(textBox2.Text);
            b = Convert.ToDouble(textBox3.Text);

            a = a + a *(b/100);
            if (radioButton1.Checked){textBox4.Text = (a - a * 0.05).ToString();}
            if (radioButton2.Checked){textBox4.Text = (a - a * 0.10).ToString();}
            if (radioButton3.Checked){textBox4.Text = a .ToString();}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
