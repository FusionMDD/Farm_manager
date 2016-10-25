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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            managerTableAdapter.InsertQuery(Convert.ToInt32(iDManagerTextBox1.Text), posadaTextBox.Text, firstNameTextBox.Text, secondNameTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            areaTableAdapter.InsertQuery(Convert.ToInt32(areaIDTextBox.Text), areaNameTextBox.Text, comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ff2 = new Form2();
            Form5 ff5 = new Form5();
            emploeeTableAdapter.InsertQuery(Convert.ToInt32(empIDTextBox.Text), empNameTextBox.Text, empSNameTextBox.Text, empProfTextBox.Text, Convert.ToInt32(comboBox3.Text), Convert.ToInt32(comboBox4.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jobTableAdapter.InsertQuery(Convert.ToInt32(jobIDTextBox.Text), jobNameTextBox.Text, Convert.ToInt32(timeTextBox.Text), Convert.ToInt32(comboBox5.Text));
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

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
