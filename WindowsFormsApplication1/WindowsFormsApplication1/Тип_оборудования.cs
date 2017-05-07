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
    public partial class Тип_оборудования : Form
    {
        public Тип_оборудования()
        {
            InitializeComponent();
        }

        private void тип_оборудованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);

        }

        private void Type_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Тип_оборудования". При необходимости она может быть перемещена или удалена.
            this.тип_оборудованияTableAdapter.Fill(this.serviceDataSet.Тип_оборудования);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            Тип_оборудования frm = new Тип_оборудования();
            this.Size = new Size(331,373);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тип_оборудованияBindingSource.RemoveCurrent();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            тип_оборудованияTableAdapter.InsertQuery(placeHolderTextBox1.Text);
            тип_оборудованияTableAdapter.Update(serviceDataSet.Тип_оборудования);
            тип_оборудованияTableAdapter.Fill(serviceDataSet.Тип_оборудования);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Тип_оборудования frm = new Тип_оборудования();
            this.Size = new Size(331, 252);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.serviceDataSet);
        }

       
    }
}
