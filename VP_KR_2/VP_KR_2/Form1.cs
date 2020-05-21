using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_KR_2
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = textBox1.Text.ToUpper();
            textBox1.Select(textBox1.Text.Length, 0);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
                textBox2.Text = textBox2.Text.ToUpper();
            textBox2.Select(textBox2.Text.Length, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox3.Text != "") && (textBox2.Text != "")
                   && (textBox4.Text != ""))
            {
                f2.textBox1.Text = textBox2.Text.ToString();
                f2.textBox5.Text = textBox5.Text.ToString();
                f2.textBox2.Text = textBox1.Text.ToString();
                f2.textBox3.Text = textBox3.Text.ToString();
                f2.textBox4.Text = textBox4.Text.ToString();
                if (radioButton1.Checked == true)
                {
                    f2.pictureBox1.Image = pictureBox1.Image;
                }
                if (radioButton2.Checked == true)
                {
                    f2.pictureBox1.Image = pictureBox2.Image;
                }
                if (radioButton3.Checked == true)
                {
                    f2.pictureBox1.Image = pictureBox3.Image;
                }
                f2.ShowDialog();
            }else MessageBox.Show("Заполните все поля");
        }
    }
}
