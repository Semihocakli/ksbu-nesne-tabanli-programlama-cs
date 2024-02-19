using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t1,t2;double top=0;
         private int hata1()
         {
         if (textBox1.Text == "" || textBox2.Text == "")
         { MessageBox.Show("H1:Fiyatı ve Ürün Adeti Giriniz"); return 0; }
          return 1;
         }
        private void button1_Click(object sender, EventArgs e)//hesapla
        {
            if (hata1() == 0) { textBox1.Focus(); return; } 
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);

            if (rB1.Checked && !cB1.Checked) { top = ((t1 * t2) * 0.9); yaz(); return; }//ind
            //if (rB1.Checked && !rB2.Checked && !cB1.Checked) { top = ((t1 * t2) * 0.9); return; }//ind

            if (rB1.Checked && cB1.Checked) { top = ((t1 * t2) * 0.9)-10; yaz(); return; }//ind-10


            if (rB2.Checked && !rB3.Checked && !rB4.Checked)
            { top = (t1 * t2); yaz(); return; }//pesin

            if (rB2.Checked && rB3.Checked && !rB5.Checked && !rB6.Checked)
            { top = ((t1 * t2) * 1.05); yaz(); return; }//2 taksit

            if (rB2.Checked && rB3.Checked && rB5.Checked && !rB6.Checked)
            { top = ((t1 * t2) * 1.15); yaz(); return; }//+2 ek taksit

            //hesapla(9 kullanılabilir.
            //if (rBx.Checked && rBx.Checked){ hesapla();}
        }
        public void yaz()
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label3.Text = top.ToString();
        }
        public void hesapla()
        {
        
        }
        private void rbkaldir1()
        {
            rB1.Checked = false;
            rB2.Checked = false;
            rB3.Checked = false;
            rB4.Checked = false;
            rB5.Checked = false;
            rB6.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)//temizle
        {
            temizle1(); rbkaldir1();
        }
        public void temizle1()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = ""; label2.Text = ""; label3.Text = "";
            rB1.Checked = false;
            //....
            cB1.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form1.bac = Color.Green;
            //label1.BackColor = Color.Blue;
            //button1.BackColor = default(Color);
            //this.BackColor = Color.Gray;
        }
        private void button3_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
