namespace KursBDFinal
{
    partial class Form3
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
            System.Windows.Forms.Label empIDLabel;
            System.Windows.Forms.Label empNameLabel;
            System.Windows.Forms.Label empSNameLabel;
            System.Windows.Forms.Label empProfLabel;
            System.Windows.Forms.Label iDManagerLabel;
            System.Windows.Forms.Label areaIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.teplica3DataSet = new KursBDFinal.Teplica3DataSet();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emploeeTableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.EmploeeTableAdapter();
            this.tableAdapterManager = new KursBDFinal.Teplica3DataSetTableAdapters.TableAdapterManager();
            this.emploeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.emploeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emploeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.empSNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.empProfTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teplica3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.ManagerTableAdapter();
            this.areaTableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.AreaTableAdapter();
            this.fKEmploeeManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKEmploeeManagerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            empIDLabel = new System.Windows.Forms.Label();
            empNameLabel = new System.Windows.Forms.Label();
            empSNameLabel = new System.Windows.Forms.Label();
            empProfLabel = new System.Windows.Forms.Label();
            iDManagerLabel = new System.Windows.Forms.Label();
            areaIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingNavigator)).BeginInit();
            this.emploeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmploeeManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmploeeManagerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // empIDLabel
            // 
            empIDLabel.AutoSize = true;
            empIDLabel.Location = new System.Drawing.Point(706, 75);
            empIDLabel.Name = "empIDLabel";
            empIDLabel.Size = new System.Drawing.Size(45, 13);
            empIDLabel.TabIndex = 2;
            empIDLabel.Text = "Emp ID:";
            // 
            // empNameLabel
            // 
            empNameLabel.AutoSize = true;
            empNameLabel.Location = new System.Drawing.Point(689, 101);
            empNameLabel.Name = "empNameLabel";
            empNameLabel.Size = new System.Drawing.Size(62, 13);
            empNameLabel.TabIndex = 4;
            empNameLabel.Text = "Emp Name:";
            // 
            // empSNameLabel
            // 
            empSNameLabel.AutoSize = true;
            empSNameLabel.Location = new System.Drawing.Point(682, 127);
            empSNameLabel.Name = "empSNameLabel";
            empSNameLabel.Size = new System.Drawing.Size(69, 13);
            empSNameLabel.TabIndex = 6;
            empSNameLabel.Text = "Emp SName:";
            // 
            // empProfLabel
            // 
            empProfLabel.AutoSize = true;
            empProfLabel.Location = new System.Drawing.Point(698, 153);
            empProfLabel.Name = "empProfLabel";
            empProfLabel.Size = new System.Drawing.Size(53, 13);
            empProfLabel.TabIndex = 8;
            empProfLabel.Text = "Emp Prof:";
            // 
            // iDManagerLabel
            // 
            iDManagerLabel.AutoSize = true;
            iDManagerLabel.Location = new System.Drawing.Point(688, 179);
            iDManagerLabel.Name = "iDManagerLabel";
            iDManagerLabel.Size = new System.Drawing.Size(63, 13);
            iDManagerLabel.TabIndex = 10;
            iDManagerLabel.Text = "IDManager:";
            // 
            // areaIDLabel
            // 
            areaIDLabel.AutoSize = true;
            areaIDLabel.Location = new System.Drawing.Point(705, 205);
            areaIDLabel.Name = "areaIDLabel";
            areaIDLabel.Size = new System.Drawing.Size(46, 13);
            areaIDLabel.TabIndex = 12;
            areaIDLabel.Text = "Area ID:";
            // 
            // teplica3DataSet
            // 
            this.teplica3DataSet.DataSetName = "Teplica3DataSet";
            this.teplica3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emploeeBindingSource
            // 
            this.emploeeBindingSource.DataMember = "Emploee";
            this.emploeeBindingSource.DataSource = this.teplica3DataSet;
            // 
            // emploeeTableAdapter
            // 
            this.emploeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmploeeTableAdapter = this.emploeeTableAdapter;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursBDFinal.Teplica3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // emploeeBindingNavigator
            // 
            this.emploeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.emploeeBindingNavigator.BindingSource = this.emploeeBindingSource;
            this.emploeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.emploeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.emploeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.emploeeBindingNavigatorSaveItem});
            this.emploeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.emploeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.emploeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.emploeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.emploeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.emploeeBindingNavigator.Name = "emploeeBindingNavigator";
            this.emploeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.emploeeBindingNavigator.Size = new System.Drawing.Size(881, 25);
            this.emploeeBindingNavigator.TabIndex = 0;
            this.emploeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // emploeeBindingNavigatorSaveItem
            // 
            this.emploeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emploeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("emploeeBindingNavigatorSaveItem.Image")));
            this.emploeeBindingNavigatorSaveItem.Name = "emploeeBindingNavigatorSaveItem";
            this.emploeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.emploeeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.emploeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.emploeeBindingNavigatorSaveItem_Click);
            // 
            // emploeeDataGridView
            // 
            this.emploeeDataGridView.AutoGenerateColumns = false;
            this.emploeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emploeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.emploeeDataGridView.DataSource = this.emploeeBindingSource;
            this.emploeeDataGridView.Location = new System.Drawing.Point(9, 28);
            this.emploeeDataGridView.Name = "emploeeDataGridView";
            this.emploeeDataGridView.ReadOnly = true;
            this.emploeeDataGridView.Size = new System.Drawing.Size(660, 220);
            this.emploeeDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDManager";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDManager";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AreaID";
            this.dataGridViewTextBoxColumn6.HeaderText = "AreaID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "EmpID", true));
            this.empIDTextBox.Location = new System.Drawing.Point(757, 72);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.empIDTextBox.TabIndex = 3;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "EmpName", true));
            this.empNameTextBox.Location = new System.Drawing.Point(757, 98);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.empNameTextBox.TabIndex = 5;
            // 
            // empSNameTextBox
            // 
            this.empSNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "EmpSName", true));
            this.empSNameTextBox.Location = new System.Drawing.Point(757, 124);
            this.empSNameTextBox.Name = "empSNameTextBox";
            this.empSNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.empSNameTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insert data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empProfTextBox
            // 
            this.empProfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emploeeBindingSource, "EmpProf", true));
            this.empProfTextBox.Location = new System.Drawing.Point(757, 150);
            this.empProfTextBox.Name = "empProfTextBox";
            this.empProfTextBox.Size = new System.Drawing.Size(100, 20);
            this.empProfTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emploeeBindingSource, "IDManager", true));
            this.comboBox1.DataSource = this.managerBindingSource;
            this.comboBox1.DisplayMember = "IDManager";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(757, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "IDManager";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.teplica3DataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.emploeeBindingSource, "AreaID", true));
            this.comboBox2.DataSource = this.areaBindingSource;
            this.comboBox2.DisplayMember = "AreaID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(758, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "AreaID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.teplica3DataSetBindingSource;
            // 
            // teplica3DataSetBindingSource
            // 
            this.teplica3DataSetBindingSource.DataSource = this.teplica3DataSet;
            this.teplica3DataSetBindingSource.Position = 0;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // fKEmploeeManagerBindingSource
            // 
            this.fKEmploeeManagerBindingSource.DataMember = "FK_Emploee_Manager";
            this.fKEmploeeManagerBindingSource.DataSource = this.managerBindingSource;
            // 
            // fKEmploeeManagerBindingSource1
            // 
            this.fKEmploeeManagerBindingSource1.DataMember = "FK_Emploee_Manager";
            this.fKEmploeeManagerBindingSource1.DataSource = this.managerBindingSource;
            // 
            // managerBindingSource1
            // 
            this.managerBindingSource1.DataMember = "Manager";
            this.managerBindingSource1.DataSource = this.teplica3DataSet;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(12, 251);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(62, 25);
            this.fillToolStrip.TabIndex = 18;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 339);
            this.ControlBox = false;
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(areaIDLabel);
            this.Controls.Add(iDManagerLabel);
            this.Controls.Add(empProfLabel);
            this.Controls.Add(this.empProfTextBox);
            this.Controls.Add(empSNameLabel);
            this.Controls.Add(this.empSNameTextBox);
            this.Controls.Add(empNameLabel);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(empIDLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.emploeeDataGridView);
            this.Controls.Add(this.emploeeBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Emploee";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingNavigator)).EndInit();
            this.emploeeBindingNavigator.ResumeLayout(false);
            this.emploeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teplica3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmploeeManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmploeeManagerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Teplica3DataSet teplica3DataSet;
        private System.Windows.Forms.BindingSource emploeeBindingSource;
        private Teplica3DataSetTableAdapters.EmploeeTableAdapter emploeeTableAdapter;
        private Teplica3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator emploeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton emploeeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView emploeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox empSNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox empProfTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private Teplica3DataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.BindingSource teplica3DataSetBindingSource;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private Teplica3DataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.BindingSource fKEmploeeManagerBindingSource;
        private System.Windows.Forms.BindingSource fKEmploeeManagerBindingSource1;
        private System.Windows.Forms.BindingSource managerBindingSource1;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
    }
}