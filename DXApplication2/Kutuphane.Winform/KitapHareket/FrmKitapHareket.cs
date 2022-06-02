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
using Kutuphane.Business.Servisler;
using Kutuphane.Business.Yonetim;

namespace Kutuphane.Winform.KitapHareket
{
    public partial class FrmKitapHareket : DevExpress.XtraEditors.XtraForm
    {
        IKitapHareketService kitapHareketService=new KitapHareketManager();
        public FrmKitapHareket()
        {
            InitializeComponent();
            kitapHareketService.OrnekOlustur(true);
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = kitapHareketService.Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Entities.KitapHareket kitapHareketEntity = (Entities.KitapHareket) gridView1.GetFocusedRow();
            kitapHareketEntity.TeslimEdildi = false;
            kitapHareketEntity.TeslimTarihi = null;
            kitapHareketService.EkleveyaGuncelle(kitapHareketEntity);
            kitapHareketService.Kaydet();
            Listele();}

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}