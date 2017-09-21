namespace ADO.Net_Demo
{
    partial class MovieReport
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
            this.MOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netflixDataSet = new ADO.Net_Demo.netflixDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MOVIETableAdapter = new ADO.Net_Demo.netflixDataSetTableAdapters.MOVIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netflixDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MOVIEBindingSource
            // 
            this.MOVIEBindingSource.DataMember = "MOVIE";
            this.MOVIEBindingSource.DataSource = this.netflixDataSet;
            // 
            // netflixDataSet
            // 
            this.netflixDataSet.DataSetName = "netflixDataSet";
            this.netflixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MOVIEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ADO.Net_Demo.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(665, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // MOVIETableAdapter
            // 
            this.MOVIETableAdapter.ClearBeforeFill = true;
            // 
            // MovieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MovieReport";
            this.Text = "MovieReport";
            this.Load += new System.EventHandler(this.MovieReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netflixDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MOVIEBindingSource;
        private netflixDataSet netflixDataSet;
        private netflixDataSetTableAdapters.MOVIETableAdapter MOVIETableAdapter;
    }
}