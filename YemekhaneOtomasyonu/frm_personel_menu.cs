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
    public partial class frm_personel_menu : Form
    {
        public Personel Personel;
        frm_personel_Giris frm_Personel_Giris = new frm_personel_Giris();
        frm_Personel_sıfre_degıs frm_Sıfre_Degıs = new frm_Personel_sıfre_degıs();


        public frm_personel_menu()
        {
            InitializeComponent();
        }

        public frm_personel_menu(Personel GirişYapanPersonel)
        {
            InitializeComponent();
            Personel = GirişYapanPersonel;
            menuAdmin.Visible = false;
            menuAscı.Visible = false;
            menuDiyetisyen.Visible = false;
            menuMuhasebe.Visible = false;
            //switch (GirişYapanPersonel.PersonelYetki.PersonelYetkiTür)
            switch (GirişYapanPersonel.PersonelYetki.PersonelYetkiTür)

            {
                //yetkilerine göre görülebilen sayfalandırma
                case "Admin": menuAdmin.Visible = true; break;
                case "Diyetisyen": menuDiyetisyen.Visible = true; break;
                case "Aşçı": menuAscı.Visible = true; break;
                case "Muhasebe": menuMuhasebe.Visible = true; break;
                default: break;

            }
            
        }

        private void hesapİşlermleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Personel_Giris.Show();
            this.Hide();
        }

        private void diyetisyenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muhasebeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_Personel_Giris.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Personel_Giris.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Personel_Giris.Show();
            this.Hide();
        }

        private void şifreDeğiştirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Sıfre_Degıs.Show();
            this.Hide();
        }

        private void şifreDeğiştirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Sıfre_Degıs.Show();
            this.Hide();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sıfre_Degıs.Show();
            this.Hide();
        }

        private void şifreDeğişirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sıfre_Degıs.Show();
            this.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_personel_Ekle frm_Personel_Ekle = new frm_personel_Ekle();
            frm_Personel_Ekle.Show();
            this.Hide();
        }

        private void frm_personel_menu_Load(object sender, EventArgs e)
        {

        }
    } 
}
