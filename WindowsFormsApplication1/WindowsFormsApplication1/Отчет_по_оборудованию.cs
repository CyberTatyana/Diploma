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
    public partial class Отчет_по_оборудованию : Form
    {
        public Отчет_по_оборудованию()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Отчет_по_сотрудникам_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.serviceDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыTableAdapter.FillBy3(serviceDataSet.Заказы, comboBox1.Text);
        }
    }
}
