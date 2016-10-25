namespace KursBDFinal
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teplica3DataSet = new KursBDFinal.Teplica3DataSet();
            this.dataTable3TableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.DataTable3TableAdapter();
            this.tableAdapterManager = new KursBDFinal.Teplica3DataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4TableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.DataTable4TableAdapter();
            this.dataTable4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaTableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.AreaTableAdapter();
            this.dataTable3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataTable3DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataTable6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable6TableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.DataTable6TableAdapter();
            this.dataTable6DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6DataGridView)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.teplica3DataSet;
            // 
            // teplica3DataSet
            // 
            this.teplica3DataSet.DataSetName = "Teplica3DataSet";
            this.teplica3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmploeeTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursBDFinal.Teplica3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataSource = this.teplica3DataSet;
            this.dataTable4BindingSource.Position = 0;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable4BindingSource1
            // 
            this.dataTable4BindingSource1.DataSource = this.teplica3DataSet;
            this.dataTable4BindingSource1.Position = 0;
            // 
            // dataTable5BindingSource
            // 
            this.dataTable5BindingSource.DataSource = this.teplica3DataSet;
            this.dataTable5BindingSource.Position = 0;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.dataTable5BindingSource;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable3BindingSource1
            // 
            this.dataTable3BindingSource1.DataMember = "DataTable3";
            this.dataTable3BindingSource1.DataSource = this.dataTable4BindingSource;
            // 
            // dataTable4BindingSource2
            // 
            this.dataTable4BindingSource2.DataSource = this.teplica3DataSet;
            this.dataTable4BindingSource2.Position = 0;
            // 
            // dataTable4BindingSource3
            // 
            this.dataTable4BindingSource3.DataSource = this.teplica3DataSet;
            this.dataTable4BindingSource3.Position = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 295);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fillToolStrip);
            this.tabPage1.Controls.Add(this.dataTable3DataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emploee Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(6, 229);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(62, 25);
            this.fillToolStrip.TabIndex = 4;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.fillToolStripButton.Text = "Refresh";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // dataTable3DataGridView
            // 
            this.dataTable3DataGridView.AutoGenerateColumns = false;
            this.dataTable3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable3DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataTable3DataGridView.DataSource = this.dataTable3BindingSource;
            this.dataTable3DataGridView.Location = new System.Drawing.Point(6, 6);
            this.dataTable3DataGridView.Name = "dataTable3DataGridView";
            this.dataTable3DataGridView.ReadOnly = true;
            this.dataTable3DataGridView.Size = new System.Drawing.Size(655, 220);
            this.dataTable3DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmpID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmpName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmpSName";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmpSName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmpProf";
            this.dataGridViewTextBoxColumn4.HeaderText = "EmpProf";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AreaName";
            this.dataGridViewTextBoxColumn5.HeaderText = "AreaName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AreaCulture";
            this.dataGridViewTextBoxColumn6.HeaderText = "AreaCulture";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn7.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SecondName";
            this.dataGridViewTextBoxColumn8.HeaderText = "SecondName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.fillToolStrip1);
            this.tabPage2.Controls.Add(this.dataTable6DataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Area Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataTable6BindingSource
            // 
            this.dataTable6BindingSource.DataMember = "DataTable6";
            this.dataTable6BindingSource.DataSource = this.teplica3DataSet;
            // 
            // dataTable6TableAdapter
            // 
            this.dataTable6TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable6DataGridView
            // 
            this.dataTable6DataGridView.AutoGenerateColumns = false;
            this.dataTable6DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable6DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataTable6DataGridView.DataSource = this.dataTable6BindingSource;
            this.dataTable6DataGridView.Location = new System.Drawing.Point(6, 3);
            this.dataTable6DataGridView.Name = "dataTable6DataGridView";
            this.dataTable6DataGridView.Size = new System.Drawing.Size(444, 220);
            this.dataTable6DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AreaName";
            this.dataGridViewTextBoxColumn9.HeaderText = "AreaName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AreaCulture";
            this.dataGridViewTextBoxColumn10.HeaderText = "AreaCulture";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "JobName";
            this.dataGridViewTextBoxColumn11.HeaderText = "JobName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn12.HeaderText = "Time";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(6, 226);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(62, 25);
            this.fillToolStrip1.TabIndex = 4;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(50, 22);
            this.fillToolStripButton1.Text = "Refresh";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 376);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Name = "Form9";
            this.Text = "View";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3DataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable6DataGridView)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Teplica3DataSet teplica3DataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private Teplica3DataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private Teplica3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private Teplica3DataSetTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.BindingSource dataTable4BindingSource1;
        private System.Windows.Forms.BindingSource dataTable5BindingSource;
      //  private Teplica3DataSetTableAdapters.DataTable5TableAdapter dataTable5TableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private Teplica3DataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource dataTable3BindingSource1;
        private System.Windows.Forms.BindingSource dataTable4BindingSource2;
        private System.Windows.Forms.BindingSource dataTable4BindingSource3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataTable3DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource dataTable6BindingSource;
        private Teplica3DataSetTableAdapters.DataTable6TableAdapter dataTable6TableAdapter;
        private System.Windows.Forms.DataGridView dataTable6DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
    }
}