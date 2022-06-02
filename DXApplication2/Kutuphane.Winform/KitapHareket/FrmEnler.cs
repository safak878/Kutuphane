using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Kutuphane.Business.Servisler;
using Kutuphane.Business.Yonetim;

namespace Kutuphane.Winform.KitapHareket
{
    public partial class FrmEnler : DevExpress.XtraEditors.XtraForm
    {
        IKitapHareketService kitapHareketService = new KitapHareketManager();
        public FrmEnler(){
            InitializeComponent();
            kitapHareketService.OrnekOlustur(true);
            chartControl1.Series.Add("En Çok Okunanlar", ViewType.Bar);
            chartControl1.DataSource = kitapHareketService.EnCokOkunan(5);
            gridControlKitap.DataSource = kitapHareketService.EnCokOkunan(5);
            chartControl1.Series[0].ArgumentDataMember = "kitap.KitapAdi"; 
            chartControl1.Series[0].ValueDataMembers[0] = "OkunmaSayisi";


            chartControl2.Series.Add("En Çok Okuyanlar", ViewType.Bar); 
            chartControl2.DataSource= kitapHareketService.EnCokOkuyan(5);
            gridControl1.DataSource = kitapHareketService.EnCokOkuyan(5);
            chartControl2.Series[0].ArgumentDataMember = "uye.Adi";
            chartControl2.Series[0].ValueDataMembers[0] = "OkunmaSayisi";

        }

        private void FrmEnler_Load(object sender, EventArgs e)
        {


        }
    }
}