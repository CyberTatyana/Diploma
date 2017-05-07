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
    public partial class Главное_меню : Form
    {
        public Главное_меню()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          Сотрудники frm = new Сотрудники(); frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              Клиенты frm = new Клиенты(); frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Оборудование frm = new Оборудование(); frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Ремонт frm = new Ремонт(); frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ремонт_оборудования frm = new Ремонт_оборудования(); frm.Show();
        }

        private void Главная_Load(object sender, EventArgs e)
        {

        }
    }
    }

