using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kutuphane.Winform.Kitap;
using Kutuphane.Winform.KitapHareket;
using Kutuphane.Winform.Raporlar;
using Kutuphane.Winform.Sınıf;
using Kutuphane.Winform.Uye;


namespace Kutuphane.Winform
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmUye>().Any())
            {
                FrmUye form = new FrmUye();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmSinif>().Any())
            {
                FrmSinif form = new FrmSinif();
                form.MdiParent = this; form.Show();
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmKitap>().Any())
            {
                FrmKitap form = new FrmKitap();
                form.MdiParent = this;
                form.Show();
            }
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmKitapAlisveris>().Any())
            {
                FrmKitapAlisveris form = new FrmKitapAlisveris();
                form.MdiParent = this; form.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmKitapHareket>().Any())
            {
                FrmKitapHareket form = new FrmKitapHareket();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmEnler>().Any())
            {
                FrmEnler form = new FrmEnler();
                form.MdiParent = this;
                form.Show();
            }
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Application.OpenForms.OfType<FrmRaporListesi>().Any())
            {
                FrmRaporListesi form = new FrmRaporListesi();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
