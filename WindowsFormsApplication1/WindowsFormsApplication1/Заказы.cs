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
    public partial class Заказы : Form
    {
        public Заказы()
        {
            InitializeComponent();
        }

        private void заказыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Заказы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Ремонт_оборудования". При необходимости она может быть перемещена или удалена.
            this.ремонт_оборудованияTableAdapter.Fill(this.serviceDataSet.Ремонт_оборудования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.serviceDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Тип_оборудования". При необходимости она может быть перемещена или удалена.
            this.тип_оборудованияTableAdapter.Fill(this.serviceDataSet.Тип_оборудования);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.serviceDataSet.Ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.serviceDataSet.Оборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.serviceDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.serviceDataSet.Заказы);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ремонт_оборудованияDataGridView.Columns["dataGridViewTextBoxColumn12"].Visible = false;
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ремонт_оборудованияDataGridView.Visible = false;
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            заказыTableAdapter.FillBy(serviceDataSet.Заказы, name);
        }

        

       

       

        private void button9_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Заказы frm = new Заказы ();
            this.Size = new Size(976, 679);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Оборудование frm = new Оборудование(); frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int pr;
            if (textBox2.Text == "") textBox2.Text = "0";
            pr = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text);
            textBox3.Text = Convert.ToString(pr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                c = Convert.ToInt32(textBox3.Text);
                заказыTableAdapter.InsertQuery(comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, a, b, c);
                заказыTableAdapter.Update(serviceDataSet.Заказы);
                string name = comboBox1.Text;
                заказыTableAdapter.FillBy(serviceDataSet.Заказы, name);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        

        

        

        

       

        

        
    }
}
