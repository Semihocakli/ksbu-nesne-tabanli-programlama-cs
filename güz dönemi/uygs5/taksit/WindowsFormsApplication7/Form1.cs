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
        int s1, s2, ts; double top, oran, tt;
        private int hata1()
        {
            if (TB1.Text == "" || TB2.Text == "")
            {
                MessageBox.Show("H1:Fiyatı / Ürün Adeti Giriniz");
                return -1;
            }
            if (!RB1.Checked && !RB2.Checked)
            {
                MessageBox.Show("H2:Nakit / KK Seçin");
                return -1;
            }
            if (RB2.Checked && !RB3.Checked && !RB4.Checked && (RB5.Checked || RB6.Checked))
            {
                MessageBox.Show("H3:Ek Taksit için Taksit Seçin");
                return -1;
            }
            if (RB1.Checked && (RB3.Checked || RB4.Checked))
            {
                MessageBox.Show("H4:Nakit de Taksit Seçmeyin");
                return -1;
            }
            if (RB1.Checked && (RB5.Checked || RB6.Checked))
            {
                MessageBox.Show("H5:Nakit de Ek Taksit Seçmeyin");
                return -1;
            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)//hesapla
        {
            if (hata1() == -1){ TB1.Focus(); return; }
            hesapla();
            TB1.Focus();
        }
        public void hesapla()
        {
            s1 = Convert.ToInt32(TB1.Text);
            s2 = Convert.ToInt32(TB2.Text);
            top = (double)(s1 * s2);
            oran = 0.0;
            tt = 0.0;
            ts = 1;
            if (RB1.Checked)
                oran = -10.0;
            if (RB2.Checked && !RB3.Checked && !RB4.Checked && !RB4.Checked && !RB4.Checked)
            {
                oran = 0.0;
                ts = 1;
            }
            if (RB2.Checked && RB3.Checked)
            {
                oran = 10.0;
                ts = 2;
            }
            if (RB2.Checked && RB4.Checked)
            {
                oran = 20.0;
                ts = 3;
            }
            if (RB5.Checked)
            {
                oran += 10.0;
                ts += 2;
            }
            if (RB6.Checked)
            {
                oran += 20.0;
                ts += 4;
            }
            top += top * oran / 100.0;
            tt = Math.Round(top / (double)ts, 2);
            label1.Text = "Toplam Tutar: " + top;
            label2.Text = "Taksit Tutarı: " + tt;
            label3.Text = "Taksit Sayısı:: " + ts;
            label4.Text = "Oran: % " + oran;
        }

        private void button2_Click(object sender, EventArgs e)//temizle
        {
            temizle1();
            RB1.Checked = false;
            RB2.Checked = false;
            RB3.Checked = false;
            RB4.Checked = false;
            RB5.Checked = false;
            RB6.Checked = false;
        }
        public void temizle1()
        {
            TB1.Text = "";
            TB2.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RB1.Text = "Nakit (%10 indirim)";
            RB2.Text = "(KK)-Taksitsiz";
            RB3.Text = "2 Taksit (%10)";
            RB4.Text = "3 Taksit (%20)";
            RB5.Text = "+2 Ek Taksit (+ %10 ekle)";
            RB6.Text = "+4 Ek Taksit (+ %20 ekle)";
            button1.Text = "Hesapla";
            button2.Text = "Temizle";
            button3.Text = "KAPAT";
        }
        private void button3_Click(object sender, EventArgs e)//kapat
        {
            Close();
        }
    }
}