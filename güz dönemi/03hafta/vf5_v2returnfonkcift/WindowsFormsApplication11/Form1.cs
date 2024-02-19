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
        int ort,t1,t2,t3,t4,t5,t6,t7,top=0;
        string harf = "";
        int islem=1;       
        private void button2_Click(object sender, EventArgs e)//hesapla2
        {
         if (islem == 3) { }//islem=3,hata3(),hesapla()
        }
        private void button1_Click(object sender, EventArgs e)//hesapla1
        {
         if (islem == 1) { }//hata1(),islem=2
         if (islem == 2) { }//hata2(),hesapla
        }
        private int hata1()        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hata1: Yüzdelikler boş bırakılamaz! ");
                textBox1.Focus();
                return 0;
            }
            //.........
            return 1;
        }
        private int hata2()
        {
           //..... 
        }
        private int hata3()
        {
        //......
        }       
        private void hesapla()
        {
            ort = 1;
            harfbul();
            label1.Text = ort.ToString();//ort
            label4.Text = harf;          //harf

            if (ort < 50 && islem == 3)            {
                //d1
                //d2
                //BackColor
                //Enabled = false,false,false
                // textBox7,hesapla1,hesapla2
            }
            else if (ort < 50 && islem == 2)            {
                //d1
                //d2
                //BackColor
                label3.BackColor = Color.Red;
                //Enabled = true,false,true
                //textBox7,hesapla1,hesapla2
                //islem;
                //Focus();
            }
            else //>50 >>else if (ort > 50 )
            {
                //Color.Blue;
                //d1
                //d2
                //hesapla1
            }
        }
        private void harfbul()
        {
            //......
        }
        private void button3_Click(object sender, EventArgs e)//temizle
        {
            textBox1.Enabled = true;
            //...
            textBox1.Text = "";
            //...
            label1.Text = ""; 
            //......
            //button1.Enabled;//hesapla1
            //button2.Enabled;//hesapla2           
            //.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)//load
        {
            //textBox7//but
            //button2,false;//hesapla2
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
        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.White;
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Yellow;
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
        }
        private void button4_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }

    }
}
