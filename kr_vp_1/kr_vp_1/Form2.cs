using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kr_vp_1
{
    public partial class Form2 : Form
    {
        public cont1Entities db = new cont1Entities();
        public List<s_students> studentsheet;
        public Form2()
        {

            InitializeComponent();
            studentsheet = (from stud in db.s_students
                            select stud).ToList();

            var query = (from stud in studentsheet
                         join g in db.s_in_group on stud.id_group equals g.group_num
                         orderby stud.id_group
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.group_num }).ToList();

            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = (from stud in studentsheet
                         join g in db.s_in_group on stud.id_group equals g.group_num
                         orderby stud.id_group
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.group_num }).ToList();

            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Номер курса";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                FormAddStudent addSt = new FormAddStudent();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
        }
    }
}
