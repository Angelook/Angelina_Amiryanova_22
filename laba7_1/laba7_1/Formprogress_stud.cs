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
using NPOI.XSSF.UserModel;

namespace laba7_1
{
    public partial class Formprogress_stud : Form
    {
        public demoeEntities db = new demoeEntities();
        public List<progress> studentsprog;
        public Formprogress_stud()
        {
            InitializeComponent();
            studentsprog = (from prog in db.progress
                            select prog).ToList();

            var query1 = (from prog in db.progress
                          join sub in db.subjects on prog.code_subject equals sub.code_subject
                          join lec in db.lectors on prog.code_lector equals lec.code_lector
                          join s in db.students on prog.code_stud equals s.code_stud
                          orderby prog.code_stud
                          select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, lec.name_lector }).ToList();

            dataGridView1.DataSource = query1;
            dataGridView1.ReadOnly = true;
            // dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Фамилия";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Название предмета";
            dataGridView1.Columns[3].HeaderText = "Дата экзамена";
            dataGridView1.Columns[4].HeaderText = "Оценка";
            dataGridView1.Columns[5].HeaderText = "Имя преподавателя";
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query1 = (from prog in db.progress
                          join sub in db.subjects on prog.code_subject equals sub.code_subject
                          join lec in db.lectors on prog.code_lector equals lec.code_lector
                          join s in db.students on prog.code_stud equals s.code_stud
                          orderby prog.code_stud
                          select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, lec.name_lector }).ToList();

            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        dataGridView1.DataSource = query1.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 1:
                        dataGridView1.DataSource = query1.Where(p => p.name.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 2:
                        dataGridView1.DataSource = query1.Where(p => p.name_subject.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 3:
                        dataGridView1.DataSource = query1.Where(p => p.name_lector.ToString() == textBox1.Text.ToString()).ToList(); break;
                }
            }
            else
            {
                dataGridView1.DataSource = query1;
            }
            dataGridView1.Update();
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e) //удаление
        {
            DialogResult result;
            result = MessageBox.Show("Вы хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                List<progress> query1 = (from prog in db.progress
                                         select prog).ToList();

                if (dataGridView1.SelectedCells.Count == 1)
                {

                    progress item = query1.First(w => w.code_subject.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value.ToString());
                    db.progress.Remove(item);
                    db.SaveChanges();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                FormAddProgress addSt = new FormAddProgress();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";

            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет";



            var query1 = (from prog in db.progress
                          join sub in db.subjects on prog.code_subject equals sub.code_subject
                          join lec in db.lectors on prog.code_lector equals lec.code_lector
                          join s in db.students on prog.code_stud equals s.code_stud
                          orderby prog.code_stud
                          select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, lec.name_lector }).ToList();
            var template2 = new MemoryStream(Properties.Resources.template2, true);

            var workbook = new XSSFWorkbook(template2);
            var sheet1 = workbook.GetSheet("Лист1");

            int row = 11;

            foreach (var item in query1.OrderBy(o => o.surname))
            {
                var rowInsert = sheet1.CreateRow(row);
                rowInsert.CreateCell(1).SetCellValue(item.surname);
                rowInsert.CreateCell(2).SetCellValue(item.name);
                rowInsert.CreateCell(3).SetCellValue(item.name_subject);
                rowInsert.CreateCell(4).SetCellValue((item.date_exam));
                rowInsert.CreateCell(5).SetCellValue((double)item.estimate);
                rowInsert.CreateCell(6).SetCellValue(item.name_lector);

                row++;
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);


                workbook.Write(file);

            }






        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

