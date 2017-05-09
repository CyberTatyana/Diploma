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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // chart1.Printing.PrintPreview();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.serviceDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.serviceDataSet.Заказы);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string name = comboBox1.Text;
            //заказыTableAdapter.FillBy(serviceDataSet.Заказы, name);
            заказыTableAdapter.FillBy2(serviceDataSet.Заказы, comboBox1.Text);
        }

    }
}
