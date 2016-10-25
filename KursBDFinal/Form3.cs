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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void emploeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emploeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Emploee". При необходимости она может быть перемещена или удалена.
            this.emploeeTableAdapter.Fill(this.teplica3DataSet.Emploee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff2 = new Form2();
            Form5 ff5 = new Form5();
            emploeeTableAdapter.InsertQuery(Convert.ToInt32(empIDTextBox.Text),empNameTextBox.Text, empSNameTextBox.Text,empProfTextBox.Text,Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
