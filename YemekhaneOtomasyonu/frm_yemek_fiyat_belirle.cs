using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekhaneOtomasyonu
{
    public partial class frm_yemek_fiyat_belirle : Form
    {
        public frm_yemek_fiyat_belirle()
        {
            InitializeComponent();
        }

        private void frm_yemek_fiyat_belirle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Yemek' table. You can move, or remove it, as needed.
            this.yemekTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Yemek);

        }
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            int seciliYemek = Convert.ToInt16(cmb_yemek_ad.SelectedValue);
            int yemekFiyat = Convert.ToInt16(txt_yemek_Fiyat.Text);

            Yemek YemekUcret = vt.Yemek.FirstOrDefault(p => p.YemekID == seciliYemek);
            if (YemekUcret != null)
            {
                YemekUcret.Yemekfiyat =(short) yemekFiyat;
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Yemek Fiyat Belirlendi");
                    dgv_yemek_Fiyat.DataSource = null; // Veri kaynağını temizle
                    dgv_yemek_Fiyat.DataSource = vt.Yemek.ToList(); // Yeni veri kaynağını ata
                    dgv_yemek_Fiyat.Refresh();
                }
                else
                {
                    MessageBox.Show("Yemek Fiyat Belirlenemedi!!!");
                }
            }
        }
    }
}
