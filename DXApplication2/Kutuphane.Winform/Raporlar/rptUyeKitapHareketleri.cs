using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using Kutuphane.Business.Servisler;
using Kutuphane.Business.Yonetim;

namespace Kutuphane.Winform.Raporlar
{
    public partial class rptUyeKitapHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        IKitapHareketService kitapHareketService=new KitapHareketManager();
        public rptUyeKitapHareketleri()
        {
            InitializeComponent();kitapHareketService.OrnekOlustur(true);
            ObjectDataSource dataSource=new ObjectDataSource{DataSource = kitapHareketService.Listele()};
            this.DataSource = dataSource;
            colKitapKodu.DataBindings.Add("Text", this.DataSource, "Kitap.KitapKodu");
            colTeslimEdildi.DataBindings.Add("Text", this.DataSource, "TeslimEdildi");
            colKitapAdi.DataBindings.Add("Text", this.DataSource, "Kitap.KitapAdi");
            colVerilisTarihi.DataBindings.Add("Text", this.DataSource, "VerilisTarihi","{0:d}");
            colTeslimTarihi.DataBindings.Add("Text", this.DataSource, "TeslimTarihi", "{0:d}");
            colAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");
        }

    }
}
