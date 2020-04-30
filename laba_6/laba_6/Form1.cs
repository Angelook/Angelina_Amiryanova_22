using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        User u = new User();

        private void button1_Click(object sender, EventArgs e)
        {
            if (u.Check(textBox1.Text, textBox2.Text) != "Error")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Text = u.Check(textBox1.Text, textBox2.Text);
                f2.Show();
            }
            else MessageBox.Show("Логин и пароль введены неверно");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
