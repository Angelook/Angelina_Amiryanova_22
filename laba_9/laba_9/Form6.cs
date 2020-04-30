using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookssDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookssDataSet.books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.bookssDataSet.books);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn Col = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex)
            {
                case 0: Col = dataGridViewTextBoxColumn2; break;
                case 1: Col = dataGridViewTextBoxColumn4; break;
            }
            if (radioButton1.Checked) { booksDataGridView.Sort(Col, ListSortDirection.Ascending); }
            else
            { booksDataGridView.Sort(Col, ListSortDirection.Descending); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "Title_book='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (booksDataGridView.RowCount - 1); i++)
            {
                for (int j = 0; j < (booksDataGridView.ColumnCount); j++)
                {
                    DataGridViewCell cell = booksDataGridView.Rows[i].Cells[j];
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < (booksDataGridView.RowCount - 1); i++)
            {
                for (int j = 0; j < (booksDataGridView.ColumnCount); j++)
                {
                    DataGridViewCell cell = booksDataGridView.Rows[i].Cells[j];
                    if (cell.Value.Equals(textBox1.Text))
                    {
                        cell.Style.BackColor = Color.AliceBlue;
                        cell.Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
