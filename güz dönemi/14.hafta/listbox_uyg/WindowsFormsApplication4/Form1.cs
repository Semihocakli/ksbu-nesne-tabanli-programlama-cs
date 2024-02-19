using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static object[] no = new object[] { 11, 12, 13, 14 };
        public static object[] adsoyad = new object[] { "ali1", "ali2", "ali3", "ali4", "ali5", "ali6" };
        public static object[] vize = new object[] { 70, 44, 54, 55, 30, 80 };
        public static object[] final = new object[] { 95, 54, 60, 55, 70, 90 };
        int i,j;
        private void Form1_Load(object sender, EventArgs e)
        {
            LB1.Items.AddRange(adsoyad);
            LB2.Items.AddRange(vize);
            LB3.Items.AddRange(final);
            TB1.Focus();
        }
        private void button5_Click(object sender, EventArgs e)//araya ekle
        {
            if (TB1.Text == "" || TB2.Text == "" || TB3.Text == "" || LB1.SelectedIndex == -1)
            { MessageBox.Show("Tüm Alanları Doldurunuz/Seçim yapın..."); TB1.Focus(); return; }
			//ekle,sec,temizle	
        }
        private void ekle()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)//ekle
        {
            if (TB1.Text == "" || TB2.Text == "" || TB3.Text == "")
            { MessageBox.Show("Tüm Alanları Doldurunuz..."); TB1.Focus(); return; }
            //ekle,sec,temizle
        }
		private void degistir()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)//degistir
        {
            if (TB1.Text == "" || TB2.Text == "" || TB3.Text == "" || LB1.SelectedIndex == -1)
            { MessageBox.Show("Tüm Alanları Doldurunuz/Seçim yapın..."); TB1.Focus(); return; }
            
		 //degistir,temizle
        }
        private void button3_Click(object sender, EventArgs e)//bul
        {
            if (TB1.Text == "")
            { MessageBox.Show("Bir isim girinn..."); TB1.Focus(); return; }
            string a = TB1.Text;
			//ara 
        }
		private void sil()
        {
            
        }
        private void button4_Click(object sender, EventArgs e)//sil
        {
            if (j == -1)
            { MessageBox.Show("Seçim yapın..."); TB1.Focus(); return; }
			//sil, sec, temizle
        }
        private void ListBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void ListBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void ListBox3_Click(object sender, EventArgs e)
        {
            
        }
        private void sec(int k)
        {
			//....
            TB1.Focus(); TB1.Select(TB1.Text.Length, 0);
        }
        private void button6_Click(object sender, EventArgs e)//y1- yukarı_taşı
        {
            if (LB1.SelectedIndex < 1)
            { MessageBox.Show("En üsttte yada Seçim yapınız..."); TB1.Focus(); return; }
            //fonk. kullanmadan yazın...
        }
        private void button7_Click(object sender, EventArgs e)//y1- aşağı_taşı
        {
            if (LB1.SelectedIndex == -1 || LB1.SelectedIndex == LB1.Items.Count - 1)
            { MessageBox.Show("En altta.Doğru Seçim yapınız..."); TB1.Focus(); return; }
            //fonk. kullanmadan yazın...
        }
        private void button12_Click(object sender, EventArgs e)//y1- en alta taşıma
        {
            if (LB1.SelectedIndex == -1 || LB1.SelectedIndex == LB1.Items.Count - 1)
            { MessageBox.Show("Doğru Seçim yapınız..."); TB1.Focus(); return; }
            
           //fonk. kullanmadan yazın...
        }
        private void button13_Click(object sender, EventArgs e)//y1- en üste taşıma
        {
            if (LB1.SelectedIndex < 1)
            { MessageBox.Show("Doğru Seçim yapınız..."); TB1.Focus(); return; }
            //fonk. kullanmadan yazın...
        }
        private void ilksontasi(int k)//y2
        {
            //....
        }
        private void tasi(int k)//y2
        {
            //....
        }
        private void button14_Click(object sender, EventArgs e)//y2
        {
			//tasi;sec;
			
        }
        private void button16_Click(object sender, EventArgs e)//y2
        {
			//tasi; sec;
        }
        private void button18_Click(object sender, EventArgs e)//y2
        {
			//ilksontasi;sec;
        }
        private void button20_Click(object sender, EventArgs e)//y2
        {
			//ilksontasi;sec;
        }
        private void tasima(int k)//y3-tek fonk.
        {
        //....
        }
        private void button15_Click(object sender, EventArgs e)//y3
        {
			//tasima; sec;
        }
        private void button17_Click(object sender, EventArgs e)//y3
        {
		  //tasima; sec;
        }
        private void button19_Click(object sender, EventArgs e)//y3
        {
		 //tasima();sec();
        }
        private void button21_Click(object sender, EventArgs e)//y3
        {
			//tasima(); sec();
        }

        private void button8_Click(object sender, EventArgs e)//text temizle
        {
            temizle2();
        }
        private void temizle2()
        {
            TB1.Text = ""; TB2.Text = "";
            TB3.Text = ""; TB1.Focus();
        }
        private void temizle()
        {
            LB1.Items.Clear(); LB2.Items.Clear();
            LB3.Items.Clear();
            TB1.Focus();
        }
        private void button9_Click(object sender, EventArgs e)//listbox temizle
        {
            temizle();
        }
        private void button10_Click(object sender, EventArgs e)//topluekle
        {
            temizle();
        }
        private void button11_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
