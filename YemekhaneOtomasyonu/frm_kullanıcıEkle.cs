using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekhaneOtomasyonu.ServiceReference1;

namespace YemekhaneOtomasyonu
{
    public partial class frm_kullanıcıEkle : Form
    {
        public frm_kullanıcıEkle()
        {
            InitializeComponent();
        }
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            long tcNo = Convert.ToInt64(txt_Tc_No.Text);
            int Dogumyıl = Convert.ToInt16(txt_dogum_yıl.Text);
            string isim = txt_ad.Text.ToUpper();
            string soyad = txt_Soyad.Text.ToUpper();
            string sifre = txt_sifre.Text;
            int yetki = Convert.ToInt16(cmb_yetki.SelectedValue);
            //MessageBox.Show("yetki:"+yetki);

            KPSPublicSoapClient kps = new KPSPublicSoapClient();
            bool Gercekkisi = kps.TCKimlikNoDogrula(tcNo, isim, soyad, Dogumyıl);
            if (Gercekkisi == true)
            {
                //kullancı bilgileri
                Kullanıcı yeniKullanıcı = new Kullanıcı();
                yeniKullanıcı.kTc = tcNo.ToString();
                yeniKullanıcı.kAd = isim;
                yeniKullanıcı.kSoyad = soyad;
                yeniKullanıcı.kSifre = sifre;
                yeniKullanıcı.kDogumYıl = Dogumyıl.ToString();
                yeniKullanıcı.kYetkiID = yetki;
                yeniKullanıcı.kDurum = true;

                // Bakiye bilgileri
                KullancıBakiye bakiye =new KullancıBakiye();
                bakiye.kBakiye = 0;
                bakiye.kBakiyeYüklemeTarih = DateTime.Now;

                vt.KullancıBakiye.Add(bakiye);
                vt.Kullanıcı.Add(yeniKullanıcı);

                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Kullancı Doğrulandı ve Kayıt Başarıyla Yapıldı!");
                }
                else
                {
                    MessageBox.Show("Kullancı Doğrulandı ama Kayıt Yapılamadı!");
                }
            }
            else
            {
                MessageBox.Show("Kullancı Doğrulanamadı ve Kayıt Yapılamadı!");
            }

        }

        private void frm_kullanıcıEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.KullanıcıYetki' table. You can move, or remove it, as needed.
            this.kullanıcıYetkiTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.KullanıcıYetki);

        }
    }
}
