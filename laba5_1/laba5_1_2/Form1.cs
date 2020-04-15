using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5_1_2
{
    public partial class Form1 : Form
    {
        private int sec=0, min=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "00:00")
            {
                min = Convert.ToInt32(numericUpDown1.Value);
                sec = Convert.ToInt32(numericUpDown1.Value);
            }
            
            groupBox1.Visible = false;

            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Стоп";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {



            if (sec < 10)
                label1.Text = min + ":0" + sec;
            else
            { label1.Text = min + ":" + sec; }
            sec = sec - 1;


            if (sec == -1)
            {
                min = min - 1;
                sec = 59;
            }


            if ((sec == 59) && (min == -1))
            {
                timer1.Enabled = false;
                MessageBox.Show("Заданный интервал времени истек");


            }









        }
    }
}
