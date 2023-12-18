namespace YemekhaneOtomasyonu
{
    partial class frm_ögrenci_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.haftalıkYemekListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yemekAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakiyeYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.haftalıkYemekListesiToolStripMenuItem,
            this.yemekAlToolStripMenuItem,
            this.bakiyeYükleToolStripMenuItem,
            this.şifreDeğişToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // haftalıkYemekListesiToolStripMenuItem
            // 
            this.haftalıkYemekListesiToolStripMenuItem.Name = "haftalıkYemekListesiToolStripMenuItem";
            this.haftalıkYemekListesiToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.haftalıkYemekListesiToolStripMenuItem.Text = "Haftalık Yemek Listesi";
            this.haftalıkYemekListesiToolStripMenuItem.Click += new System.EventHandler(this.haftalıkYemekListesiToolStripMenuItem_Click);
            // 
            // yemekAlToolStripMenuItem
            // 
            this.yemekAlToolStripMenuItem.Name = "yemekAlToolStripMenuItem";
            this.yemekAlToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.yemekAlToolStripMenuItem.Text = "Yemek Al";
            this.yemekAlToolStripMenuItem.Click += new System.EventHandler(this.yemekAlToolStripMenuItem_Click);
            // 
            // bakiyeYükleToolStripMenuItem
            // 
            this.bakiyeYükleToolStripMenuItem.Name = "bakiyeYükleToolStripMenuItem";
            this.bakiyeYükleToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.bakiyeYükleToolStripMenuItem.Text = "Bakiye Yükle";
            this.bakiyeYükleToolStripMenuItem.Click += new System.EventHandler(this.bakiyeYükleToolStripMenuItem_Click);
            // 
            // şifreDeğişToolStripMenuItem
            // 
            this.şifreDeğişToolStripMenuItem.Name = "şifreDeğişToolStripMenuItem";
            this.şifreDeğişToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.şifreDeğişToolStripMenuItem.Text = "Şifre Değiş";
            this.şifreDeğişToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğişToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // frm_ögrenci_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(114)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ögrenci_menu";
            this.Text = "frm_ögrenci_menu";
            this.Load += new System.EventHandler(this.frm_ögrenci_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem haftalıkYemekListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yemekAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakiyeYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}