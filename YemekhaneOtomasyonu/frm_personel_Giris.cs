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
    public partial class frm_personel_Giris : Form
    {
        public Personel girisYapanPersonel;
        public frm_personel_Giris()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            frm_giriş frm = new frm_giriş();
            frm.Show();
            this.Hide();
        }

        private void btn_personel_giris_Click(object sender, EventArgs e)
        {
            string personelEmail = txt_Eposta.Text;
            string personelSifre = txt_sifre.Text;
            Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();

            girisYapanPersonel = vt.Personel.FirstOrDefault(p => p.PersonelGmail == personelEmail && personelSifre == personelSifre);
            if (girisYapanPersonel != null)
            {
                MessageBox.Show("giriş başarılı");

              frm_personel_menu frm_Personel_Menu = new frm_personel_menu(girisYapanPersonel);
              frm_Personel_Menu.Show();
              this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }

        }

        private void frm_personel_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
