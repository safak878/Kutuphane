using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Kutuphane.Winform.Raporlar
{
    public partial class FrmRaporListesi : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor;
        public FrmRaporListesi()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            rapor =new rptKitapRaporu();
            filterControl1.SourceControl = rapor.DataSource;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rapor.FilterString = filterControl1.FilterString;
            FrmRaporGoruntule form=new FrmRaporGoruntule(rapor);
            form.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            rapor = new rptUyeKitapHareketleri();
            filterControl1.SourceControl = rapor.DataSource;
        }
    }
}