namespace YemekhaneOtomasyonu
{
    partial class frm_ögrenci_giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ögrenci_no = new System.Windows.Forms.TextBox();
            this.btn_ögrenci_giris = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ögrenci_kayıt_ol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ögrenci No:";
            // 
            // txt_ögrenci_no
            // 
            this.txt_ögrenci_no.Location = new System.Drawing.Point(334, 119);
            this.txt_ögrenci_no.Name = "txt_ögrenci_no";
            this.txt_ögrenci_no.Size = new System.Drawing.Size(128, 32);
            this.txt_ögrenci_no.TabIndex = 1;
            // 
            // btn_ögrenci_giris
            // 
            this.btn_ögrenci_giris.Location = new System.Drawing.Point(334, 228);
            this.btn_ögrenci_giris.Name = "btn_ögrenci_giris";
            this.btn_ögrenci_giris.Size = new System.Drawing.Size(97, 38);
            this.btn_ögrenci_giris.TabIndex = 2;
            this.btn_ögrenci_giris.Text = "Giriş Yap";
            this.btn_ögrenci_giris.UseVisualStyleBackColor = true;
            this.btn_ögrenci_giris.Click += new System.EventHandler(this.btn_ögrenci_giris_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(334, 170);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(128, 32);
            this.txt_sifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(446, 228);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(81, 38);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ögrenci_kayıt_ol
            // 
            this.btn_ögrenci_kayıt_ol.Location = new System.Drawing.Point(334, 272);
            this.btn_ögrenci_kayıt_ol.Name = "btn_ögrenci_kayıt_ol";
            this.btn_ögrenci_kayıt_ol.Size = new System.Drawing.Size(97, 38);
            this.btn_ögrenci_kayıt_ol.TabIndex = 6;
            this.btn_ögrenci_kayıt_ol.Text = "Kayıt Ol";
            this.btn_ögrenci_kayıt_ol.UseVisualStyleBackColor = true;
            this.btn_ögrenci_kayıt_ol.Click += new System.EventHandler(this.btn_ögrenci_kayıt_ol_Click);
            // 
            // frm_ögrenci_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(787, 383);
            this.Controls.Add(this.btn_ögrenci_kayıt_ol);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ögrenci_giris);
            this.Controls.Add(this.txt_ögrenci_no);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ögrenci_giris";
            this.Text = "frm_ögrenci_giris";
            this.Load += new System.EventHandler(this.frm_ögrenci_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ögrenci_no;
        private System.Windows.Forms.Button btn_ögrenci_giris;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ögrenci_kayıt_ol;
    }
}