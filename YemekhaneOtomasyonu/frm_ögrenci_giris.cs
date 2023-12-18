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
    public partial class frm_ögrenci_giris : Form
    {
        public Ögrenci girisYapanÖgrenci;
        public frm_ögrenci_giris()
        {
            InitializeComponent();
        }

        private void frm_ögrenci_giris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_giriş frm = new frm_giriş();
            frm.Show();
            this.Hide();
        }

        private void btn_ögrenci_giris_Click(object sender, EventArgs e)
        {
            string ögrenciNo = txt_ögrenci_no.Text;
            string ögrenciSifre = txt_sifre.Text;

            Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();

            girisYapanÖgrenci = vt.Ögrenci.FirstOrDefault(p => p.ögrenciNumarası == ögrenciNo && p.ögrenciSifre == ögrenciSifre);
            if (girisYapanÖgrenci != null)
            {
               MessageBox.Show("Giriş Başarılı");

                //giris yapan ögrenciyi gönderme
                frm_ögrenci_bakiye_yükle frm_Ögrenci_Bakiye_Yükle = new frm_ögrenci_bakiye_yükle();


                frm_ögrenci_menu frm = new frm_ögrenci_menu(girisYapanÖgrenci);
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);

            }
        }

        private void btn_ögrenci_kayıt_ol_Click(object sender, EventArgs e)
        {
            frm_ögrenci_kayıt frm = new frm_ögrenci_kayıt();
            frm.Show();
            this.Hide();
        }
    }
}
