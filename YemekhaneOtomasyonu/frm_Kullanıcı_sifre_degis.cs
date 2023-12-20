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
    public partial class frm_Kullanıcı_sifre_degis : Form
    {
        Kullanıcı Kullanıcı;
        public frm_Kullanıcı_sifre_degis()
        {
            InitializeComponent();
        }
        public frm_Kullanıcı_sifre_degis(Kullanıcı GirisYapanKullancı)
        {
            InitializeComponent();
            Kullanıcı = GirisYapanKullancı;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eskiSifre = txt_eski_sifre.Text;
            string yeniSifre = txt_yeni_sifre.Text;

            using (Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities())
            {
                try
                {
                    Kullanıcı = vt.Kullanıcı.FirstOrDefault(p => p.kTc == Kullanıcı.kTc && p.kSifre == eskiSifre);

                    if (Kullanıcı != null)
                    {
                        Kullanıcı.kSifre = yeniSifre;
                        vt.SaveChanges();

                        MessageBox.Show("Şifre başarıyla değiştirildi");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı veya eski şifre hatalı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            
            }
        
        }

    }
}
