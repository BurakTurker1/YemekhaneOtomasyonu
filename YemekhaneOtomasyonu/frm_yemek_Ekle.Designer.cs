namespace YemekhaneOtomasyonu
{
    partial class frm_yemek_Ekle
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_yemek_kalori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yemek_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_yemek_kalori = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemek_kalori)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_yemek_kalori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_yemek_ad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(89, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yemek Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Yemek Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_yemek_kalori
            // 
            this.txt_yemek_kalori.Location = new System.Drawing.Point(109, 160);
            this.txt_yemek_kalori.Name = "txt_yemek_kalori";
            this.txt_yemek_kalori.Size = new System.Drawing.Size(156, 32);
            this.txt_yemek_kalori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalori:";
            // 
            // txt_yemek_ad
            // 
            this.txt_yemek_ad.Location = new System.Drawing.Point(109, 104);
            this.txt_yemek_ad.Name = "txt_yemek_ad";
            this.txt_yemek_ad.Size = new System.Drawing.Size(156, 32);
            this.txt_yemek_ad.TabIndex = 1;
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
            // dgv_yemek_kalori
            // 
            this.dgv_yemek_kalori.AllowUserToAddRows = false;
            this.dgv_yemek_kalori.AllowUserToDeleteRows = false;
            this.dgv_yemek_kalori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yemek_kalori.Location = new System.Drawing.Point(524, 121);
            this.dgv_yemek_kalori.Name = "dgv_yemek_kalori";
            this.dgv_yemek_kalori.ReadOnly = true;
            this.dgv_yemek_kalori.RowHeadersWidth = 51;
            this.dgv_yemek_kalori.RowTemplate.Height = 24;
            this.dgv_yemek_kalori.Size = new System.Drawing.Size(314, 296);
            this.dgv_yemek_kalori.TabIndex = 1;
            // 
            // frm_yemek_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(869, 522);
            this.Controls.Add(this.dgv_yemek_kalori);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_yemek_Ekle";
            this.Text = "frm_yemek_Ekle";
            this.Load += new System.EventHandler(this.frm_yemek_Ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemek_kalori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yemek_kalori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yemek_ad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_yemek_kalori;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yemekKaloriDataGridViewTextBoxColumn;
    }
}