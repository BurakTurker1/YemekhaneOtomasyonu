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
    public partial class frm_giriş : Form
    {
        public Kullanıcı GirisYapanKullancı;
        public frm_giriş()
        {
            InitializeComponent();
        }
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string TcNo = mtxt_Tc.Text;
            string sifre = txt_sifre.Text;
            GirisYapanKullancı = vt.Kullanıcı.FirstOrDefault(p => p.kTc == TcNo && p.kSifre == sifre);
            if (GirisYapanKullancı != null)
            {
                frm_Kullanıcı_menu frm = new frm_Kullanıcı_menu(GirisYapanKullancı);
                frm.Show();
                this.Hide();
            }


        }
    }
}
