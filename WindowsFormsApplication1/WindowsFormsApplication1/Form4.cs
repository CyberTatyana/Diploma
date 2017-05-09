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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.serviceDataSet.Заказы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыTableAdapter.FillBy1(serviceDataSet.Заказы, dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //printPreviewDialog1.Document = myDocument;
            //printPreviewDialog1.ShowDialog();
        }

        
    }
}
