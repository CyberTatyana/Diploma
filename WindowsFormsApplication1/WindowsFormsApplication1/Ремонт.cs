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
    public partial class Ремонт : Form
    {
        public Ремонт()
        {
            InitializeComponent();
        }

        private void ремонтBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Repairs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Ремонт". При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.serviceDataSet.Ремонт);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ремонтBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ремонтTableAdapter.InsertQuery(placeHolderTextBox1.Text);
            ремонтTableAdapter.Update(serviceDataSet.Ремонт);
            ремонтTableAdapter.Fill(serviceDataSet.Ремонт);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Ремонт frm = new Ремонт();
            this.Size = new Size(281, 372);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Ремонт frm = new Ремонт();
            this.Size = new Size(281, 252);
        }
    }
}
