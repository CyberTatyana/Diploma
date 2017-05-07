using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ремонт_оборудования : Form
    {
        public Ремонт_оборудования()
        {
            InitializeComponent();
        }

        private void ремонт_оборудованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонт_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Repair_of_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.serviceDataSet.Ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Ремонт_оборудования". При необходимости она может быть перемещена или удалена.
            this.ремонт_оборудованияTableAdapter.Fill(this.serviceDataSet.Ремонт_оборудования);

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонт_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ремонт_оборудованияBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         ремонт_оборудованияBindingSource.AddNew();
        }
    }
}
