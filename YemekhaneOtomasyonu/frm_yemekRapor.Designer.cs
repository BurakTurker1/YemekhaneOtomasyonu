namespace YemekhaneOtomasyonu
{
    partial class frm_yemekRapor
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
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.yemekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.yemekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YemekhaneOtomasyonu.ReportYemek.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1100, 675);
            this.reportViewer1.TabIndex = 0;
            // 
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yemekBindingSource
            // 
            this.yemekBindingSource.DataMember = "Yemek";
            this.yemekBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // yemekTableAdapter
            // 
            this.yemekTableAdapter.ClearBeforeFill = true;
            // 
            // frm_yemekRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_yemekRapor";
            this.Text = "frm_yemekRapor";
            this.Load += new System.EventHandler(this.frm_yemekRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource yemekBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter yemekTableAdapter;
    }
}