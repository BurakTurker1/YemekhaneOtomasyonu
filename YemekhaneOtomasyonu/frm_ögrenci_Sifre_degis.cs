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
    public partial class frm_ögrenci_Sifre_degis : Form
    {
        public frm_ögrenci_Sifre_degis()
        {
            InitializeComponent();
        }

        private void btn_ögrenci_sifre_degis_Click(object sender, EventArgs e)
        {
            string ögrenciNo = txt_ögrenci_no.Text;
            string eskiSifre = txt_eski_sifre.Text;
            string yeniSifre = txt_yeni_sifre.Text;

            using (Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities())
            {
                try
                {
                    // Veritabanında e-posta ve eski şifre ile personeli bul
                    Ögrenci ögrenci = vt.Ögrenci.FirstOrDefault(p => p.ögrenciNumarası == ögrenciNo && p.ögrenciSifre == eskiSifre);

                    if (ögrenci != null)
                    {
                        // Personel bulundu, şifreyi güncelle
                        ögrenci.ögrenciSifre = yeniSifre;
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

