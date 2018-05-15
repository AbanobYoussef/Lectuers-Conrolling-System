namespace SS.PL
{
    partial class PRINT2
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
            this.dOORDataSet1 = new SS.DOORDataSet1();
            this.dOORDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dOORDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOORDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dOORDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SS.PL.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 641);
            this.reportViewer1.TabIndex = 0;
            // 
            // dOORDataSet1
            // 
            this.dOORDataSet1.DataSetName = "DOORDataSet1";
            this.dOORDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOORDataSet1BindingSource
            // 
            this.dOORDataSet1BindingSource.DataSource = this.dOORDataSet1;
            this.dOORDataSet1BindingSource.Position = 0;
            // 
            // PRINT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 641);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PRINT2";
            this.Text = "PRINT2";
            this.Load += new System.EventHandler(this.PRINT2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOORDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOORDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource dOORDataSet1BindingSource;
        public DOORDataSet1 dOORDataSet1;
    }
}