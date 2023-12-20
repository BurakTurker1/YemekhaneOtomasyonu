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
    public partial class frm_Kullanıcı_menu : Form
    {
        public Kullanıcı Kullanıcı;
        frm_Kullanıcı_sifre_degis frm_Personel_Sıfre_Degıs = new frm_Kullanıcı_sifre_degis();


        public frm_Kullanıcı_menu()
        {
            InitializeComponent();
        }

        public frm_Kullanıcı_menu(Kullanıcı GirişYapanPersonel)
        {
            InitializeComponent();
            Kullanıcı = GirişYapanPersonel;
            menuAdmin.Visible = false;
            menuAscı.Visible = false;
            menuDiyetisyen.Visible = false;
            menuMuhasebe.Visible = false;
            menuÖgrenci.Visible = false;
            //switch (GirişYapanPersonel.PersonelYetki.PersonelYetkiTür)
            switch (GirişYapanPersonel.KullanıcıYetki.KullancıYetkiTür)

            {
                //yetkilerine göre görülebilen sayfalandırma
                case "Admin": menuAdmin.Visible = true; break;
                case "Diyetisyen": menuDiyetisyen.Visible = true; break;
                case "Aşçı": menuAscı.Visible = true; break;
                case "Muhasebe": menuMuhasebe.Visible = true; break;
                case "Öğrenci": menuÖgrenci.Visible = true; break;
                case "test":menuAdmin.Visible = true;
                    menuAscı.Visible = true;
                    menuDiyetisyen.Visible = true;
                    menuMuhasebe.Visible=true;
                    menuÖgrenci.Visible=true; break;
                default: break;

            }
            
        }

        public void çıkışyap()
        {
            frm_giriş giriş = new frm_giriş();
            giriş.Show();
            this.Hide();
        }
        public void sifreDegis()
        {
            frm_Kullanıcı_sifre_degis sifre_Degis = new frm_Kullanıcı_sifre_degis();
            sifre_Degis.MdiParent= this;
            sifre_Degis.Show();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kullanıcıEkle frm_Kullanıcı = new frm_kullanıcıEkle();
            frm_Kullanıcı.MdiParent = this;
            frm_Kullanıcı.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            çıkışyap();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            çıkışyap();

        }

        private void çıkışYapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            çıkışyap();

        }

        private void çıkışYapToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            çıkışyap();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            çıkışyap();

        }

        private void şifreDeğişirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreDegis();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreDegis();

        }

        private void şifreDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sifreDegis();

        }

        private void şifreDeğiştirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sifreDegis();

        }

        private void şifreDeğişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreDegis();

        }

        private void hesapİşlermleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bakiyeYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ögrenci_bakiye_yükle frm_Ögrenci_Bakiye = new frm_ögrenci_bakiye_yükle(Kullanıcı);
            frm_Ögrenci_Bakiye.MdiParent = this;
            frm_Ögrenci_Bakiye.Show();
        }

        private void yemekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yemek_al yemek_Al= new frm_yemek_al(Kullanıcı);
            yemek_Al.MdiParent = this;
            yemek_Al.Show();
        }

        private void ascıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yemek_stok_belirle yemek_stok = new frm_yemek_stok_belirle();
            yemek_stok.MdiParent = this;
            yemek_stok.Show();
        }

        private void diyetisyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yemek_Ekle yemek_Ekle = new frm_yemek_Ekle();
            yemek_Ekle.MdiParent = this;
            yemek_Ekle.Show();
        }

        private void muhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yemek_fiyat_belirle Yemek_Fiyat = new frm_yemek_fiyat_belirle();
            Yemek_Fiyat.MdiParent= this;
            Yemek_Fiyat.Show();
        }

        private void frm_Kullanıcı_menu_Load(object sender, EventArgs e)
        {

        }
    } 
}
