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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Emploee". При необходимости она может быть перемещена или удалена.
            this.emploeeTableAdapter.Fill(this.teplica3DataSet.Emploee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.areaTableAdapter.Fill(this.teplica3DataSet.Area);
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
                this.emploeeTableAdapter.Fill(this.teplica3DataSet.Emploee);
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

        private void fillToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            
            this.emploeeTableAdapter.Update(teplica3DataSet.Emploee);
        }

        private void сохранитьToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);
        }

        private void сохранитьToolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managerTableAdapter.Update(teplica3DataSet.Manager);
        }

        private void areaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            emploeeTableAdapter.Update(teplica3DataSet.Emploee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jobTableAdapter.Update(teplica3DataSet.Job);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            areaTableAdapter.Update(teplica3DataSet.Area);
        }
    }
}
