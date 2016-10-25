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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teplica3DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.teplica3DataSet.Job);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jobTableAdapter.InsertQuery(Convert.ToInt32(jobIDTextBox.Text), jobNameTextBox.Text, Convert.ToInt32(timeTextBox.Text), Convert.ToInt32(areaIDTextBox.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void button7_Click(object sender, EventArgs e)
        {

            comboBox1.Text =Convert.ToString( jobTableAdapter.ScalarQuery(Convert.ToInt32(comboBox1.Text)));
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.FillBy(this.teplica3DataSet.Job, jobNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.jobTableAdapter.FillBy1(this.teplica3DataSet.Job, ((int)(System.Convert.ChangeType(fromToolStripTextBox.Text, typeof(int)))), ((int)(System.Convert.ChangeType(toToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fillBy1ToolStrip.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fillBy1ToolStrip.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fillByToolStrip.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            fillBy1ToolStrip.Visible = false;
        }
    }
}
