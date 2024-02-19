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
        int top=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            LB1.Items.Add("2 Boyutlu");
            LB1.Items.Add("3 boyutlu");
            textBox1.TabIndex = 0;
            textBox1.Focus();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ekle1alt()
        {
           
        }
        private void button1_Click(object sender, EventArgs e)//ekle1
        {
        }
        private void button2_Click(object sender, EventArgs e)//ekle2
        {
        }
        private void button3_Click(object sender, EventArgs e)//ekle3
        {
        }
        private int kontrol()
        {
            
        }
        private void button4_Click(object sender, EventArgs e)//hesapla
        {
            
        }
        private void hesapla1()
        {
           
        }
        private void button5_Click(object sender, EventArgs e)//secilisil
        {
            
        }
        private void ekle1ust()
        {
            
        }
        private void ekle1secili()
        {
           
        }
        private void lbkaldir1()
        {
            
        }
        public void temizle1()
        {
             textBox1.Text = "";
             textBox2.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)//temizle
        {
            
        }
        private void button7_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
