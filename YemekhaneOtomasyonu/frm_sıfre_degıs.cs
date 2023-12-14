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
    public partial class frm_sıfre_degıs : Form
    {
        public frm_sıfre_degıs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Eposta = txt_Tc.Text;
            string eskiSifre = txt_eski_sifre.Text;
            string yeniSifre = txt_yeni_sifre.Text;

            using (Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities())
            {
                try
                {
                    // Veritabanında e-posta ve eski şifre ile personeli bul
                    Personel personel = vt.Personel.FirstOrDefault(p => p.PersonelGmail == Eposta && p.PersonelSifre == eskiSifre);

                    if (personel != null)
                    {
                        // Personel bulundu, şifreyi güncelle
                        personel.PersonelSifre = yeniSifre;
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
