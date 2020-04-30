using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 с = new Form4();
            с.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
