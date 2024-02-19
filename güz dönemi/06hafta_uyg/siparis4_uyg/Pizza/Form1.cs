using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String isim = "";
        int telefon = 0;
       
        private void button1_Click(object sender, EventArgs e)//ekle
        {
            isim = textBox1.Text;

        }
        private void button3_Click(object sender, EventArgs e)//listbox temizle
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)//siparis temizle
        {
        }
        private void button4_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
