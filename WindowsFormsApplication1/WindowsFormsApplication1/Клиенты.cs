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
    public partial class Клиенты : Form
    {
        public Клиенты()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.serviceDataSet.Клиенты);

        }

        private void placeHolderTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void placeHolderTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            placeHolderTextBox6.Visible = !placeHolderTextBox6.Visible;
            label7.Visible = !label7.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыTableAdapter.InsertQuery(placeHolderTextBox2.Text, placeHolderTextBox3.Text, placeHolderTextBox4.Text, placeHolderTextBox5.Text, placeHolderTextBox6.Text, checkBox1.Checked);
            клиентыTableAdapter.Update(serviceDataSet.Клиенты);
           клиентыTableAdapter.Fill(serviceDataSet.Клиенты);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = клиентыDataGridView.CurrentRow;
            string value = row.Cells[0].Value.ToString() ?? string.Empty;
            MessageBox.Show(value);
            клиентыTableAdapter.UpdateQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, checkBox1.Checked, value);
            клиентыTableAdapter.Update(serviceDataSet.Клиенты);
            клиентыTableAdapter.Fill(serviceDataSet.Клиенты);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Клиенты frm = new Клиенты();
            this.Size = new Size(672, 689);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Клиенты frm = new Клиенты();
            this.Size = new Size(672, 689);
        }

       
    }
}
