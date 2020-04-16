using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kr_vp_1
{
    public partial class Form1 : Form
    {
        

        string login, password;
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login1 = "admin";
            string password1 = "password";
            if (login == login1 && password == password1)
            {
                form2.Show();
            }
            else
                MessageBox.Show("Ошибка авторизации!");

        }
    }
}
