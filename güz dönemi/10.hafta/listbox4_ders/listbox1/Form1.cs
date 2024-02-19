using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        int[] A;
        string[] F;
        void dizitanimla()
        {
			A =new int[6] { 1, 2, 3, 4, 5, 6 };//global tanımlama
			int[] B = new int[6]{ 1, 2, 3, 4, 5, 6 };//
            int[] C = new int[10];
			String[] D = { "ali","veli","ayse","omer","kadir","osman" };
            object[] E = { "AAA", "BBB", "CCC", "DDD", "EEE" };
            F= new string[5] { "AAA", "BBB", "CCC", "DDD", "EEE" };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
			listBox1.SelectedItem = SelectionMode.MultiSimple;
            ekle1();//6yontem
            listBox2.Items.AddRange(new object[] { "AAA", "BBB", "CCC","DDD","EEE" });
            //eklex();
        }
        void eklex()
        {
            dizitanimla();
            listBox1.Items.AddRange(F);
        }
            void ekle1()
        {
            listBox1.Items.Add("BURSA"); //yontem1
            //listBox1.Items.Add(textBox1.Text); //yontem1

            listBox1.Items.AddRange(new object[1] { "TOKAT" });//yontem2
            listBox1.Items.AddRange(new object[2] { "VAN", "HATAY" });
            listBox1.Items.AddRange(new object[] { "TRABZON", "KONYA", "BURDUR" });

            String[] a = { "ANTEP", "ANTALYA" ,"AAAA"};//yontem3
            // String[] a1 = new String[] {"ANTEP","ANTALYA" };
            // String[] a2 = new String[2]{"ANTEP", "ANTALYA" };
            // object[] a3 = new object[2]{"USAK","KARS"};
            listBox1.Items.AddRange(a);

            listBox1.Items.Add(a[0]);//yontem5
            listBox1.Items.Add(a[1]);
            listBox1.Items.Add(a[2]);

            for (int i = 0; i < a.Length; i++)//yontem6
            {
                listBox1.Items.Add(a[i]);
            }
        }
        private void button5_Click(object sender, EventArgs e)//ekle2
        {
            //listBox1.Items.Add();
        }
        void ekle2() //Add,insert(P1,P2)
        {
            listBox1.Items.Insert(0, "TOKAT1");//üstte ekle
            listBox1.Items.Insert(listBox1.SelectedIndex, "TOKAT2");//seçili yere(üste)ekle
            listBox1.Items.Insert(listBox1.Items.Count, "TOKAT3");//sona ekle
            //listBox1.Items.Add();
        }
        private void button4_Click(object sender, EventArgs e)//ekle3
        {
            ekle3();
        }
        void ekle3()//dizilerde bir indis,eleman var,A[0]=1;A[1]=2;
        {
            listBox2.Items.Add(listBox1.SelectedItem);//seçili LB1>>LB2
            listBox3.Items.Add(listBox2.SelectedItem);//
            listBox3.Items.Add(listBox1.SelectedItem);//

            listBox2.Items.Add(listBox1.Items[0]);//
            listBox2.Items.Add(listBox1.Items[1]);//
            listBox2.Items.Add(listBox1.SelectedItems[0]);//
        }
        private void button8_Click(object sender, EventArgs e)//ekle4
        {
            ekle4();
        }
        void ekle4()
        {
            //listBox2.Items.Insert(3, textBox1.Text);//indis1
            listBox2.Items.Insert(listBox1.SelectedIndex, textBox1.Text);

            listBox1.Items.Insert(listBox1.SelectedIndex, textBox1.Text);
            listBox1.Items.Insert(listBox1.SelectedIndex, F[0]);
        }
        private void button1_Click(object sender, EventArgs e)//teklisecyaz
        {
            teklisecyaz();
        }
        void teklisecyaz()
        {
            //*******************************//seciliyaz

            textBox1.Text = listBox1.Text.ToString();//secili yaz
            textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();//secili yaz
            textBox3.Text = listBox1.SelectedItem.ToString();//secili yaz     
            textBox4.Text = listBox1.SelectedItems[0].ToString();//(coklu)secili 1.eleman yaz***********       

            //*******************************
            //for i=0 count
            textBox5.Text = listBox1.Items[1].ToString();//0.elemani yaz(2.ile aynı)

            for (int i = 0; i < listBox1.Items.Count; i++)//
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }

            //*******************************//indexno
            label1.Text = listBox1.SelectedIndex.ToString();//indexno 
            label2.Text = listBox1.SelectedIndices[0].ToString(); //(coklu)1.eleman indexno*************
            label3.Text = listBox1.Items.IndexOf(listBox1.Text).ToString();//indexno 
            
            //*******************************
            label4.Text = listBox1.Items.Count.ToString(); //eleman sayisi
            label5.Text = listBox1.SelectedIndices.Count.ToString();//(coklu secili)eleman sayisi
            label6.Text = listBox1.SelectedItems.Count.ToString();//(coklu secili)eleman sayisi
        }
        private void button6_Click(object sender, EventArgs e)//coklusecyaz
        {
            coklusecyaz();
        }
        void coklusecyaz()//en az 3 tane seçin
        {
            //3 tane eleman seçtiğimizi düşünelim.
            label1.Text = listBox1.SelectedItems[0].ToString();//coklu secili 1.yaz
            label2.Text = listBox1.SelectedItems[1].ToString();//coklu secili 2.yaz
            label3.Text = listBox1.SelectedItems[2].ToString();//coklu secili 3.yaz
            //**********************************
            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)//
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
            //**********************************
            label4.Text = listBox1.SelectedIndices[0].ToString();//indexno
            label5.Text = listBox1.SelectedIndices[1].ToString();//indexno
            label6.Text = listBox1.SelectedIndices[2].ToString();//indexno

            //**********************************
            label7.Text = listBox1.SelectedIndices.Count.ToString();//(coklu secili)eleman sayisi
            label8.Text = listBox1.SelectedItems.Count.ToString();//(coklu secili)eleman sayisi
        }
        void degistir1()
        {
            listBox1.Items[3] = "VAN1";  //yontem1 // textBox1.Text; 

            listBox1.Items.Insert(3, "VAN2"); //yontem2
            listBox1.Items.RemoveAt(4);

            listBox1.Items.Insert(4, "VAN3");//yontem3
            listBox1.Items.RemoveAt(3);
        }
        private void button10_Click(object sender, EventArgs e)//deneme1
        {
            //degistir1();
            //listBox1.Items[3] = "AAAAAAAAAAAAAA";  //yontem1
            listBox1.Items[listBox1.SelectedIndex] = "BBBBBBBBBBBBBBBBB";
            listBox1.Items[listBox1.Items.Count] = "BBBBBBBBBBBBBBBBB";
        }
        void sil()
        {
            //items tabanlı silme- tekli silme
            listBox1.Items.Remove("BURSA");
            listBox1.Items.Remove(textBox1.Text);

            listBox1.Items.Remove(listBox1.Text); //secili sil
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItems[0]);
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);

            //**********************************
            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)//
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }

            //*************************
            //index tabanlı silme
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            listBox1.Items.RemoveAt(2);

            listBox1.Items.RemoveAt(listBox1.Items.Count);

            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)//
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }
        void seckaldir()//seckaldirtemizle
        {
            //listBox1.SetSelected(P1,P2);(indexno,true/false)
            listBox1.SetSelected(1, true); //index1seçer
            listBox1.SetSelected(2, false);//index2kaldirma

            listBox1.SetSelected(listBox1.SelectedIndex, false); //seciliyi kaldırma

            listBox1.SelectedIndex = 1;//secme   0,1,2,3 - TRUE
            listBox1.SelectedIndex = -1;//kaldirma  -- FALSE

            listBox1.ClearSelected(); //kaldirma
            listBox1.SelectedItems.Clear(); //kaldirma

            listBox1.Items.Clear();  //temizle
        }
        
        private void button7_Click(object sender, EventArgs e)//deneme2
        {
            listBox2.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, false);
            }

           // listBox1.Items.Clear();
        }
        void deneme()
        {

            if (listBox1.Items[1].ToString() == "ankara") { label1.Text = "doğru"; }
            
            for (int i = 0; i < listBox1.SelectedIndices.Count; i++)//SelectedItems.Count
            {
                {
                    //listBox2.Items.Add(listBox1.Items[i]);
                    //listBox2.Items.Add(listBox1.SelectedItems[i]);
                    //listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndices[i]]);
                    listBox2.Items.Add(listBox1.SelectedIndices[i]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)//secili(LB1)>>LB2
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == true)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)//secili(siz)<>tersi
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i) == false)
                {
                    listBox1.SetSelected(i, true);
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
