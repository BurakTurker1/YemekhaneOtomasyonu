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
            short yüklenecek_Bakiye = Convert.ToInt16(txt_bakiye.Text);
            string ÖgrenciNo = txt_ögrenci_No.Text;


            // Mevcut Ögrenci kaydını veritabanından al
            Ögrenci mevcutOgrenci = vt.Ögrenci.FirstOrDefault(p => p.ögrenciNumarası == ÖgrenciNo);


            if (mevcutOgrenci != null)
            {
                ögrenciBakiye BakiyeYükle = new ögrenciBakiye();
                BakiyeYükle.ögrenciBakiye1 = yüklenecek_Bakiye;
                BakiyeYükle.ögrenciBakiyeYüklemeTarih = DateTime.Now;

                // Yeni ögrenciBakiye'yi mevcut Ögrenci ile ilişkilendir
                BakiyeYükle.Ögrenci.Add(mevcutOgrenci);

                vt.ögrenciBakiye.Add(BakiyeYükle);

                // Değişiklikleri kaydet
                int sonuc = vt.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show(yüklenecek_Bakiye + " TL bakiye yüklendi");
                    // Güncellenmiş bakiyeyi göster
                    lbl_bakiye.Text = BakiyeYükle.ögrenciBakiye1?.ToString();
                }
                else
                {
                    MessageBox.Show("Bakiye yüklenemedi!");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı!");
            }
        }
        

        private void frm_ögrenci_bakiye_yükle_Load(object sender, EventArgs e)
        {

        }
    }
}
