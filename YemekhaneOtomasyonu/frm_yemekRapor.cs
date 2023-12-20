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
    public partial class frm_yemekRapor : Form
    {
        public frm_yemekRapor()
        {
            InitializeComponent();
        }

        private void frm_yemekRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Yemek' table. You can move, or remove it, as needed.
            this.yemekTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Yemek);

            this.reportViewer1.RefreshReport();
        }
    }
}
