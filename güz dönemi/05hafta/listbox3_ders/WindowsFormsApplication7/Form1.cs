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
            lB1.Items.Add("2 Boyutlu");
            lB1.Items.Add("3 boyutlu");
            lB1.Items.Add("Diğer");
            textBox1.TabIndex = 0;
            textBox1.Focus();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lB2.Items.Clear();
            lB3.Items.Clear();
            lB4.Items.Clear();
            if (lB1.SelectedIndex == 0)
            {
                lB2.Items.Add("Kare");
                lB2.Items.Add("Dikdörtgen");
                lB2.Items.Add("Üçgen");
            }
            if (lB1.SelectedIndex == 1)
            {
                lB2.Items.Add("Küp");
                lB2.Items.Add("Silindir");
                lB2.Items.Add("Koni");
            }
            if (lB1.SelectedIndex == 2)
            {
                lB2.Items.Add("2.Denklem");
                lB2.Items.Add("3.Denklem");
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lB3.Items.Clear();
            lB4.Items.Clear();
            if (lB1.SelectedIndex == 0 && lB2.SelectedIndex == 0)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Çevre");
            }
            if (lB1.SelectedIndex == 0 && lB2.SelectedIndex == 1)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Çevre");
            }
            if (lB1.SelectedIndex == 0 &&  lB2.SelectedIndex == 2)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Çevre");
            }
            //*********
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 0)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Hacim");
            }
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 1)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Hacim");
            }
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 2)
            {
                lB3.Items.Add("Alan");
                lB3.Items.Add("Hacim");
            }
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lB4.Items.Clear();
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 0 && lB3.SelectedIndex == 0)
            {
                lB4.Items.Add("Yüzey Alanı");
                lB4.Items.Add("Kesit Alanı");
            }
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 1 && lB3.SelectedIndex == 0)
            {
                lB4.Items.Add("Taban Alan");
                lB4.Items.Add("Yanal Alan");
                lB4.Items.Add("Toplam Yüzey Alan");
                lB4.Items.Add("Kesit Alan");
            }
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 2 && lB3.SelectedIndex == 0)
            {
                lB4.Items.Add("Taban Alan");
                lB4.Items.Add("Yanal Alan");
                lB4.Items.Add("Toplam Yüzey Alan");
            }
        }
        private void button1_Click(object sender, EventArgs e)//hesapla
        {
            hesapla1(); 
        }
        private void hesapla1()
        {
            if (textBox1.Text == "")
            { MessageBox.Show("hata1,Text'ler bos birakılamaz."); textBox1.Focus(); return; }
            int t1 = Convert.ToInt32(textBox1.Text);
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 0 && lB3.SelectedIndex == 0 && lB4.SelectedIndex == 0)
            {
                label3.Text = (6 * t1 * t1).ToString();
            }
            if (lB1.SelectedIndex == 1 && lB2.SelectedIndex == 0 && lB3.SelectedIndex == 0 && lB4.SelectedIndex == 1)
            {
                label3.Text = (t1 * t1).ToString();
            }
        }
        private void hesapla2()
        {
            if (textBox1.Text == "")
            { MessageBox.Show("hata1,Text'ler bos birakılamaz."); textBox1.Focus(); return; }
            int t1 = Convert.ToInt32(textBox1.Text);
            int lb1, lb2, lb3, lb4;
            lb1 = lB1.SelectedIndex; lb2 = lB2.SelectedIndex;
            lb3 = lB3.SelectedIndex; lb4 = lB4.SelectedIndex;
            if (lb1 == 1 && lb2 == 0 && lb3 == 0 && lb4 == 0)
            {
                label3.Text = (6 * t1 * t1).ToString();
            }
            if (lb1 == 1 && lb2 == 0 && lb3 == 0 && lb4 == 1)
            {
                label3.Text = (t1 * t1).ToString();
            }
            if (lb1 == 0 && lb2 == 0 && lb3 == 0 && lb4 == -1)
            {
                label3.Text = (t1 * t1).ToString();
            }
        }
        private void lbkaldir1()
        {
            lB1.Items.Clear();
            lB2.Items.Clear();
            lB3.Items.Clear();
            lB4.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)//temizle
        {
            temizle1(); lbkaldir1();
        }
        public void temizle1()
        {
            label1.Text = "";textBox1.Text="";
            label2.Text = "";textBox2.Text = "";
            label3.Text = "";textBox3.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
