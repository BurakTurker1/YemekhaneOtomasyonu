namespace YemekhaneOtomasyonu
{
    partial class frm_personel_Ekle
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
            this.cmb_yetki = new System.Windows.Forms.ComboBox();
            this.personelYetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yemekhane_OtomasyonDataSet = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSet();
            this.personelYetkiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rb_Kadın = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dogum_yıl = new System.Windows.Forms.TextBox();
            this.txt_Tc_No = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yemekhaneOtomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelYetkiTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.PersonelYetkiTableAdapter();
            this.personelYetkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPersonelPersonelYetkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new YemekhaneOtomasyonu.Yemekhane_OtomasyonDataSetTableAdapters.PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneOtomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonelPersonelYetkiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_yetki);
            this.groupBox1.Controls.Add(this.rb_Kadın);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rb_erkek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Eposta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_dogum_yıl);
            this.groupBox1.Controls.Add(this.txt_Tc_No);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Soyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(282, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_yetki
            // 
            this.cmb_yetki.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personelYetkiBindingSource, "PersonelYetkiTür", true));
            this.cmb_yetki.DataSource = this.personelYetkiBindingSource2;
            this.cmb_yetki.DisplayMember = "PersonelYetkiTür";
            this.cmb_yetki.FormattingEnabled = true;
            this.cmb_yetki.Location = new System.Drawing.Point(175, 354);
            this.cmb_yetki.Name = "cmb_yetki";
            this.cmb_yetki.Size = new System.Drawing.Size(146, 32);
            this.cmb_yetki.TabIndex = 34;
            this.cmb_yetki.ValueMember = "personelYetkiID";
            // 
            // personelYetkiBindingSource
            // 
            this.personelYetkiBindingSource.DataMember = "PersonelYetki";
            this.personelYetkiBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // yemekhane_OtomasyonDataSet
            // 
            this.yemekhane_OtomasyonDataSet.DataSetName = "Yemekhane_OtomasyonDataSet";
            this.yemekhane_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelYetkiBindingSource2
            // 
            this.personelYetkiBindingSource2.DataMember = "PersonelYetki";
            this.personelYetkiBindingSource2.DataSource = this.yemekhane_OtomasyonDataSet;
            // 
            // rb_Kadın
            // 
            this.rb_Kadın.AutoSize = true;
            this.rb_Kadın.Location = new System.Drawing.Point(279, 403);
            this.rb_Kadın.Name = "rb_Kadın";
            this.rb_Kadın.Size = new System.Drawing.Size(80, 28);
            this.rb_Kadın.TabIndex = 33;
            this.rb_Kadın.TabStop = true;
            this.rb_Kadın.Text = "Kadın";
            this.rb_Kadın.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Yetki:";
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(171, 403);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(79, 28);
            this.rb_erkek.TabIndex = 32;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cinsiyet:";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(276, 459);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(83, 46);
            this.btn_geri.TabIndex = 27;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(175, 303);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(146, 32);
            this.txt_sifre.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Şifre:";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(175, 250);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(146, 32);
            this.txt_Eposta.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Eposta:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(175, 96);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(146, 32);
            this.txt_ad.TabIndex = 19;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(155, 459);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(95, 46);
            this.btn_kaydet.TabIndex = 22;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC:";
            // 
            // txt_dogum_yıl
            // 
            this.txt_dogum_yıl.Location = new System.Drawing.Point(175, 197);
            this.txt_dogum_yıl.Name = "txt_dogum_yıl";
            this.txt_dogum_yıl.Size = new System.Drawing.Size(146, 32);
            this.txt_dogum_yıl.TabIndex = 21;
            // 
            // txt_Tc_No
            // 
            this.txt_Tc_No.Location = new System.Drawing.Point(175, 42);
            this.txt_Tc_No.Name = "txt_Tc_No";
            this.txt_Tc_No.Size = new System.Drawing.Size(146, 32);
            this.txt_Tc_No.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Doğum Yıllı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(175, 147);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(146, 32);
            this.txt_Soyad.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ad:";
            // 
            // yemekhaneOtomasyonDataSetBindingSource
            // 
            this.yemekhaneOtomasyonDataSetBindingSource.DataSource = this.yemekhane_OtomasyonDataSet;
            this.yemekhaneOtomasyonDataSetBindingSource.Position = 0;
            // 
            // personelYetkiTableAdapter
            // 
            this.personelYetkiTableAdapter.ClearBeforeFill = true;
            // 
            // personelYetkiBindingSource1
            // 
            this.personelYetkiBindingSource1.DataMember = "PersonelYetki";
            this.personelYetkiBindingSource1.DataSource = this.yemekhaneOtomasyonDataSetBindingSource;
            // 
            // fKPersonelPersonelYetkiBindingSource
            // 
            this.fKPersonelPersonelYetkiBindingSource.DataMember = "FK_Personel_PersonelYetki";
            this.fKPersonelPersonelYetkiBindingSource.DataSource = this.personelYetkiBindingSource;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // frm_personel_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1113, 483);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_personel_Ekle";
            this.Text = "frm_personel_Ekle";
            this.Load += new System.EventHandler(this.frm_personel_Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhane_OtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemekhaneOtomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelYetkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonelPersonelYetkiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dogum_yıl;
        private System.Windows.Forms.TextBox txt_Tc_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_yetki;
        private System.Windows.Forms.RadioButton rb_Kadın;
        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.BindingSource yemekhaneOtomasyonDataSetBindingSource;
        private Yemekhane_OtomasyonDataSet yemekhane_OtomasyonDataSet;
        private System.Windows.Forms.BindingSource personelYetkiBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.PersonelYetkiTableAdapter personelYetkiTableAdapter;
        private System.Windows.Forms.BindingSource personelYetkiBindingSource1;
        private System.Windows.Forms.BindingSource fKPersonelPersonelYetkiBindingSource;
        private Yemekhane_OtomasyonDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.BindingSource personelYetkiBindingSource2;
    }
}