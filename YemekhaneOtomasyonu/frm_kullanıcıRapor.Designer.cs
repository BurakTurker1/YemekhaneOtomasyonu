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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.kullanıcıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanıcıTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.KullanıcıTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcıBindingSource
            // 
            this.kullanıcıBindingSource.DataMember = "Kullanıcı";
            this.kullanıcıBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // kullanıcıTableAdapter
            // 
            this.kullanıcıTableAdapter.ClearBeforeFill = true;
            // 
            // frm_kullanıcıRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_kullanıcıRapor";
            this.Text = "frm_kullanıcıRapor";
            this.Load += new System.EventHandler(this.frm_kullanıcıRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcıBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource kullanıcıBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.KullanıcıTableAdapter kullanıcıTableAdapter;
    }
}