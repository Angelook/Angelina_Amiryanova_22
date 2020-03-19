using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Картинка 1")
                pictureBox1.BackgroundImage = imageList1.Images[0];

            if (comboBox1.Text == "Картинка 2")
                pictureBox1.BackgroundImage = imageList1.Images[1];
            if (comboBox1.Text == "Картинка 3")
                pictureBox1.BackgroundImage = imageList1.Images[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = pictureBox1.BackgroundImage;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Visible = false;
            
        }
    }
}
