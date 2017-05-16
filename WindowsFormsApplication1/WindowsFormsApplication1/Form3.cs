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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Запрос_по_клиентам3cs frm = new Запрос_по_клиентам3cs(); frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Отчет_по_оборудованию frm = new Отчет_по_оборудованию(); frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Отчет_по_типу_оборудования frm = new Отчет_по_типу_оборудования(); frm.Show();
        }

        
    }
}
