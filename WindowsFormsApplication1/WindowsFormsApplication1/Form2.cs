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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            оборудованиеTableAdapter.Insert(placeHolderTextBox1.Text, comboBox1.Text,dateTimePicker1.Value);
            оборудованиеTableAdapter.Update(serviceDataSet.Оборудование);
            оборудованиеTableAdapter.Fill(serviceDataSet.Оборудование);
        }
    }
}
