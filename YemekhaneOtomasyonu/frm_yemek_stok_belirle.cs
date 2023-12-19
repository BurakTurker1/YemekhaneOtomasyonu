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
    public partial class frm_yemek_stok_belirle : Form
    {
        public frm_yemek_stok_belirle()
        {
            InitializeComponent();
        }

        private void frm_yemek_stok_belirle_Load(object sender, EventArgs e)
        {

        }
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            int seciliYemek =Convert.ToInt16(cmb_yemek_ad.SelectedValue);
            int YemekStok = Convert.ToInt16(txt_stok.Text);
           // MessageBox.Show("Seçili yemek" + seciliYemek);

            Yemek gelenYemek = vt.Yemek.FirstOrDefault(p => p.YemekID == seciliYemek);
            if(gelenYemek != null)
            {
                gelenYemek.yemekMiktar = YemekStok;
               // vt.Yemek.Add(gelenYemek);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Yemek Stok Eklendi");
                    dgv_Yemek_Stok.DataSource = null; // Veri kaynağını temizle
                    dgv_Yemek_Stok.DataSource = vt.Yemek.ToList(); // Yeni veri kaynağını ata
                    dgv_Yemek_Stok.Refresh();
                }
                else
                {
                    MessageBox.Show("Yemek Stok Eklenemedi!!!");
                }
            }

        }
    }
}
