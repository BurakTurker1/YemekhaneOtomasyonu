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
    public partial class frm_yemek_Ekle : Form
    {
        public frm_yemek_Ekle()
        {
            InitializeComponent();
        }

        private void frm_yemek_Ekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Yemek' table. You can move, or remove it, as needed.
            this.yemekTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Yemek);

        }

        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            string yemekAd = txt_yemek_ad.Text;
            int yemekKalori = Convert.ToInt16(txt_yemek_kalori.Text);
             Yemek yeniYemek = new Yemek();
            yeniYemek.Yemekisim = yemekAd;
            yeniYemek.YemekKalori = (short) yemekKalori;
           vt.Yemek.Add(yeniYemek);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Yemek Eklendi");
                dgv_yemek_kalori.DataSource = null; // Veri kaynağını temizle
                dgv_yemek_kalori.DataSource = vt.Yemek.ToList(); // Yeni veri kaynağını ata
                dgv_yemek_kalori.Refresh();
            }
            else
            {
                MessageBox.Show("Yemek Eklenemedi!!!");
            }
        }
    }
}
