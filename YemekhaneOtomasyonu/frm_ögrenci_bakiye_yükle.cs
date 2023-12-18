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
    public partial class frm_ögrenci_bakiye_yükle : Form
    {

        public frm_ögrenci_bakiye_yükle()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            frm_ögrenci_menu frm = new frm_ögrenci_menu();
            frm.Show();
            this.Hide();
        }
        Yemekhane_OtomasyonEntities vt = new Yemekhane_OtomasyonEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            int yüklenecek_Bakiye = Convert.ToInt16(txt_bakiye.Text);
            string ÖgrenciNo = txt_ögrenci_No.Text;

            ögrenciBakiye bakiyeYükle = new ögrenciBakiye();
           Ögrenci Güncelögrenci =vt.Ögrenci.FirstOrDefault(p => p.ögrenciNumarası == ÖgrenciNo);
            if(Güncelögrenci != null)
            {
                int güncelBakiye = Güncelögrenci.ögrenciBakiye.ögrenciBakiye1 ?? 0 ;// null değilse devam et anlamında ??
                güncelBakiye += yüklenecek_Bakiye;
                Güncelögrenci.ögrenciBakiye.ögrenciBakiye1 = güncelBakiye;
                int sonuc = vt.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show(yüklenecek_Bakiye + "TL Bakiye Hesabınıza Yüklenmiştir");
                    lbl_bakiye.Text = güncelBakiye.ToString();
                }
                else
                {
                    MessageBox.Show("Bakiye Yüklenemedi!!!");
                }
            }

        }

        private void frm_ögrenci_bakiye_yükle_Load(object sender, EventArgs e)
        {
            // sayfa yüklendigine ilk bakiye gösterilecek

        }
       
    }
}
