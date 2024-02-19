using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//arraylist
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ogrenci = new ArrayList();
		public string[] student = new string[100];
        int i = 4, j = 4;
        private void Form1_Load(object sender, EventArgs e)
        {
            LB1.Items.Add("ali");
            LB1.Items.Add("osman");
            LB1.Items.Add("fatma");
            LB1.Items.Add("veli");
            LB1.Items.Add("ayse");
            ogrenci.Add("Erkek"); ogrenci.Add("Erkek");
            ogrenci.Add("Bayan"); ogrenci.Add("Erkek");
            ogrenci.Add("Bayan");
            //LB1.SelectedIndex = j;//aktifkayıt,niye kapattık!!!
            kisigoster();
            btndurum();
        }
        private void button5_Click(object sender, EventArgs e)//ekle
        {
            string t1 = textBox1.Text;
            if(t1!="") //önceki yazdığımız şekilde de yazılabilir.dikkat!!! hata kontrolu
            {
                LB1.Items.Add(t1);
                if (RB1.Checked) { ogrenci.Add("Erkek"); }
                if (RB2.Checked) { ogrenci.Add("Bayan"); }
                i++;
                j = i;
                textBox1.Text = "";
                //LB1.SelectedIndex = j;,niye kapattık!!!
                kisigoster();
                btndurum();
                MessageBox.Show("Eklendi");
            }
             else { MessageBox.Show("Boş olamaz..."); }
        }
        private void button6_Click(object sender, EventArgs e)//bul
        {
            string t1 = textBox1.Text;
            if (t1 != "")  //önceki yazdığımız şekilde de yazılabilir.dikkat!!! hata kontrolu
            {
               if(LB1.Items.Contains(t1)==true)
                {
                    LB1.SelectedItem = t1;//"veli"
                    j = LB1.SelectedIndex;
                    kisigoster();
                    btndurum();
                }
                else { MessageBox.Show("Kişi Bulunamadı"); textBox1.Focus(); }
            }
        }
        private void button7_Click(object sender, EventArgs e)//sil
        {
            if (LB1.SelectedIndex == -1)
            { MessageBox.Show("Listeden isim seçin !!!");
             textBox1.Focus(); return;
            }

            string a = LB1.SelectedItem.ToString();
            DialogResult sonuc;
            sonuc=MessageBox.Show(a + " silinsin mi","Silme",MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                int indis = LB1.SelectedIndex;
                LB1.Items.RemoveAt(indis);
                ogrenci.RemoveAt(indis);
                j = indis-1;//niye 1 çıkardık!!
                i--;
                //LB1.SelectedIndex = j;,niye kapattık!!!
                MessageBox.Show("Silindi");
                kisigoster();
                btndurum();
            }
            else
            {
                textBox1.Focus(); return; 
            }
        }
        private void kisigoster()
        {
            LB1.SelectedIndex = j;//*********diğer yerlerden kaldırdık.önemli
            label7.Text = LB1.SelectedItem.ToString();//ad
            label8.Text = ogrenci[j].ToString();//cins
            label9.Text = (i+1).ToString();//top,LB1.Items.Count;
            label10.Text = (j + 1).ToString();//aktif,LB1.SelectedIndex + 1
            if (ogrenci[j].ToString() == "Erkek")
            { RB1.Checked = true; }
            if (ogrenci[j].ToString() == "Bayan")
            { RB2.Checked = true; }
            //btndurum() fonksiyonu ile birleştirilebilir!!!dikkat
        }
        private void ListBox1_Click(object sender, EventArgs e)
        {
            //SelectedIndexChanged events , default, kullanmayın
            j = LB1.SelectedIndex;
            kisigoster();
            btndurum();
        }
        private void button1_Click(object sender, EventArgs e)//ilkkayıt
        {
            j = 0;
            kisigoster();
            btndurum();
        }
        private void button2_Click(object sender, EventArgs e)//oncekikayıt
        {
            j--;//LB1.SelectedIndex--;
            kisigoster();
            btndurum();
        }
        private void button3_Click(object sender, EventArgs e)//sonrakikayıt
        {
            j++;
            kisigoster();
            btndurum();
        }
        private void button4_Click(object sender, EventArgs e)//sonkayıt
        {
            j = i;
            kisigoster();
            btndurum();
        }
		private void btndurum()
        {
            //onceki,sonraki butonlar için dikkat
            //niye if lerin ustunde, if lerin icine yazılır mı?
            button1.Enabled = true;//ilk
            button2.Enabled = true;//sonraki
            button3.Enabled = true;//onceki
            button4.Enabled = true;//son

            if (j==0)
            {
                button1.Enabled = false;//ilk
                button2.Enabled = false;//sonraki
            }
            if (j == i)
            {
                button3.Enabled = false;//onceki
                button4.Enabled = false;//son
            }
            textBox1.Focus();//niye buraya yazıldı!!!!dikkat
        }
        private void button9_Click(object sender, EventArgs e)//deneme,onemli
        {
            //ListBox1.SelectedItem = "veli";//textbox1,seçer
            //ListBox1.Text = "veli";//textbox1, seçer
            //label11.Text = ListBox1.Items.IndexOf("veli").ToString();//textbox1>> 3

            label11.Text = LB1.Text;
            label12.Text = LB1.SelectedItem.ToString();
            label13.Text = LB1.Items[j].ToString();
        }
        private void button8_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
