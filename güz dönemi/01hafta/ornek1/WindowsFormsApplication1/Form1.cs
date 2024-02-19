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
        
        private void button1_Click(object sender, EventArgs e)//deneme1
        {
            textBox3.Text = "ksbu";
            label1.Text = "dfdfd";
          //ornek1(), ornek2(),ornek3() içindekileri burada teke tek deneyiniz..

        }
        private void button2_Click(object sender, EventArgs e)//deneme2
        {
            textBox1.Text = "button2 BASILDI";
            //ornek1(), ornek2(),ornek3() içindekileri burada teke tek deneyiniz..

            textBox2.Text = "ksbu";
            label1.Text = "dfdfd";
            textBox3.Text = "3";

            textBox1.Text = "";
            textBox1.Clear();
        }
        protected void ornek1()
        {
            //TextBox3.Text = 3;
            //TextBox3.Text = (3 + 5);
            textBox3.Text = "ksbu";
            label1.Text = "dfdfd";
            textBox3.Text = "3";
            textBox3.Text = Convert.ToString("3");
            textBox3.Text = Convert.ToString(3);
			textBox3.Text = 3.ToString();

			textBox3.Text = "3" + "5";
            textBox3.Text = (3 + 5).ToString();//8          
            textBox3.Text = Convert.ToString(3 + 5);//8
            textBox3.Text = Convert.ToString(3 + 5).ToString();//8

            label1.Text = textBox1.Text;
            textBox3.Text = textBox1.Text;
            textBox3.Text = Convert.ToString(textBox1.Text);
            textBox3.Text = textBox1.Text.ToString();
            string x = Convert.ToString(textBox1.Text);

            textBox3.Text = textBox1.Text + "3";   //23
            textBox3.Text = textBox1.Text.ToString() + "3";   //23
            textBox3.Text = textBox1.Text + textBox2.Text;

            //****************************
            int d;
            string ab;
            int a;
            a = Convert.ToInt32(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            textBox3.Text = c.ToString();

            textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));

            //************************************
            ab = c.ToString();            
            label1.Text = ab.ToString();
            label2.Text = Convert.ToString(ab);
            label3.Text = Convert.ToString(ab.ToString());
        }
		  protected void ornek2()
        {
			int a = Convert.ToInt32(textBox1.Text);
            int ya = 6 * (a * a);           
            int d = Convert.ToInt32(6* Math.Pow(a,2));
            int s = Convert.ToInt32(Math.PI * 3);
            //int ss = (Math.PI * 3);


            double f = Math.PI * 3;
		}
        protected void ornek3()
        {
            double a = Math.PI;
            double b = Math.Pow(2, 3);
            double c = Math.Sqrt(16);
        }
        private void button3_Click(object sender, EventArgs e)//form2
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            //ornek1();
            //textBox1.Clear();//method
            //nesne.özellik=değer
        }
        private void button4_Click(object sender, EventArgs e)//form3
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                textBox1.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
