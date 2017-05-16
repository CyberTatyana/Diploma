using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Access;
// using Excel = Microsoft.Office.Interop.Excel;
// using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1
{
    public partial class Клиенты : System.Windows.Forms.Form
    {
        public Клиенты()
        {
            InitializeComponent();
            клиентыDataGridView.SelectionChanged += new EventHandler(
                this.клиентыDataGridView_change);
        }

        private void клиентыDataGridView_change(object sender, EventArgs e)
        {
            if (клиентыDataGridView.CurrentRow != null)
            {
                textBox1.Text = клиентыDataGridView.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = клиентыDataGridView.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = клиентыDataGridView.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = клиентыDataGridView.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = клиентыDataGridView.CurrentRow.Cells[4].Value.ToString();
                if (!string.IsNullOrEmpty((клиентыDataGridView.CurrentRow.Cells[5].Value.ToString())))
                {
                    checkBox2.Checked = (bool)клиентыDataGridView.CurrentRow.Cells[5].Value;
                } else
                {
                    checkBox2.Checked = false;
                }
                }
            

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
            placeHolderTextBox6.Text = "";
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



        private static void ExportQuery(string databaseLocation, string queryNameToExport, string locationToExportTo)
        {
            var application = new Microsoft.Office.Interop.Access.Application();
            application.OpenCurrentDatabase(databaseLocation);
            application.DoCmd.TransferSpreadsheet(AcDataTransferType.acExport, AcSpreadSheetType.acSpreadsheetTypeExcel12,
                                                  queryNameToExport, locationToExportTo, true);
            application.CloseCurrentDatabase();
            application.Quit();
            Marshal.ReleaseComObject(application);
        }
    
        private void button10_Click(object sender, EventArgs e)
        {
          
            ExportQuery("\blah\blah.accdb", "myQuery", @"C:\blah\blah.xlsx");
        }
    }
}
