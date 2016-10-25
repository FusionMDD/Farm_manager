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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Emploee". При необходимости она может быть перемещена или удалена.
            this.emploeeTableAdapter.Fill(this.teplica3DataSet.Emploee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.teplica3DataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.areaTableAdapter.FillBy1(this.teplica3DataSet.Area, ((int)(System.Convert.ChangeType(fromToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(toToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.emploeeTableAdapter.FillBy2(this.teplica3DataSet.Emploee, ((int)(System.Convert.ChangeType(fromToolStripTextBox1.Text, typeof(int)))), ((int)(System.Convert.ChangeType(toToolStripTextBox1.Text, typeof(int)))));
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
                this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.FillBy1(this.teplica3DataSet.Job, ((int)(System.Convert.ChangeType(fromToolStripTextBox2.Text, typeof(int)))), ((int)(System.Convert.ChangeType(toToolStripTextBox2.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.managerTableAdapter.FillBy1(this.teplica3DataSet.Manager, ((int)(System.Convert.ChangeType(fromToolStripTextBox3.Text, typeof(int)))), ((int)(System.Convert.ChangeType(toToolStripTextBox3.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
