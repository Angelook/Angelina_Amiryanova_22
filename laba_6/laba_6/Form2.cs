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
    public partial class Form2 : Form
    {
        Users us = new Users();      
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                us.Edit(textBox1.Text);
                MessageBox.Show("Пароль изменен");
                Application.Exit();
            }
            else MessageBox.Show("Заполните поле для изменения пароли");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
