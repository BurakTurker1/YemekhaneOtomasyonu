namespace YemekhaneOtomasyonu
{
    partial class frm_kullanıcıRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kullanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kullanıcıTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.KullanıcıTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanıcıBindingSource
            // 
            this.kullanıcıBindingSource.DataMember = "Kullanıcı";
            this.kullanıcıBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.kullanıcıBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YemekhaneOtomasyonu.ReportKullanıcı.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // kullanıcıTableAdapter
            // 
            this.kullanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(707, 324);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // frm_kullanıcıRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_kullanıcıRapor";
            this.Text = "frm_kullanıcıRapor";
            this.Load += new System.EventHandler(this.frm_kullanıcıRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource kullanıcıBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.KullanıcıTableAdapter kullanıcıTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}