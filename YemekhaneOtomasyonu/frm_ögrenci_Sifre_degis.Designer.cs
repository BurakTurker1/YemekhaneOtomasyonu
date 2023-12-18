namespace YemekhaneOtomasyonu
{
    partial class frm_ögrenci_Sifre_degis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ögrenci_sifre_degis = new System.Windows.Forms.Button();
            this.txt_yeni_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_eski_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ögrenci_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ögrenci_sifre_degis);
            this.groupBox1.Controls.Add(this.txt_yeni_sifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_eski_sifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ögrenci_no);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(312, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            // 
            // btn_ögrenci_sifre_degis
            // 
            this.btn_ögrenci_sifre_degis.Location = new System.Drawing.Point(191, 316);
            this.btn_ögrenci_sifre_degis.Name = "btn_ögrenci_sifre_degis";
            this.btn_ögrenci_sifre_degis.Size = new System.Drawing.Size(94, 42);
            this.btn_ögrenci_sifre_degis.TabIndex = 6;
            this.btn_ögrenci_sifre_degis.Text = "Değiştir";
            this.btn_ögrenci_sifre_degis.UseVisualStyleBackColor = true;
            this.btn_ögrenci_sifre_degis.Click += new System.EventHandler(this.btn_ögrenci_sifre_degis_Click);
            // 
            // txt_yeni_sifre
            // 
            this.txt_yeni_sifre.Location = new System.Drawing.Point(168, 242);
            this.txt_yeni_sifre.Name = "txt_yeni_sifre";
            this.txt_yeni_sifre.Size = new System.Drawing.Size(143, 32);
            this.txt_yeni_sifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Şifre:";
            // 
            // txt_eski_sifre
            // 
            this.txt_eski_sifre.Location = new System.Drawing.Point(168, 174);
            this.txt_eski_sifre.Name = "txt_eski_sifre";
            this.txt_eski_sifre.Size = new System.Drawing.Size(143, 32);
            this.txt_eski_sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eski Şifre:";
            // 
            // txt_ögrenci_no
            // 
            this.txt_ögrenci_no.Location = new System.Drawing.Point(168, 121);
            this.txt_ögrenci_no.Name = "txt_ögrenci_no";
            this.txt_ögrenci_no.Size = new System.Drawing.Size(143, 32);
            this.txt_ögrenci_no.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "öğrenci No:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ögrenci_Sifre_degis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_ögrenci_Sifre_degis";
            this.Text = "frm_ögrenci_Sifre_degis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ögrenci_sifre_degis;
        private System.Windows.Forms.TextBox txt_yeni_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_eski_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ögrenci_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}