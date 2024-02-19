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
        private void lB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = lB2.SelectedIndex.ToString();
            label2.Text = lB2.Text;
            textBox1.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox2.Text = "Mevsimler";

            lB2.Items.Add("AHMET");
            lB2.Items.Add("YAVUZ");
            lB2.Items.Add("OSMAN");
            lB2.Items.Add("FATMA");

            radioButton1.Text = "BAŞA EKLE/SIL";
            radioButton2.Text = "SEÇİLİ (VARSAYILAN) EKLE/SIL";
            radioButton3.Text = "SEÇİLİ (ALTA) EKLE/SIL";            
            radioButton4.Text = "SONA EKLE/SIL";
            label3.Text = lB2.Items.Count.ToString();
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)//ekle
        {
            if (textBox1.Text=="")
            { MessageBox.Show("BOŞ BIRAKILAMAZ");
                textBox1.Focus();return; }
            int lb2i = lB2.SelectedIndex;
            int lb2c = lB2.Items.Count;
            if (radioButton1.Checked == true)//en uste
            {
                lB2.Items.Insert(0, textBox1.Text);
            }
            if (radioButton2.Checked == true)//secili konuma ustune
            {
                lB2.Items.Insert(lb2i, textBox1.Text);
            }
            if (radioButton3.Checked == true)//secili konuma altına
            {
                lB2.Items.Insert(lb2i + 1, textBox1.Text);
            }
            if (radioButton4.Checked == true)//en alta
            {
                lB2.Items.Insert(lb2c, textBox1.Text);
                //lB2.Items.Add(textBox4.Text);
            }
            label3.Text = lB2.Items.Count.ToString();
            lB2.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)//sil
        {
            if (lB2.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek icin secim yapmalisiniz");
                textBox1.Focus(); return;
            }
            int lb2c = lB2.Items.Count;
            int lb2i = lB2.SelectedIndex;

            if (radioButton1.Checked == true)
            {
                lB2.Items.RemoveAt(0);
            }
            else if (radioButton2.Checked == true)
            {
                lB2.Items.RemoveAt(lb2i+1);
            }
            else if (radioButton3.Checked == true)
            {
                lB2.Items.RemoveAt(lb2i);
            }
            else if (radioButton4.Checked == true)
            {
                lB2.Items.RemoveAt(lb2c - 1);
            }
            label3.Text = lB2.Items.Count.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
    }
