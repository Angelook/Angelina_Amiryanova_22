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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void composition_salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.composition_salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookssDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookssDataSet.composition_sales". При необходимости она может быть перемещена или удалена.
            this.composition_salesTableAdapter.Fill(this.bookssDataSet.composition_sales);

        }
    }
}
