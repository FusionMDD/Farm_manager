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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void areaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);

        }

        private void areaCultureLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            areaTableAdapter.InsertQuery(Convert.ToInt32(areaIDTextBox.Text), areaNameTextBox.Text,comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.areaTableAdapter.FillBy(this.teplica3DataSet.Area, areaCultureToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = false;
        }

        private void search3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.areaTableAdapter.Search3(this.teplica3DataSet.Area, areaNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            search3ToolStrip.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            search3ToolStrip.Visible = false;
        }

        
    }
}
