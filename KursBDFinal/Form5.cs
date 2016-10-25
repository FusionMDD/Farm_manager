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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void managerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.managerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerTableAdapter.InsertQuery(Convert.ToInt32(iDManagerTextBox.Text), posadaTextBox.Text, firstNameTextBox.Text, secondNameTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.managerTableAdapter.FillBy(this.teplica3DataSet.Manager, secondNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            managerTableAdapter.FillBy( teplica3DataSet.Manager,comboBox1.Text);
        }
    }
}
