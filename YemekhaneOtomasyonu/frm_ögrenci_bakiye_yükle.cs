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
    public partial class frm_ögrenci_bakiye_yükle : Form
    {
        Kullanıcı kullanıcı;
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        KullancıBakiye kullancıBakiye = new KullancıBakiye();
        int yeniBakiye;
        int yüklenecek_Bakiye;


        public frm_ögrenci_bakiye_yükle()
        {
            InitializeComponent();
        }
        public frm_ögrenci_bakiye_yükle(Kullanıcı GirisyapanKullancı)
        {
            InitializeComponent();
            kullanıcı = GirisyapanKullancı;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            yüklenecek_Bakiye = Convert.ToInt32(txt_bakiye.Text);
            kullanıcı = vt.Kullanıcı.FirstOrDefault(p => p.KullanıcıID == kullanıcı.KullanıcıID);
            if(kullanıcı != null)
            {
                yeniBakiye = (int)kullanıcı.KullancıBakiye.kBakiye + yüklenecek_Bakiye;
                kullanıcı.KullancıBakiye.kBakiye = yeniBakiye;
                kullanıcı.KullancıBakiye.kBakiyeYüklemeTarih = DateTime.Now;

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show(yüklenecek_Bakiye + "TL Bakiye Hesabınıza Yüklenmiştir");
                    lbl_bakiye.Text = kullanıcı.KullancıBakiye.kBakiye.ToString();
                }
                else
                {
                    MessageBox.Show("Bakiye Yüklenemedi!!!");
                }
            }
            else
            {
                MessageBox.Show("kullanıcı yok");
            }
            
        }
        private void frm_ögrenci_bakiye_yükle_Load(object sender, EventArgs e)
        {
            lbl_bakiye.Text = kullanıcı.KullancıBakiye.kBakiye.ToString();
            lbl_isim.Text = kullanıcı.kAd + " " + kullanıcı.kSoyad;

        }

    }
}
