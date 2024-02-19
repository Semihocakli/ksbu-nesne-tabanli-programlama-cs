using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int cay = 0, kola = 0, su = 0, simit = 0, borek = 0, hmbrger = 0;
        int top = 0;string y = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] a = {"1","2","3","4","5"};
            comboBox1.Items.AddRange(a);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void hesapla()
        { 
           
        }
        private void button1_Click(object sender, EventArgs e)//temizle
        {
            
        }
        private void button2_Click(object sender, EventArgs e)//KAPAT
        {
            this.Close();
        }
        
    }
}
