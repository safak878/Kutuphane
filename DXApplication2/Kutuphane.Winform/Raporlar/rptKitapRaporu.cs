using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Kutuphane.Business.Servisler;
using Kutuphane.Business.Yonetim;

using DevExpress.DataAccess.ObjectBinding;

namespace Kutuphane.Winform.Raporlar
{
    public partial class rptKitapRaporu : DevExpress.XtraReports.UI.XtraReport
    {
        IKitapService kitapService = new KitapManager();
        public rptKitapRaporu()
        {
            InitializeComponent();
            kitapService.OrnekOlustur(true);

            ObjectDataSource dataSource = new ObjectDataSource { DataSource = kitapService.Listele() };
            this.DataSource = dataSource;
            lblDurum.DataBindings.Add("Text", this.DataSource, "Durum");
            lblKitapKodu.DataBindings.Add("Text", this.DataSource, "KitapKodu");
            lblKitapAdi.DataBindings.Add("Text", this.DataSource, "KitapAdi");
            lblTuru.DataBindings.Add("Text", this.DataSource, "Turu");
            lblYazari.DataBindings.Add("Text", this.DataSource, "Yazar.Adi");
            lblAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");
        }

    }
}
