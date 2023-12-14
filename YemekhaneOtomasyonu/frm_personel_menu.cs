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
    } 
}
