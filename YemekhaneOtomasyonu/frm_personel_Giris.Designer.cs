namespace YemekhaneOtomasyonu
{
    partial class frm_personel_Giris
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_personel_giris = new System.Windows.Forms.Button();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(450, 246);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(81, 38);
            this.btn_geri.TabIndex = 11;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(338, 188);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(128, 32);
            this.txt_sifre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // btn_personel_giris
            // 
            this.btn_personel_giris.Location = new System.Drawing.Point(338, 246);
            this.btn_personel_giris.Name = "btn_personel_giris";
            this.btn_personel_giris.Size = new System.Drawing.Size(97, 38);
            this.btn_personel_giris.TabIndex = 8;
            this.btn_personel_giris.Text = "Giriş Yap";
            this.btn_personel_giris.UseVisualStyleBackColor = true;
            this.btn_personel_giris.Click += new System.EventHandler(this.btn_personel_giris_Click);
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(338, 137);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(128, 32);
            this.txt_Eposta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(238, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "E posta:";
            // 
            // frm_personel_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(867, 444);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_personel_giris);
            this.Controls.Add(this.txt_Eposta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_personel_Giris";
            this.Text = "frm_personel_Giris";
            this.Load += new System.EventHandler(this.frm_personel_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_personel_giris;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label1;
    }
}