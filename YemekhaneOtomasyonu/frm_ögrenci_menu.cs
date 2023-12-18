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
    public partial class frm_ögrenci_menu : Form
    {
        public frm_ögrenci_menu()
        {
            InitializeComponent();
        }
        public frm_ögrenci_menu(Ögrenci girisYapanÖgrenci)
        {
            InitializeComponent();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ögrenci_giris frm_Ögrenci_Giris = new frm_ögrenci_giris();
            frm_Ögrenci_Giris.Show();
            this.Hide();
        }

        private void şifreDeğişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ögrenci_Sifre_degis frm = new frm_ögrenci_Sifre_degis();
            frm.Show();
            this.Hide();
        }

        private void bakiyeYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ögrenci_bakiye_yükle _Bakiye_Yükle = new frm_ögrenci_bakiye_yükle();
            _Bakiye_Yükle.Show();
            this.Hide();
        }

        private void yemekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_yemek_al frm = new frm_yemek_al();
            frm.Show();
            this.Hide();
        }

        private void haftalıkYemekListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Haftalık_yemek_listele frm = new frm_Haftalık_yemek_listele();
            frm.Show();
            this.Hide();
        }

        private void frm_ögrenci_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
