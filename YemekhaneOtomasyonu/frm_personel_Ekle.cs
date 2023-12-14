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
    public partial class frm_personel_Ekle : Form
    {
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        public frm_personel_Ekle()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            long tcNo = Convert.ToInt64(txt_Tc_No.Text);
            int Dogumyıl =Convert.ToInt16(txt_dogum_yıl.Text);  
            string isim = txt_ad.Text.ToUpper();
            string soyad = txt_Soyad.Text.ToUpper();
            string eposta = txt_Eposta.Text;
            string sifre = txt_sifre.Text;
            int yetki = Convert.ToInt16(cmb_yetki.SelectedValue);
            //MessageBox.Show("yetki:"+yetki);
            
            KPSPublicSoapClient kps = new KPSPublicSoapClient();
            bool Gercekkisi = kps.TCKimlikNoDogrula(tcNo, isim, soyad, Dogumyıl);
            if (Gercekkisi == true)
            {
                Personel yeniPersonel = new Personel();
                yeniPersonel.PersonelTCNo = tcNo.ToString();
                yeniPersonel.personelAD = isim;
                yeniPersonel.PersonleSoyad = soyad;
                yeniPersonel.PersonelGmail = eposta;
                yeniPersonel.PersonelSifre = sifre;
                yeniPersonel.PersonelYetkiID = yetki;
                yeniPersonel.PersonelCinsiyet = rb_Kadın.Checked ? "KADIN" : "ERKEK";
                vt.Personel.Add(yeniPersonel);
                int sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Personel Doğrulandı ve Kayıt Başarıyla Yapıldı!");
                }
                else
                {
                    MessageBox.Show("Personel Doğrulandı ama Kayıt Yapılamadı!");
                }
            }
            else
            {
                MessageBox.Show("Personel Doğrulanamadı ve Kayıt Yapılamadı!");
            }

            

           
        }

        private void frm_personel_Ekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Personel);
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.PersonelYetki' table. You can move, or remove it, as needed.
            this.personelYetkiTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.PersonelYetki);

        }
    }
}
