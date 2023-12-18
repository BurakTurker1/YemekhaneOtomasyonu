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
    public partial class frm_ögrenci_kayıt : Form
    {
        public frm_ögrenci_kayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
            long tcNo = Convert.ToInt64(txt_Tc_No.Text);
            string ad = txt_ad.Text.ToUpper();
            string soyad = txt_Soyad.Text.ToUpper();
            int dogumYıl = Convert.ToInt16(txt_dogum_yıl.Text);
            string ögrenciNo = txt_öğrenci_NO.Text;
            string sifre = txt_sifre.Text;

            KPSPublicSoapClient kps = new KPSPublicSoapClient();
            bool GercekKisi = kps.TCKimlikNoDogrula(tcNo, ad, soyad, dogumYıl);
            if (GercekKisi == true)
            {
                Ögrenci yeniögrenci = new Ögrenci();
                yeniögrenci.ögrenciTC =tcNo.ToString();
                yeniögrenci.ögrenciDurum = true;
                yeniögrenci.ögrenciNumarası =ögrenciNo.ToString();
                yeniögrenci.ÖgrenciAd = ad;
                yeniögrenci.ögrenciSoyad = soyad;
                yeniögrenci.ögrenciDoğumYıl = dogumYıl.ToString();
                yeniögrenci.ögrenciSifre = sifre;

                // Yeni öğrenciye varsayılan bakiye ekleniyor
                ögrenciBakiye yeniBakiye = new ögrenciBakiye();
                yeniBakiye.ögrenciBakiye1 = 0; // Varsayılan bakiye sıfır
                yeniBakiye.ögrenciBakiyeYüklemeTarih = DateTime.Now;

                // Yeni bakiye öğrenciye bağlanıyor
                yeniBakiye.Ögrenci.Add(yeniögrenci);
                vt.ögrenciBakiye.Add(yeniBakiye);


                int kayıt = vt.SaveChanges();
                if (kayıt>0)
                {
                    MessageBox.Show("Öğrenci Doğrulandı ve Kayıt Başarıyla Yapıldı!");
                    
                    frm_ögrenci_giris frm = new frm_ögrenci_giris();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Öğrenci Doğrulandı ama Kayıt Yapılamadı!");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Doğrulanamadı ve Kayıt Yapılamadı!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ögrenci_giris frm = new frm_ögrenci_giris();
            frm.Show();
            this.Hide();
        }

        private void frm_ögrenci_kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

