namespace YemekhaneOtomasyonu
{
    partial class frm_yemek_fiyat_belirle
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
            this.dgv_yemek_Fiyat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_yemek_Fiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.yemekhaneOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter();
            this.yemekisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yemekfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_yemek_ad = new System.Windows.Forms.ComboBox();
            this.yemekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemek_Fiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_yemek_Fiyat
            // 
            this.dgv_yemek_Fiyat.AllowUserToAddRows = false;
            this.dgv_yemek_Fiyat.AllowUserToDeleteRows = false;
            this.dgv_yemek_Fiyat.AutoGenerateColumns = false;
            this.dgv_yemek_Fiyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yemek_Fiyat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yemekisimDataGridViewTextBoxColumn,
            this.yemekfiyatDataGridViewTextBoxColumn});
            this.dgv_yemek_Fiyat.DataSource = this.yemekBindingSource;
            this.dgv_yemek_Fiyat.Location = new System.Drawing.Point(637, 135);
            this.dgv_yemek_Fiyat.Name = "dgv_yemek_Fiyat";
            this.dgv_yemek_Fiyat.ReadOnly = true;
            this.dgv_yemek_Fiyat.RowHeadersWidth = 51;
            this.dgv_yemek_Fiyat.RowTemplate.Height = 24;
            this.dgv_yemek_Fiyat.Size = new System.Drawing.Size(314, 296);
            this.dgv_yemek_Fiyat.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_yemek_ad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_yemek_Fiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(202, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyat Belirle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fiyat Belirle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_yemek_Fiyat
            // 
            this.txt_yemek_Fiyat.Location = new System.Drawing.Point(109, 160);
            this.txt_yemek_Fiyat.Name = "txt_yemek_Fiyat";
            this.txt_yemek_Fiyat.Size = new System.Drawing.Size(156, 32);
            this.txt_yemek_Fiyat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek:";
            // 
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yemekhaneOtomasyonDataSetBindingSource
            // 
            this.yemekhaneOtomasyonDataSetBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            this.yemekhaneOtomasyonDataSetBindingSource.Position = 0;
            // 
            // yemekBindingSource
            // 
            this.yemekBindingSource.DataMember = "Yemek";
            this.yemekBindingSource.DataSource = this.yemekhaneOtomasyonDataSetBindingSource;
            // 
            // yemekTableAdapter
            // 
            this.yemekTableAdapter.ClearBeforeFill = true;
            // 
            // yemekisimDataGridViewTextBoxColumn
            // 
            this.yemekisimDataGridViewTextBoxColumn.DataPropertyName = "Yemekisim";
            this.yemekisimDataGridViewTextBoxColumn.HeaderText = "Yemekisim";
            this.yemekisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yemekisimDataGridViewTextBoxColumn.Name = "yemekisimDataGridViewTextBoxColumn";
            this.yemekisimDataGridViewTextBoxColumn.ReadOnly = true;
            this.yemekisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // yemekfiyatDataGridViewTextBoxColumn
            // 
            this.yemekfiyatDataGridViewTextBoxColumn.DataPropertyName = "Yemekfiyat";
            this.yemekfiyatDataGridViewTextBoxColumn.HeaderText = "Yemekfiyat";
            this.yemekfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yemekfiyatDataGridViewTextBoxColumn.Name = "yemekfiyatDataGridViewTextBoxColumn";
            this.yemekfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.yemekfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // cmb_yemek_ad
            // 
            this.cmb_yemek_ad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.yemekBindingSource, "Yemekisim", true));
            this.cmb_yemek_ad.DataSource = this.yemekBindingSource1;
            this.cmb_yemek_ad.DisplayMember = "Yemekisim";
            this.cmb_yemek_ad.FormattingEnabled = true;
            this.cmb_yemek_ad.Location = new System.Drawing.Point(110, 103);
            this.cmb_yemek_ad.Name = "cmb_yemek_ad";
            this.cmb_yemek_ad.Size = new System.Drawing.Size(155, 32);
            this.cmb_yemek_ad.TabIndex = 5;
            this.cmb_yemek_ad.ValueMember = "YemekID";
            // 
            // yemekBindingSource1
            // 
            this.yemekBindingSource1.DataMember = "Yemek";
            this.yemekBindingSource1.DataSource = this.yemekhaneOtomasyonDataSetBindingSource;
            // 
            // frm_yemek_fiyat_belirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1152, 571);
            this.Controls.Add(this.dgv_yemek_Fiyat);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_yemek_fiyat_belirle";
            this.Text = "frm_yemek_fiyat_belirle";
            this.Load += new System.EventHandler(this.frm_yemek_fiyat_belirle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemek_Fiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_yemek_Fiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_yemek_Fiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource yemekhaneOtomasyonDataSetBindingSource;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource yemekBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter yemekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmb_yemek_ad;
        private System.Windows.Forms.BindingSource yemekBindingSource1;
    }
}