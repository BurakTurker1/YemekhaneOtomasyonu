namespace YemekhaneOtomasyonu
{
    partial class frm_yemek_al
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
            this.btn_yemek_Cıkar = new System.Windows.Forms.Button();
            this.btn_ödeme_yap = new System.Windows.Forms.Button();
            this.lbl_yemekTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_güncel_Bakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Yemek_Sepet = new System.Windows.Forms.ListBox();
            this.btn_yemek_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_yemek_sec = new System.Windows.Forms.ComboBox();
            this.yemekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.yemekTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_yemek_Cıkar);
            this.groupBox1.Controls.Add(this.btn_ödeme_yap);
            this.groupBox1.Controls.Add(this.lbl_yemekTutar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_güncel_Bakiye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lst_Yemek_Sepet);
            this.groupBox1.Controls.Add(this.btn_yemek_ekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_yemek_sec);
            this.groupBox1.Location = new System.Drawing.Point(30, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Al";
            // 
            // btn_yemek_Cıkar
            // 
            this.btn_yemek_Cıkar.Location = new System.Drawing.Point(156, 174);
            this.btn_yemek_Cıkar.Name = "btn_yemek_Cıkar";
            this.btn_yemek_Cıkar.Size = new System.Drawing.Size(147, 36);
            this.btn_yemek_Cıkar.TabIndex = 9;
            this.btn_yemek_Cıkar.Text = "Yemek Çıkar";
            this.btn_yemek_Cıkar.UseVisualStyleBackColor = true;
            this.btn_yemek_Cıkar.Click += new System.EventHandler(this.btn_yemek_Cıkar_Click);
            // 
            // btn_ödeme_yap
            // 
            this.btn_ödeme_yap.Location = new System.Drawing.Point(736, 201);
            this.btn_ödeme_yap.Name = "btn_ödeme_yap";
            this.btn_ödeme_yap.Size = new System.Drawing.Size(119, 36);
            this.btn_ödeme_yap.TabIndex = 8;
            this.btn_ödeme_yap.Text = "Ödeme Yap";
            this.btn_ödeme_yap.UseVisualStyleBackColor = true;
            this.btn_ödeme_yap.Click += new System.EventHandler(this.btn_ödeme_yap_Click);
            // 
            // lbl_yemekTutar
            // 
            this.lbl_yemekTutar.AutoSize = true;
            this.lbl_yemekTutar.Location = new System.Drawing.Point(811, 136);
            this.lbl_yemekTutar.Name = "lbl_yemekTutar";
            this.lbl_yemekTutar.Size = new System.Drawing.Size(41, 24);
            this.lbl_yemekTutar.TabIndex = 7;
            this.lbl_yemekTutar.Text = "0TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(726, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tutar:";
            // 
            // lbl_güncel_Bakiye
            // 
            this.lbl_güncel_Bakiye.AutoSize = true;
            this.lbl_güncel_Bakiye.Location = new System.Drawing.Point(811, 82);
            this.lbl_güncel_Bakiye.Name = "lbl_güncel_Bakiye";
            this.lbl_güncel_Bakiye.Size = new System.Drawing.Size(20, 24);
            this.lbl_güncel_Bakiye.TabIndex = 5;
            this.lbl_güncel_Bakiye.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bakiye:";
            // 
            // lst_Yemek_Sepet
            // 
            this.lst_Yemek_Sepet.FormattingEnabled = true;
            this.lst_Yemek_Sepet.ItemHeight = 24;
            this.lst_Yemek_Sepet.Location = new System.Drawing.Point(377, 42);
            this.lst_Yemek_Sepet.Name = "lst_Yemek_Sepet";
            this.lst_Yemek_Sepet.Size = new System.Drawing.Size(274, 292);
            this.lst_Yemek_Sepet.TabIndex = 3;
            // 
            // btn_yemek_ekle
            // 
            this.btn_yemek_ekle.Location = new System.Drawing.Point(156, 120);
            this.btn_yemek_ekle.Name = "btn_yemek_ekle";
            this.btn_yemek_ekle.Size = new System.Drawing.Size(123, 36);
            this.btn_yemek_ekle.TabIndex = 2;
            this.btn_yemek_ekle.Text = "Yemek Ekle";
            this.btn_yemek_ekle.UseVisualStyleBackColor = true;
            this.btn_yemek_ekle.Click += new System.EventHandler(this.btn_yemek_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yemek:";
            // 
            // cmb_yemek_sec
            // 
            this.cmb_yemek_sec.DataSource = this.yemekBindingSource;
            this.cmb_yemek_sec.DisplayMember = "Yemekisim";
            this.cmb_yemek_sec.FormattingEnabled = true;
            this.cmb_yemek_sec.Location = new System.Drawing.Point(156, 64);
            this.cmb_yemek_sec.Name = "cmb_yemek_sec";
            this.cmb_yemek_sec.Size = new System.Drawing.Size(121, 32);
            this.cmb_yemek_sec.TabIndex = 0;
            this.cmb_yemek_sec.ValueMember = "YemekID";
            // 
            // yemekBindingSource
            // 
            this.yemekBindingSource.DataMember = "Yemek";
            this.yemekBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yemekTableAdapter
            // 
            this.yemekTableAdapter.ClearBeforeFill = true;
            // 
            // frm_yemek_al
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_yemek_al";
            this.Text = "frm_yemek_al";
            this.Load += new System.EventHandler(this.frm_yemek_al_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_yemek_sec;
        private System.Windows.Forms.Button btn_yemek_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_Yemek_Sepet;
        private System.Windows.Forms.Label lbl_yemekTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_güncel_Bakiye;
        private System.Windows.Forms.Button btn_ödeme_yap;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource yemekBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.YemekTableAdapter yemekTableAdapter;
        private System.Windows.Forms.Button btn_yemek_Cıkar;
    }
}