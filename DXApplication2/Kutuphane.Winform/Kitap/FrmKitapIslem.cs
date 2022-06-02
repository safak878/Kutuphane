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
using Kutuphane.Entities;
using Kutuphane.Winform.Tanım;
using Kutuphane.Winform.Yazar;


namespace Kutuphane.Winform.Kitap
{
    public partial class FrmKitapIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Kitap _entity;
        private Barkod _barkodEntity = new Barkod();

        IKitapService kitapService = new KitapManager();
        IBarkodService barkodService = new BarkodManager();
        IYazarService yazarService = new YazarManager();

        public bool Kaydedildi = false;
        public FrmKitapIslem(Entities.Kitap entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleDurum.DataBindings.Add("EditValue", _entity, "Durum", false, DataSourceUpdateMode.OnPropertyChanged);
            toggleOdunc.DataBindings.Add("EditValue", _entity, "OduncVerilebilir", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitapKodu.DataBindings.Add("Text", _entity, "KitapKodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTuru.DataBindings.Add("Text", _entity, "Turu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtISBN.DataBindings.Add("Text", _entity, "ISBN", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitapAdi.DataBindings.Add("Text", _entity, "KitapAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtYayinEvi.DataBindings.Add("Text", _entity, "YayinEvi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBasimYili.DataBindings.Add("Text", _entity, "BasimYili", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBaskiSayisi.DataBindings.Add("Text", _entity, "BaskiSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtCiltSayisi.DataBindings.Add("Text", _entity, "CiltSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSayfaSayisi.DataBindings.Add("Text", _entity, "SayfaSayisi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDemirbasNo.DataBindings.Add("Text", _entity, "DemirbasNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKitapAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

            kitapService.OrnekOlustur(true);
            barkodService.OrnegeBagla(kitapService.OrnekOlustur(false));
            yazarService.OrnegeBagla(kitapService.OrnekOlustur(false));
            gridControlBarkod.DataSource = barkodService.BaglantiNesnesi(c => c.KitapId == _entity.Id);
            YazarListele();
        }
        private void YazarListele()
        {
            searchYazar.Properties.DataSource = yazarService.Listele();
            searchYazar.Properties.DisplayMember = "Adi";
            searchYazar.Properties.ValueMember = "Id";
            if (_entity.YazarId != 0)
            {
                YazarYukle(_entity.YazarId);
            }

        }
        private void BarkodBinding()
        {
            txtBarkod.DataBindings.Clear();
            txtSalon.DataBindings.Clear();
            txtDolap.DataBindings.Clear();
            txtRaf.DataBindings.Clear();
            txtSira.DataBindings.Clear();
            txtBarkodAciklama.DataBindings.Clear();
            ratingKondisyon.DataBindings.Clear();
            txtBarkod.DataBindings.Add("Text", _barkodEntity, "Barkodu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSalon.DataBindings.Add("Text", _barkodEntity, "Salon", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDolap.DataBindings.Add("Text", _barkodEntity, "Dolap", false, DataSourceUpdateMode.OnPropertyChanged);
            txtRaf.DataBindings.Add("Text", _barkodEntity, "Raf", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSira.DataBindings.Add("Text", _barkodEntity, "Sira", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBarkodAciklama.DataBindings.Add("Text", _barkodEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            ratingKondisyon.DataBindings.Add("EditValue", _barkodEntity, "Kondisyon", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (kitapService.EkleveyaGuncelle(_entity) != null)
            {
                kitapService.Kaydet();
                Kaydedildi = true;
                this.Close();
            }
        }

        private void BarkodKayitAc()
        {
            groupBarkodBilgi.Visible = true;
            gridControlBarkod.Enabled = false;
            groupMenu.Enabled = false;
            btnBarkodEkle.Enabled = false;
            btnBarkodDuzenle.Enabled = false;
            btnBarkodSil.Enabled = false;
            btnBarkodKaydet.Enabled = true;
            btnBarkodVazgec.Enabled = true;
        }
        private void BarkodKayitKapat()
        {
            groupBarkodBilgi.Visible = false;
            gridControlBarkod.Enabled = true;
            groupMenu.Enabled = true;
            btnBarkodEkle.Enabled = true;
            btnBarkodDuzenle.Enabled = true;
            btnBarkodSil.Enabled = true;
            btnBarkodKaydet.Enabled = false;
            btnBarkodVazgec.Enabled = false;
        }
        private void btnBarkodEkle_Click(object sender, EventArgs e)
        {
            BarkodKayitAc();
            _barkodEntity = new Barkod();
            BarkodBinding();
        }
        private void btnBarkodDuzenle_Click(object sender, EventArgs e)
        {
            BarkodKayitAc();
            _barkodEntity = (Barkod)layoutBarkod.GetFocusedRow();
            BarkodBinding();
        }
        private void btnBarkodKaydet_Click(object sender, EventArgs e)
        {
            _barkodEntity.KitapId = _entity.Id;
            if (barkodService.EkleveyaGuncelle(_barkodEntity) != null)
            {
                BarkodKayitKapat();
            }
        }

        private void btnBarkodVazgec_Click(object sender, EventArgs e)
        {
            _barkodEntity = null;
            BarkodKayitKapat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchYazar_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (searchYazar.Properties.View.SelectedRowsCount != 0)
            {
                var id = (int)searchYazar.Properties.View.GetFocusedRowCellValue(colYazarId);

                YazarYukle(id);
            }
        }
        private void YazarYukle(int id)
        {
            _entity.YazarId = id;
            var yazarEntity = yazarService.Getir(c => c.Id == id);
            searchYazar.EditValue = yazarEntity.Id;
            txtYazarSoyadi.Text = yazarEntity.Soyadi;
            txtYazarDogumYeri.Text = yazarEntity.DogumYeri;
            txtYazarDogumYili.Text = yazarEntity.DogumYili.ToString();
            txtYazarAciklama.Text = yazarEntity.Aciklama;
            gridControlYazarKitap.DataSource = kitapService.Listele(c => c.YazarId == id);
        }

        private void searchYazar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                FrmYazarIslem form = new FrmYazarIslem(new Entities.Yazar());
                form.ShowDialog();
                if (form.kaydedildi == true)
                {
                    YazarListele();
                }
            }
        }

        private void txtTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(FrmTanim.Turu.KitapTuru);
            form.ShowDialog();
            if (form.secildi == true)
            {
                txtTuru.Text = form._tanimEntity.Tanimi;
            }
        }

        private void btnBarkodSil_Click(object sender, EventArgs e)
        {
            //Barkod Silinecek = (Barkod)layoutBarkod.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                layoutBarkod.DeleteSelectedRows();
            }

        }
    }
}