using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            
        }
        private void adet()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)//ekle (her şekilde)
        {



            textBox1.Text = "";textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)//ekle (LB1 de yoksa)
        {
            



            textBox2.Focus();
        }
        private void button3_Click(object sender, EventArgs e)//degistir (Tekli/Çoklu)
        {
            


            textBox3.Focus();
        }
        private void button4_Click(object sender, EventArgs e)//bul (Tekli/Çoklu)
        {
            

            textBox4.Focus();
        }
        private void button5_Click(object sender, EventArgs e)//sil (Tekli/Çoklu)
        {
           


            textBox3.Focus();
        }
        private void button6_Click(object sender, EventArgs e)//en üste taşı (Tekli/Çoklu)
        {
            
			 
			 textBox1.Focus();
        }
        private void button7_Click(object sender, EventArgs e)//en alta taşı (Tekli/Çoklu)
        {
           
		
		textBox1.Focus();
        }
        private void button8_Click(object sender, EventArgs e)//en üst ile yer değiştir
        {


            textBox1.Focus();
        }
        private void button9_Click(object sender, EventArgs e)//en alt ile yer değiştir
        {


            textBox1.Focus();
        }
        private void button10_Click(object sender, EventArgs e)//temizle
        {



            textBox1.Focus();
        }
    }
}
