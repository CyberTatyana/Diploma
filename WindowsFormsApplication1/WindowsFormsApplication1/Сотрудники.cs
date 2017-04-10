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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
            сотрудникиDataGridView.SelectionChanged += new EventHandler(
            this.сотрудникиDataGridView_change);
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }
        private void сотрудникиDataGridView_change(object sender, EventArgs e)
        {
            
                if (сотрудникиDataGridView.CurrentRow != null)
            {
                textBox1.Text = сотрудникиDataGridView.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = сотрудникиDataGridView.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = сотрудникиDataGridView.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = сотрудникиDataGridView.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = сотрудникиDataGridView.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.serviceDataSet1.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.serviceDataSet.Сотрудники);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Сотрудники frm = new Сотрудники();
            this.Size = new Size(600, 632);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

       
                       

        private void dddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.AddNew();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.RemoveCurrent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

      
        private void button6_Click(object sender, EventArgs e)
        {
            сотрудникиTableAdapter.InsertQuery(placeHolderTextBox1.Text, placeHolderTextBox2.Text, placeHolderTextBox3.Text, placeHolderTextBox4.Text, placeHolderTextBox5.Text);
            сотрудникиTableAdapter.Update(serviceDataSet.Сотрудники);
            сотрудникиTableAdapter.Fill(serviceDataSet.Сотрудники);
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Сотрудники frm = new Сотрудники();
            this.Size = new Size(600, 632);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Сотрудники frm = new Сотрудники();
            this.Size = new Size(595, 361);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Сотрудники frm = new Сотрудники();
            this.Size = new Size(595, 361);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Filter = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String NameField = " ";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    NameField = "Должность";
                    break;


            }
            сотрудникиBindingSource.Filter = NameField + " like '" + placeHolderTextBox6.Text + "%'";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String NameField = " ";
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    NameField = "ФИО";
                    break;
                             
                case 1:
                    NameField = "Номер_паспорта";
                    break;
                case 2:
                    NameField = "Телефон";
                    break;

            }
            int index = 0;
            index = сотрудникиBindingSource.Find(NameField, placeHolderTextBox7.Text);
            if (index > -1)
                сотрудникиBindingSource.Position = index;
            else
                MessageBox.Show("Ошибка поиска");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = сотрудникиDataGridView.CurrentRow; 
            string value = row.Cells[0].Value.ToString() ?? string.Empty;
            MessageBox.Show(value);
            сотрудникиTableAdapter.UpdateQuery1(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, value);
            сотрудникиTableAdapter.Update(serviceDataSet.Сотрудники);
            сотрудникиTableAdapter.Fill(serviceDataSet.Сотрудники);
        }

        private void сотрудникиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
