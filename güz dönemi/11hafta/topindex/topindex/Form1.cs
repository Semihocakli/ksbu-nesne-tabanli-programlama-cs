using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topindex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object[] a1 = new object[] { "ali1", "ali2", "ali3", "ali4", "ali5", "ali3", "ali4", "ali5" };
            object[] a2 = new object[] { "ak", "kaya", "dik", "uzun", "demir", "dik", "uzun", "demir" };
            object[] a3 = new object[] { "20", "50", "60", "90", "30", "60", "90", "30" };
            listBox1.Items.AddRange(a1);
            listBox2.Items.AddRange(a2);
            listBox3.Items.AddRange(a2);
            ekle();
        }
        private void ekle()
        {
            //ekle
            object[] a1 = new object[] { "ali7", "ali8", "ali9", "ali10" };
            object[] a2 = new object[] { "kor", "tor", "ser", "ver" };
            object[] a3 = new object[] { "55", "77", "99", "15" };
            listBox1.Items.AddRange(a1);
            listBox2.Items.AddRange(a2);
            listBox3.Items.AddRange(a2);
        }
        private void listBox1_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
            //listBox4.SelectedIndex = listBox1.SelectedIndex;

            listBox1.TopIndex= listBox1.SelectedIndex;
            listBox2.TopIndex = listBox1.SelectedIndex;
            listBox3.TopIndex = listBox1.SelectedIndex;
            // Auto Scroll to the multiple selected item in the listbox
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
            //listBox4.SelectedIndex = listBox2.SelectedIndex;

            listBox1.TopIndex = listBox2.SelectedIndex;
            listBox2.TopIndex = listBox2.SelectedIndex;
            listBox3.TopIndex = listBox2.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.TopIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
