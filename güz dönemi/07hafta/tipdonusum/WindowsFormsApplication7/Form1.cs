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
        private void button1_Click(object sender, EventArgs e)//tanimlamalar
        {
            int x;
            //      int x1;  x1=new int();      
            //      int x2 = new int();      
            //      int x3 = new System.Int32();
            //      System.Int32 x4;   
            //      System.Int32 x5 = new int();
            //      System.Int32 x6=new System.Int32();
            int a = 0;
            int b = new int();           //sayinin degeri 0 olur.
            int c = new System.Int32();

            int d; d = 0;
            int p = new int();

            Int16 f;
            Int32 g;
            Int64 h;

            System.Int32 z;//CLS tanımlama
            Int32 i = new Int32();
            Int32 j = new System.Int32();
            System.Int32 k = new int();
            System.Int32 m = new System.Int32();

			char ch = 'B';

            label1.Text = c.ToString();//digerlerini siz yapın...       
        }
        static void tipdonusumleri()
        {
            // =veri<FDMUL>;
            // =tip.Parse();    ("metinsel")
            // =Convert.ToTip();
            // =veri.ToString();
            // =(tip)veri;
        }
        private void button2_Click(object sender, EventArgs e)//tipdonusum1
        {
            int a1 = 12;
            long a2 = 12;

            float f1 = 33.3F;
            float f2 = 33;
            float f3 = 12F;
            float f4 = 12f;
            float f5 = 3.1234567F;
			float f6 = 35e3F;

            double p1 = 12;
            double p2 = 12.0;
            double p3 = 12.56;
            double p4 = 12D;
            double p5 = 12d;
			double p6 = 12E4D;

            decimal d3 = 12;
            decimal d4 = 12M;

            long d5 = 120L;
            ulong d6 = 120;//signed int>>ulong
            ulong d7 = 120U;//unsigned int>>ulong
            ulong d8 = 120L;//signed long>>ulong
            ulong d9 = 120UL;//unsigned long>>ulong
            label1.Text = d9.ToString();//digerlerini siz yapın...       
        }
        private void button3_Click(object sender, EventArgs e)//tipdonusum2
        {
            string t1 = textBox1.Text;
            string t2 = "345";
            int f=5;

            int g1 = int.Parse(t1);
            int g2 = int.Parse(t2);//int.Parse(string) şeklinde olmalıdır.dikkat
            int g3 = int.Parse(textBox1.Text);
            int g4 = Convert.ToInt32(textBox1.Text);
            int g5 = Convert.ToInt32(3);

            // int g6 = int.Parse(f);     // int.Parse(string)olmalıdır.dikkat
            // int g7 = Convert.parse(f); //yanlış kullanım dikkat
            // int g8 = f.ToInt32();     //yanlış kullanım dikkat 
            label1.Text = g5.ToString();//digerlerini siz yapın...

            int z1; z1 = 3;
            int z2 = 3;//şeklindede yazılabilir;
            //int z3 = 3.0; //HATA:Ondalıklı sayıları tamsayılara atayamayız.
            int z4 = (int)3.0;//3.0 rakamını önce 3e çevirdik,(int)komutuyla sonra atadık. 
            int z5 = Convert.ToInt32(3);//yazmak etik değildir,çalışır ama gerek yok 
            //int z6 = Int32.Parse(3);//HATA:
            int z7 = Int32.Parse("3");//böyle olur
            label2.Text = z7.ToString();//digerlerini siz yapın...       

            int a = 3, b = 4, c = 0, d = 0;
            double u;
            byte k1, k2;
            string m, n, y, t, r;
            y = "KSBU" + " " + "BM" + a.ToString();
            y = "KSBU" + " " + "BM" + a;
            label3.Text = y;//digerlerini siz yapın... 

            m = "5" + "6";
            m = 5.ToString() + 6.ToString();
            n = 5.ToString() + 6.ToString() + "6".ToString() + "BP".ToString() + "KSBU";
            label5.Text = m.ToString();//digerlerini siz yapın...        

            b = 5 + 6;  //int=int+int
            u = 5 + 6;  //double=int+int 
            u = (int)5.0 + 6;//double=int+int     
            u = 5.0 + 6; //double=double+int
            u = 5.0 + 6.0; //double=double+double
            k1 = 5 + 6;//byte=int+int
            //k2 = 300 + 6;//HATA:byte=int+int
            // a = 5.0 + 6; //HATA:int=double+int
            // m = 5 + 6;  ///HATA:string=int+int
            label4.Text = k1.ToString();//digerlerini siz yapın...       

            int z;
            float v1, v2;
            z = (int)4.8;
            v1 = 4.8f;
            v2 = (float)4.8;
            int aa = Convert.ToInt32(3.5);
            int bb = (int)3.5;
            int cc = (int)3.5 + (int)3.5; //6
            int dd = (int)(3.5 + 3.5); //7
            label6.Text = dd.ToString();//digerlerini siz yapın...       
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*
            Console.WriteLine(4 / 3);   //1                 >> int/int    >> int
            Console.WriteLine(4 / 3.0); //1,33333333333333  >> int/double >> double //15basamak 
            Console.WriteLine(4 / 3.0D);//1,33333333333333				  int/double
            Console.WriteLine(4 / 3.0f);//1,333333						  int/float 
            Console.WriteLine(4 / 3.0M);//1,3333333333333333333333333333  int/decimal//28basamak

            Console.WriteLine((int)(4 / 3));//1 >> int/int
            Console.WriteLine((int)(4 / 3.0M));//1 >> int/decimal
            */
            label1.Text = (4/3.0D).ToString();//digerlerini siz yapın...
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int c1, c2;
            double c3,c4,c5,c6,c7,c8;
            //c1 = ((3 + 5 * 2) + 3.0 + (3.5 + 2.1));
            c2 = (int)((3 + 5 * 2) + 3.0 + (3.5 + 2.1));
            c3 = ((3 + 5 * 2) + 3.0 + (3.5 + 2.1));
            c4 = (60*(40/100))+(90 * (60 / 100));//dikkat
            c5 = 40 / 100;//dikkat
            c6 = 60 * 40 / 100;
            c7 = 60 * 0.4;
            c8 = 60 * 0.443;

            //textBox1.Text = c2.ToString();
            label1.Text = c8.ToString();//digerlerini siz yapın...
        }
        private void button6_Click(object sender, EventArgs e)//math1
        {
            int d1 = (int)Math.Ceiling(3.58);     //yuvarlama yapar double geri dondurur
            double d2 = Math.Floor(3.58);       //yuvarlama yapar double geri dondurur
            double d3 = Math.Round(3.4854564, 2);

            textBox1.Text = d1.ToString();
            textBox2.Text = d2.ToString();
            textBox3.Text = d3.ToString();

            label1.Text = d3.ToString();//digerlerini siz yapın...
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int d1 = (int)Math.Ceiling(3.58);     //yuvarlama yapar double geri dondurur
            double d2 = Math.Floor(3.58);       //yuvarlama yapar double geri dondurur
            double d3 = Math.Round(3.4854564, 2);
            double a = Math.Sqrt(16);
            int c = (int)(Math.Sqrt(16));

            label1.Text = d3.ToString();//digerlerini siz yapın...
            /*
			console uygulamaları:
            Console.WriteLine(Math.Abs(5 / 2)); //2 tamsayi()
            Console.WriteLine(Math.Abs(-5));    //5 mutlak
            Console.WriteLine(Math.Sqrt(4));  //2 karakök     

            Console.WriteLine(Math.Abs(-10));
            Console.WriteLine(Math.Ceiling(2.6));
            Console.WriteLine(Math.Floor(2.5));
            Console.WriteLine(Math.Round(2.6, 2));

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Max(2, 3));
            Console.WriteLine(Math.Min(2, 3));
            */
            label2.Text = Math.Ceiling(2.6).ToString();//digerlerini siz yapın...
        }
        private void button9_Click(object sender, EventArgs e)//degiskenkural
        {
            //değişken isimleri tanımlama kuralları
            string A = "ilkharfi veya tamami sayi olamaz"; //int 1a, int 25ali, int 123;
            string AA = "ismin icinde bosluk / TAB / enter olamaz";//int ali kaya;
            string AAA = "oporatör >>  =+-*/?<>.;,  olamaz ( işlem karakteri)";
            string AAAA = "Türkçe karakter kullanabilirsiniz."; //int ayşe//üçşğ
            string AAAAA = "alti cizgi kullanabilirsiniz.";//int ali_kaya;
            string AAAAAA = "isim uzunlugu 511 karakterden buyuk olamaz";//int a1,a2,a3,b1,b3,b3
            string AAAAAAA = "C#  keyword kelimeleri olamaz";//if,while,main,for,string,int

            string String;
            string stRing;
            //string string;//kullanilmaz
            string string1;

            string s = "ksbu";
            string string2 = "ksbu";
            int a = 1, A = 2;

            string AAAAAAAA = "buyuk kucuk harfe duyarlidir  >>  A <> a ";
            int b = 3, B = 5;

            string ss = "String >> metin depolar, kapasitesi: sınırsız harf , RAM dolana kadar";
            string sss = "char >> 1 harf depolar , kapasitesi: 0 - 65535 ";

            string m = "kkk", n = "545", k = "610";
            m = "ali";
            n = "kaya";
            k = m + n;
            label1.Text = k.ToString();//digerlerini siz yapın...
        }
        static void degiskenler()
        {
	//There are 3 types of data types in C# which are categorized below:
			//Value Data Types
			//Reference Data Types
			//Pointer Data Types
     
      //sbyte 	System.SByte	Signed 8-bit tamsayı ( -128 To +127 )-işaretli -1byte
      //byte 	System.Byte 	Unsigned 8-bit tamsayı ( 0 To 255 )	-işaretsiz -1byte
      //short 	System.Int16	Signed 16-bit tamsayı (-32768 To 32767)	-2byte
      //ushort 	System.UInt16 	Unsigned 16-bit tamsayı(0 To 65535)	    -2byte
      //int 	System.Int32 	Signed 32-bit tamsayı	(± 2.147.483.648) -4byte (± 2e31)
      //uint 	System.UInt32 	Unsigned 32-bit tamsayı	(+ 4.294.967.295) -4byte (+ 2*2e31)
      //long 	System.Int64 	Signed 64-bit tamsayı	(± 1*10e20)   -8byte (± 2e63)
      //ulong 	System.UInt64 	Unsigned 64-bit tamsayı	(+ 2*10e20)	  -8byte (+ 2*2e63)

      //float 	System.Single 	32-bit single-precision floating point number-ondalıklı sayı (± 3.4*10e38) -4byte
                                //basamak hassasiyeti ~6-9
      //double 	System.Double 	64-bit double-precision floating point number-ondalıklı sayı (± 1.7*10e308)-8byte
                                //basamak hassasiyeti, ~15-17 
      //decimal System.Decimal 	signed 128-bit precise decimal values-ondalıklı sayı, -16 byte
                                //(±1.0*10e-28 - ±7.9*10e28)
                                //basamak hassasiyeti, ~28-29 
                                //Hem tam sayı hem de ondalık sayı barındırabilen tiptir

      //char 	System.Char 	A single 16-bit Unicode character - 2 byte
      //string 	System.String 	Represents a set of Unicode characters-Limited by system memory
	  							//2 bytes per character

      //bool    System.Boolean 	1-bit mantıksal sayı -true/false

      //object 	object 			Genel- Any type can be stored
      //var 	var	 			Genel- Any type can be stored
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
