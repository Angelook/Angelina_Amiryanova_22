using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7_1
{
    public partial class Start : Form
    {
        Form1 form1 = new Form1();
        Formprogress_stud formprog = new Formprogress_stud();
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formprog.Show();
        }
    }
}
