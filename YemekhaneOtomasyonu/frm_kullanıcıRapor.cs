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
    public partial class frm_kullanıcıRapor : Form
    {
        public frm_kullanıcıRapor()
        {
            InitializeComponent();
        }

        private void frm_kullanıcıRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekhane_OtomasyonDataSet.Kullanıcı' table. You can move, or remove it, as needed.
            this.kullanıcıTableAdapter.Fill(this.yemekhane_OtomasyonDataSet.Kullanıcı);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
