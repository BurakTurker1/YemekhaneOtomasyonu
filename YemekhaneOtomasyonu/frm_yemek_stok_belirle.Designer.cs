﻿namespace YemekhaneOtomasyonu
{
    partial class frm_yemek_stok_belirle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_yemek_ad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Yemek_Stok = new System.Windows.Forms.DataGridView();
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.yemekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter();
            this.yemekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Yemek_Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_stok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_yemek_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(147, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Stok ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "KG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stok Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(147, 151);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(134, 32);
            this.txt_stok.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok:";
            // 
            // cmb_yemek_ad
            // 
            this.cmb_yemek_ad.DataSource = this.yemekBindingSource;
            this.cmb_yemek_ad.DisplayMember = "Yemekisim";
            this.cmb_yemek_ad.FormattingEnabled = true;
            this.cmb_yemek_ad.Location = new System.Drawing.Point(147, 65);
            this.cmb_yemek_ad.Name = "cmb_yemek_ad";
            this.cmb_yemek_ad.Size = new System.Drawing.Size(134, 32);
            this.cmb_yemek_ad.TabIndex = 1;
            this.cmb_yemek_ad.ValueMember = "YemekID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek:";
            // 
            // dgv_Yemek_Stok
            // 
            this.dgv_Yemek_Stok.AllowUserToAddRows = false;
            this.dgv_Yemek_Stok.AllowUserToDeleteRows = false;
            this.dgv_Yemek_Stok.AutoGenerateColumns = false;
            this.dgv_Yemek_Stok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Yemek_Stok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_Yemek_Stok.DataSource = this.yemekBindingSource1;
            this.dgv_Yemek_Stok.Location = new System.Drawing.Point(571, 108);
            this.dgv_Yemek_Stok.Name = "dgv_Yemek_Stok";
            this.dgv_Yemek_Stok.ReadOnly = true;
            this.dgv_Yemek_Stok.RowHeadersWidth = 51;
            this.dgv_Yemek_Stok.RowTemplate.Height = 24;
            this.dgv_Yemek_Stok.Size = new System.Drawing.Size(309, 343);
            this.dgv_Yemek_Stok.TabIndex = 1;
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
            // yemekBindingSource1
            // 
            this.yemekBindingSource1.DataMember = "Yemek";
            this.yemekBindingSource1.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Yemekisim";
            this.dataGridViewTextBoxColumn1.HeaderText = "Yemekisim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "yemekMiktar";
            this.dataGridViewTextBoxColumn2.HeaderText = "yemekMiktar";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // frm_yemek_stok_belirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1134, 527);
            this.Controls.Add(this.dgv_Yemek_Stok);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_yemek_stok_belirle";
            this.Text = "frm_yemek_stok_belirle";
            this.Load += new System.EventHandler(this.frm_yemek_stok_belirle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Yemek_Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_yemek_ad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.DataGridView dgv_Yemek_Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource yemekBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter yemekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource yemekBindingSource1;
    }
}