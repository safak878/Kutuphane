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

namespace Kutuphane.Winform.Yazar
{
    public partial class FrmYazarIslem : DevExpress.XtraEditors.XtraForm
    {
        IYazarService yazarService=new YazarManager();
        IKitapService kitapService=new KitapManager();
        private Entities.Yazar _yazarEntity;
        public bool kaydedildi = false;
        public FrmYazarIslem(Entities.Yazar yazarEntity)
        {
            InitializeComponent();
            yazarService.OrnekOlustur(true);
            kitapService.OrnegeBagla(yazarService.OrnekOlustur(false));
            _yazarEntity = yazarEntity;
            txtYazarAdi.DataBindings.Add("Text", _yazarEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarSoyadi.DataBindings.Add("Text", _yazarEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarDogumYeri.DataBindings.Add("Text", _yazarEntity, "DogumYeri", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarDogumYili.DataBindings.Add("Text", _yazarEntity, "DogumYili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYazarAciklama.DataBindings.Add("Text", _yazarEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            gridControlYazarKitap.DataSource= kitapService.Listele(c => c.YazarId == _yazarEntity.Id);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yazarService.EkleveyaGuncelle(_yazarEntity);
            yazarService.Kaydet();
            kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}