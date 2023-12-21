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
    public partial class frm_yemek_al : Form
    {
        Kullanıcı kullanıcı;
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        KullancıBakiye kullancıBakiye = new KullancıBakiye();
        int YemekFiyat;
        decimal yeniBakiye;
        public frm_yemek_al()
        {
            InitializeComponent();

        }
        public frm_yemek_al(Kullanıcı GirisyapanKullancı)
        {
            InitializeComponent();
            kullanıcı = GirisyapanKullancı;
        }
        public void sayfaYenile()
        {
            //yenileme
            this.Invalidate();
            this.Update();
        }
        
        public void Temizle()
        {
            lst_Yemek_Sepet.Items.Clear();
            YemekFiyat = 0;
            lbl_yemekTutar.Text = "0 TL";
        }

        private void btn_yemek_ekle_Click(object sender, EventArgs e)
        {

            int seçilenYemekID = Convert.ToInt32(cmb_yemek_sec.SelectedValue);
            // MessageBox.Show(seçilenYemek);
            Yemek SeçilenYemekler = vt.Yemek.FirstOrDefault(p => p.YemekID == seçilenYemekID);

            String çıktı = SeçilenYemekler.Yemekisim + ": " + SeçilenYemekler.Yemekfiyat + "TL";
            lst_Yemek_Sepet.Items.Add(çıktı);
            YemekFiyat += (int)SeçilenYemekler.Yemekfiyat;
            lbl_yemekTutar.Text = YemekFiyat.ToString()+"TL";

        }

        private void btn_yemek_Cıkar_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_ödeme_yap_Click(object sender, EventArgs e)
        {
            if ( kullanıcı.KullancıBakiye.kBakiye >= YemekFiyat)
            {
                kullanıcı = vt.Kullanıcı.FirstOrDefault(p => p.KullanıcıID == kullanıcı.KullanıcıID);
                yeniBakiye = Convert.ToDecimal(kullanıcı.KullancıBakiye.kBakiye - YemekFiyat);
                kullanıcı.KullancıBakiye.kBakiye = Convert.ToInt16(yeniBakiye);
            
          
                    int sonuc = vt.SaveChanges();

                if (sonuc > 0)
                {
                    //MessageBox.Show("İşlem başarılı");
                    lbl_güncel_Bakiye.Text = kullanıcı.KullancıBakiye.kBakiye + "TL";
                    Temizle();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
        }
        private void frm_yemek_al_Load(object sender, EventArgs e)
        {
            lbl_güncel_Bakiye.Text = kullanıcı.KullancıBakiye.kBakiye.ToString();
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Yemek' table. You can move, or remove it, as needed.
            this.yemekTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Yemek);
            //sayfaYenile();
        }


    }
}

