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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.teplica3DataSet.Manager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Emploee". При необходимости она может быть перемещена или удалена.
            this.emploeeTableAdapter.Fill(this.teplica3DataSet.Emploee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Job". При необходимости она может быть перемещена или удалена.
            this.jobTableAdapter.Fill(this.teplica3DataSet.Job);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.Area". При необходимости она может быть перемещена или удалена.
            this.areaTableAdapter.Fill(this.teplica3DataSet.Area);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable5". При необходимости она может быть перемещена или удалена.
            this.dataTable5TableAdapter.Fill(this.teplica3DataSet.DataTable5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable4". При необходимости она может быть перемещена или удалена.
           // this.dataTable4TableAdapter.Fill(this.teplica3DataSet.DataTable4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teplica3DataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.teplica3DataSet.DataTable3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.dataTable5TableAdapter.Fill(this.teplica3DataSet.DataTable5, ((int)(System.Convert.ChangeType(empIDToolStripTextBox.Text, typeof(int)))));
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
               // this.dataTable3TableAdapter.FillBy(this.teplica3DataSet.DataTable3, ((int)(System.Convert.ChangeType(empIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataTable3TableAdapter.FillBy(teplica3DataSet.DataTable3, ((int)(System.Convert.ChangeType(comboBox1.Text, typeof(int))))); ;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.areaTableAdapter.FillBy(this.teplica3DataSet.Area, areaCultureToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            areaTableAdapter.FillBy(teplica3DataSet.Area, comboBox1.Text);
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
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
            jobTableAdapter.FillBy(teplica3DataSet.Job, comboBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emploeeTableAdapter.FillBy1(teplica3DataSet.Emploee, comboBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            managerTableAdapter.FillBy(teplica3DataSet.Manager, comboBox4.Text);
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

        private void fillToolStripButton2_Click(object sender, EventArgs e)
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

        private void fillToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
