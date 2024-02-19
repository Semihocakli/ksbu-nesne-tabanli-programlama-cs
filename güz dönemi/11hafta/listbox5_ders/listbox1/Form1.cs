using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace listbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //object[] a1 = new object[] { "KUTAHYA1", "KUTAHYA2", "KUTAHYA3", "KUTAHYA4", "KUTAHYA5","amasya" };
            object[] a1 = new object[] { "KARS", "BURSA","USAK", "BOLU", "BURSA","VAN","URFA","BURSA" };
            object[] a2 = new object[] { "BURSA1", "BURSA2", "BURSA3" };
            listBox1.Items.AddRange(a1);
            //listBox2.Items.AddRange(a2);

            listBox1.SelectionMode = SelectionMode.MultiSimple;
            //listBox1.SetSelected(1, true);
            //listBox1.SetSelected(2, true);

            listBox3.Items.AddRange(new object[3] { "1", "2", "3" });
            listBox4.Items.AddRange(new object[3] { "1", "2", "3" });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yenilistekle();
        }
        void yenilistekle()
        {
            //dinamik nesne oluşturma
            ListBox listBox3 = new ListBox();
            listBox3.Size = new Size(100, 100);//x ,y
            listBox3.Location = new Point(15, 125);
            listBox3.Name = "listBox3";
            listBox3.ColumnWidth = 15;

            this.Controls.Add(listBox3);
            listBox3.BeginUpdate();

            for (int i = 1; i <= 20; i++)
            {
                listBox3.Items.Add("Eleman " + i.ToString());
            }
            listBox3.EndUpdate();
        }
        private void button2_Click(object sender, EventArgs e)//toplu_ekle
        {
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(i + ". Eleman");
            }
        }
        private void button4_Click(object sender, EventArgs e)//tumunukopyala
        {
            //y1
            //listBox1.Items.CopyTo(dizi,indexno)
            string[] a = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(a, 0);//istenilen elemandan başlanır
            listBox2.Items.AddRange(a);

            //y2
            int x = listBox1.Items.Count;
            int y = listBox1.SelectedIndex;
            int z = 0;
            for(int s=z;s<x;s++)//ilkden
            { listBox2.Items.Add(listBox1.Items[s]); }
            for (int s = y; s < x; s++)//seciliden
            { listBox3.Items.Add(listBox1.Items[s]); }

        }
        private void button5_Click(object sender, EventArgs e)//arama1
        {
            //klasik arama
            //tekli arama>>var/yok,label/LB2 yaz,seç,adet,indexno bul
            //ÇOKLU arama>> birden fazla aranan kayıt var ise?(Bursa gibi)
            //ÇOKLU arama>>var/yok,LB2 yaz,seç,adet,indexnoları bul

            int i, a; bool b = false;
            a = listBox1.Items.Count;//6
            String t1 = textBox1.Text;
            for (i = 0; i < a; i++)
            {
                if (t1 == listBox1.Items[i].ToString())
                { label1.Text = listBox1.Items[i].ToString(); b = true; }
                //else { }!!!!
            }
            if (b == false) { label1.Text = "YOK"; }
        }
        private void button16_Click(object sender, EventArgs e)//ekleme
        {
            //TB1 yazdığımız ifade/il  LB1 de var ise eklemeyecek.yoksa ekleyecek
            //yapınız.uygulamada yaptık.
            //........
        }
        private void button6_Click(object sender, EventArgs e)//arama2
        {
            if (listBox1.Items.Contains(textBox1.Text) == false)
            {
                label1.Text = "Yok"; 
            }
            else
            {
                label1.Text = "VAR";//var ekleyemessiniz
            }
        }
        private void button14_Click(object sender, EventArgs e)//arama3
        {
            if (listBox1.Items.IndexOf(textBox1.Text) == -1)
            {
                label1.Text = "Yok"; //listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                label1.Text = "VAR";//var ekleyemessiniz
                label2.Text = listBox1.Items.IndexOf(textBox1.Text).ToString();//
            }
        }
        private void button13_Click(object sender, EventArgs e)//arama4
        {
            label2.Text = listBox1.Items.Contains("amasya").ToString();//true,false
            label3.Text = listBox1.Items.IndexOf("amasya").ToString();//index,-1
            label4.Text = listBox1.FindStringExact("amasya", 3).ToString();//index,-1
            label5.Text = listBox1.FindString("amasya", 0).ToString();//index,-1

            //indexof("BURSA"), liste içerisinde arama yapar
            // varsa geriye index no döndürür
            // yoksa geriye - 1 döndürür

            //Contains(string)
            //textbox1=contains("BURSA") ,  liste içerisinde arama yapar
        }
        private void button7_Click(object sender, EventArgs e)//toplu silme1
        {
            //listBox1.Items.Clear();
            //y1            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items.RemoveAt(i--);
            }
            //y2
            for (int i = 0; i < listBox1.Items.Count;)
            {
                listBox1.Items.RemoveAt(i);
            }
        }
        private void button8_Click(object sender, EventArgs e)//toplu silme2
        {
            //y3
			for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                listBox1.Items.RemoveAt(i);
        }
        private void button11_Click(object sender, EventArgs e)//Yukari taşıma1 (yer değiştir)
        {
            string a, b;
            int i = listBox1.SelectedIndex;
            //y1
            a = listBox1.Items[i - 1].ToString();//amasya
            b = listBox1.Items[i].ToString();//bursa//secili (örnek)

            listBox1.Items[i] = a;//amasya
            listBox1.Items[i-1] = b;//bursa

            //y2
            a = listBox1.Items[i-1].ToString();//amasya
            listBox1.Items[i-1] = listBox1.Items[i]; //bursa
            listBox1.Items[i] = a;//amasya
            
            //dikkat!!!
            //listBox1.Items[i] = listBox1.Items[i - 1].ToString();
            //listBox1.Items[i - 1] = listBox1.Items[i].ToString();
        }
        private void button12_Click(object sender, EventArgs e)//Yukari taşıma2 (yer değiştir)
        {
            string a, b;
            int i = listBox1.SelectedIndex;
            a = listBox1.Items[i].ToString();
            listBox1.Items.Insert(i - 1, a);
            listBox1.Items.RemoveAt(i + 1);
        }
        private void button17_Click(object sender, EventArgs e)//En Alta>>taşı (yer değiştir)
        {
            string a, b;
            int i = listBox1.SelectedIndex;//secilinin indisi
            int j = listBox1.Items.Count - 1;//son elemanın indisi

            a = listBox1.Items[i].ToString();
            b = listBox1.Items[j].ToString();
            listBox1.Items[j] = a.ToString();
            listBox1.Items[i] = b.ToString();
        }
        private void button20_Click(object sender, EventArgs e)//ilk_son_eleman_yer_degistirir
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new object[4] { "1", "2", "3", "4" });

            string a, b;
            int i = listBox1.Items.Count - 1;//son elemanın indisi

            a = listBox1.Items[0].ToString();
            b = listBox1.Items[i].ToString();
            listBox1.Items[i] = a;
            listBox1.Items[0] = b;
        }
       private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//secili_enustte_sabitler
        {
            listBox1.TopIndex = listBox1.SelectedIndex;
        }
        private void button15_Click(object sender, EventArgs e)//topindexno yazar
        {
            label6.Text = listBox1.TopIndex.ToString();
            ////O anda ekranda gorunen en ustteki elamanın index nosu
        }

        private void button21_Click(object sender, EventArgs e)//deneme
        {
            //....
            listBox1.Items.Insert(listBox1.Items.Count, listBox1.Items.Count);
        }
        private void button18_Click(object sender, EventArgs e)//Araya Kopyalama
        {
            //listBox3.Items.AddRange(new object[3] { "1", "2","3"});
            int a = listBox3.Items.Count;
            for (int i = a - 1; i >= 0; i--)
            {
                listBox3.Items.Insert(i, listBox3.Items[i]);
            }
            //"1","1","2","2","3","3"
        }
        private void button19_Click(object sender, EventArgs e)//En alta Kopyalama
        {
            //listBox4.Items.AddRange(new object[3] { "1","2","3" });
            int a, b; a = b = listBox4.Items.Count;
            for (int i = 0; i < a; i++, b++)
            {
                listBox4.Items.Insert(b, listBox4.Items[i]);
            }
            //"1", "2","3","1", "2","3"
        }

        void ozellik1()
        {
            //listBox1.SelectionMode = SelectionMode.MultiExtended;

            //listBox1.TopIndex                 //O anda ekranda gorunen en ustteki elamanın index nosu
            //listBox1.MultiColumn = true;       //2-3 sütunlara dolduktan sonra yazar
            //listBox1.IntegralHeight = false;  //en alttaki elemanın nasıl görüneceğini belirler.varsayilan true.en alt tam yada eksik
            //listBox1.TabIndex = 1;
            //listBox1.TabStop = true;
            //listBox1.Top = 12;
            //listBox1.Left = 12;

            //listBox1.ScrollAlwaysVisible = true;   //dikey kaydırma çubuğu her zaman gösterilir olup olmadığını gösteren bir değeri ayarlar.varsayilan false
            //listBox1.FormattingEnabled = true;     //default:false >>If FormattingEnabled is false, SelectedIndex will not be set to -1 when SelectedValue is blank.SelectedIndex, SelectedValue, and FormattingEnabled are related 
            //listBox1.HorizontalScrollbar = true;   //true to display a horizontal scroll bar in the control; otherwise, false.Varsayılan değer false değeridir.

            //listBox1.BorderStyle = BorderStyle.Fixed3D;  //FixedSingle  // None
            //listBox1.Sorted = true;
            //listBox1.Items.CopyTo(dizi,indexno)
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)//temizle
        {
            listBox1.Items.Clear();
        }
        private void button10_Click(object sender, EventArgs e)//arama5
        {

        }

        
    }
}
