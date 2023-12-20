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
        public frm_ögrenci_bakiye_yükle()
        {
            InitializeComponent();
        }
        public frm_ögrenci_bakiye_yükle(Kullanıcı GirisyapanKullancı)
        {
            InitializeComponent();
            kullanıcı = GirisyapanKullancı;
        }

        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            int yüklenecek_Bakiye = Convert.ToInt16(txt_bakiye.Text);
            string tcNo = txt_tc.Text;

            KullancıBakiye bakiyeYükle = new KullancıBakiye();
           Kullanıcı GüncelKullancı =vt.Kullanıcı.FirstOrDefault(p => p.kTc == tcNo);
            if(GüncelKullancı != null)
            {
                int güncelBakiye = GüncelKullancı.KullancıBakiye.kBakiye ?? 0 ;// null değilse devam et anlamında ??
                güncelBakiye += yüklenecek_Bakiye;
                GüncelKullancı.KullancıBakiye.kBakiye = güncelBakiye;
                int sonuc = vt.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show(yüklenecek_Bakiye + "TL Bakiye Hesabınıza Yüklenmiştir");
                    lbl_bakiye.Text = güncelBakiye.ToString();
                }
                else
                {
                    MessageBox.Show("Bakiye Yüklenemedi!!!");
                }
            }

        }

        private void frm_ögrenci_bakiye_yükle_Load(object sender, EventArgs e)
        {
            // sayfa yüklendigine ilk bakiye gösterilecek

        }
       
    }
}
