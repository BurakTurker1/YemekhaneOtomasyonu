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
        public frm_giriş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ögrenci_giris frm = new frm_ögrenci_giris();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_personel_Giris frm = new frm_personel_Giris();
            frm.Show();
            this.Hide();
        }
    }
}
