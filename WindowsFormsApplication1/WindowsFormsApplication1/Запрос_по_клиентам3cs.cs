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
    public partial class Запрос_по_клиентам3cs : Form
    {
        public Запрос_по_клиентам3cs()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Запрос_по_клиентам3cs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.serviceDataSet.Клиенты);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.клиентыTableAdapter.FillBy(this.serviceDataSet.Клиенты, checkBox1.Checked);
        }
    }
}
