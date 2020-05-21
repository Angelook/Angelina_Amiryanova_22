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
    
    public partial class Form2 : Form
    {
        messEntities ms = new messEntities();
        mess_s mes = new mess_s();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mes.Add_f(textBox2.Text, textBox3.Text);
            mes.Add_w(textBox1.Text, textBox4.Text);
            mes.Add_t(textBox5.Text);
            MessageBox.Show("Ваша сообщение отправлено");
            ms.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
