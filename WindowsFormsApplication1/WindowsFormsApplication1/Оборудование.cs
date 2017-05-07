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
    public partial class Оборудование : Form
    {
        public Оборудование()
        {
            InitializeComponent();
        }

        private void оборудованиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Outfit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Тип_оборудования". При необходимости она может быть перемещена или удалена.
            this.тип_оборудованияTableAdapter.Fill(this.serviceDataSet.Тип_оборудования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Тип_оборудования frm = new Тип_оборудования(); frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Оборудование frm = new Оборудование();
            this.Size = new Size(472, 551);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            оборудованиеBindingSource.RemoveCurrent();

        }

       
        

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            оборудованиеTableAdapter.InsertQuery(placeHolderTextBox1.Text, comboBox1.Text, dateTimePicker1.Value);
            оборудованиеTableAdapter.Update(serviceDataSet.Оборудование);
            оборудованиеTableAdapter.Fill(serviceDataSet.Оборудование);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Оборудование frm = new Оборудование();
            this.Size = new Size(472, 365);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           оборудованиеBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String NameField = " ";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    NameField = "Тип_оборудования";
                    break;
                

            }
            оборудованиеBindingSource.Filter = NameField + " like '" + placeHolderTextBox2.Text + "%'";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        
    }
}
