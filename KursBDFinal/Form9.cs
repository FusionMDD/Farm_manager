using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursBDFinal
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable6". При необходимости она может быть перемещена или удалена.
            this.dataTable6TableAdapter.Fill(this.teplica3DataSet.DataTable6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.teplica3DataSet.DataTable3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable5". При необходимости она может быть перемещена или удалена.
            //this.dataTable5TableAdapter.Fill(this.teplica3DataSet.DataTable5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable4". При необходимости она может быть перемещена или удалена.
           // this.dataTable4TableAdapter.Fill(this.teplica3DataSet.DataTable4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable4". При необходимости она может быть перемещена или удалена.
           // this.dataTable4TableAdapter.Fill(this.teplica3DataSet.DataTable4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.teplica3DataSet.DataTable3);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable3TableAdapter.Fill(this.teplica3DataSet.DataTable3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable6TableAdapter.Fill(this.teplica3DataSet.DataTable6);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
