using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t1, t2;string y = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            //seçim1
            radioButton1.Text = "RadioButtonList";
            radioButton2.Text = "checkBox";
            radioButton3.Text = "ComboBox";
            radioButton4.Text = "CheckBoxList";
            radioButton5.Text = "ListBox";
            //devamini sen yaz

            radioButton6.Text = "Topla";
            //devamini sen yaz

            checkBox1.Text = "topla";
            checkBox2.Text = "Çıkar";
            //devamini sen yaz

            comboBox1.Items.Add("topla");
            comboBox1.Items.Add("Çıkar");
            // devamini sen yaz
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            checkedListBox1.Items.Add("topla");
            checkedListBox1.Items.Add("Çıkar");
            //devamini sen yaz

            listBox1.Items.Add("topla");
            listBox1.Items.Add("Çıkar");
            //devamini sen yaz

            listBox1.SelectedIndex = -1;

            textBox1.Focus();
        }
        private int hata()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            { MessageBox.Show("hata1,Text'ler bos birakılamaz."); return 0; }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            { MessageBox.Show("hata2,RB'ler bos birakılamaz."); return 0; }
			//.....
            return 1;
        }
        private void button1_Click(object sender, EventArgs e)//hesapla
        {
            if (hata() == 0) { textBox1.Focus(); return; }
            t1 = Convert.ToInt32(textBox1.Text);
            t2 = Convert.ToInt32(textBox2.Text);

            //......
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.NavajoWhite;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
        }
        private void button2_Click(object sender, EventArgs e)//temizle
        {
            checkBox1.Checked = false;checkBox2.Checked = false;
            checkBox3.Checked = false;checkBox4.Checked = false;
            radioButton1.Checked = false; radioButton2.Checked = false;
            radioButton3.Checked = false; radioButton4.Checked = false;
            radioButton5.Checked = false; radioButton6.Checked = false;
            radioButton7.Checked = false; radioButton8.Checked = false;
            radioButton9.Checked = false;
            label1.Text = ""; label2.Text = ""; label3.Text = "";
            label4.Text = ""; label5.Text = ""; label6.Text = "";
            label7.Text = ""; label8.Text = ""; label9.Text = "";
            textBox1.Text = ""; textBox2.Text = "";
            this.BackColor = default(Color);
        }
        private void button3_Click(object sender, EventArgs e)//kapat
        {
            this.Close();
        }
    }
}
