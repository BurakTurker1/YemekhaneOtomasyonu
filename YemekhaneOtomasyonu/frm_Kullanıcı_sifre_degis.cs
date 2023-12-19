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
        public frm_Kullanıcı_sifre_degis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tcNo = txt_Tc.Text;
            string eskiSifre = txt_eski_sifre.Text;
            string yeniSifre = txt_yeni_sifre.Text;

            using (Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities())
            {
                try
                {
                    // Veritabanında e-posta ve eski şifre ile kullanıcıi bul
                    Kullanıcı kullanıcı = vt.Kullanıcı.FirstOrDefault(p => p.kTc == tcNo && p.kSifre == eskiSifre);

                    if (kullanıcı != null)
                    {
                        // kullanıcı bulundu, şifreyi güncelle
                        kullanıcı.kSifre = yeniSifre;
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
