namespace KursBDFinal
{
    partial class Form12
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Teplica3DataSet = new KursBDFinal.Teplica3DataSet();
            this.DataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable5TableAdapter = new KursBDFinal.Teplica3DataSetTableAdapters.DataTable5TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Teplica3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KursBDFinal.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // Teplica3DataSet
            // 
            this.Teplica3DataSet.DataSetName = "Teplica3DataSet";
            this.Teplica3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable5BindingSource
            // 
            this.DataTable5BindingSource.DataMember = "DataTable5";
            this.DataTable5BindingSource.DataSource = this.Teplica3DataSet;
            // 
            // DataTable5TableAdapter
            // 
            this.DataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teplica3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable5BindingSource;
        private Teplica3DataSet Teplica3DataSet;
        private Teplica3DataSetTableAdapters.DataTable5TableAdapter DataTable5TableAdapter;
        private System.Windows.Forms.Button button1;
    }
}