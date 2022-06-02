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
using DevExpress.XtraWizard;
using Kutuphane.Business.Servisler;
using Kutuphane.Business.Yonetim;
using Kutuphane.Entities;
using Kutuphane.Winform.Kitap;
using Kutuphane.Winform.Uye;

namespace Kutuphane.Winform.KitapHareket
{
    public partial class FrmKitapAlisverisIslem : DevExpress.XtraEditors.XtraForm
    {
        IBarkodService barkodService = new BarkodManager();
        IUyeService uyeService = new UyeManager();
        IKitapHareketService kitapHareketService = new KitapHareketManager();
        IKitapService kitapService = new KitapManager();
        private Entities.Kitap _kitapEntity;
        private Entities.Uye _uyeEntity;
        private Barkod _barkodEntity;
        private Entities.KitapHareket _kitapHareketentity;
        private bool duzenle = false;
        public FrmKitapAlisverisIslem(Entities.KitapHareket kitaphareketEntity=null)
        {
            InitializeComponent();
            _kitapHareketentity = kitaphareketEntity;
            kitapHareketService.OrnekOlustur(true);
            barkodService.OrnegeBagla(kitapHareketService.OrnekOlustur(false));
            uyeService.OrnegeBagla(kitapHareketService.OrnekOlustur(false));
            kitapService.OrnegeBagla(kitapHareketService.OrnekOlustur(false));
            if (kitaphareketEntity != null)
            {
                _kitapEntity = kitapService.Getir(c => c.Id == kitaphareketEntity.KitapId);
                _uyeEntity = uyeService.Getir(c => c.Id == kitaphareketEntity.UyeId);
                _barkodEntity = barkodService.Getir(c => c.Id == kitaphareketEntity.BarkodId);
                _kitapHareketentity = kitaphareketEntity;
                KitapYukle(_kitapEntity.Id);
                UyeYukle(_uyeEntity.Id);
                pageIslemSecim.Visible = false;
                duzenle = true;
                KitapVer();
            }
            else
            {
                _kitapHareketentity=new Entities.KitapHareket();
            }
        }
        private void txtKitapBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _barkodEntity = barkodService.Getir(c => c.Barkodu == txtKitapBarkod.Text);
                if (_barkodEntity == null)
                {
                    MessageBox.Show("Girdiğiniz barkod bulunamadı.");
                }
                else
                {
                    KitapYukle(_barkodEntity.KitapId);
                }

            }
        }

        private void KitapAl()
        {
            pageUyeSec.Visible = false;
            pageIslemOzeti.Visible = false;
        }

        private void KitapVer()
        {
            pageDegerlendirme.Visible = false;
        }
        private void KitapYukle(int id)
        {
            _kitapEntity = kitapService.Getir(c => c.Id == id);
            txtKitapKodu.Text = _kitapEntity.KitapKodu;
            toggleOdunc.IsOn = _kitapEntity.OduncVerilebilir;
            toggleDurum.IsOn = _kitapEntity.Durum;
            txtISBN.Text = _kitapEntity.ISBN;
            txtKitapAdi.Text = _kitapEntity.KitapAdi;
            txtYayinEvi.Text = _kitapEntity.YayinEvi;
            txtTuru.Text = _kitapEntity.Turu;
            txtBasimYili.Text = _kitapEntity.BasimYili.ToString();
            txtBaskiSayisi.Text = _kitapEntity.BaskiSayisi.ToString();
            txtCiltSayisi.Text = _kitapEntity.CiltSayisi.ToString();
            txtSayfaSayisi.Text = _kitapEntity.SayfaSayisi.ToString();
            txtDemirbasNo.Text = _kitapEntity.DemirbasNo;
            txtKitapAciklama.Text = _kitapEntity.Aciklama;
            gridControlKitapHareket.DataSource = _kitapEntity.KitapHareketleri;
            txtYazarAdi.Text = _kitapEntity.Yazar.Adi;
            txtYazarSoyadi.Text = _kitapEntity.Yazar.Soyadi;
            txtYazarDogumYeri.Text = _kitapEntity.Yazar.DogumYeri;
            txtYazarDogumYili.Text = _kitapEntity.Yazar.DogumYili.ToString();
            txtYazarAciklama.Text = _kitapEntity.Yazar.Aciklama;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKitapSec form = new FrmKitapSec(); form.ShowDialog();
            if (form.secildi == true)
            {
                KitapYukle(form.barkodEntity.KitapId);
                _barkodEntity = form.barkodEntity;
                txtKitapBarkod.Text = _barkodEntity.Barkodu;
            }
        }

        private void UyeYukle(int id)
        {
            _uyeEntity = uyeService.Getir(c => c.Id == id);
            toggleUyeDurum.IsOn = _uyeEntity.Durum;
            txtUyeBarkod.Text = _uyeEntity.Barkod;
            txtTcKimlikNo.Text = _uyeEntity.TcKimlikNo;
            txtOkulNo.Text = _uyeEntity.OkulNo.ToString();
            txtAdi.Text = _uyeEntity.Adi;
            txtSoyadi.Text = _uyeEntity.Soyadi;
            txtYabanciDil.Text = _uyeEntity.YabanciDil;
            txtUyeAciklama.Text = _uyeEntity.Aciklama;
            txtUyeKayitTarihi.Text = _uyeEntity.KayitTarihi.ToString(); txtOkulTuru.Text = _uyeEntity.Sinif.OkulTuru;
            txtSinif.Text = _uyeEntity.Sinif.Sinifi;
            txtSube.Text = _uyeEntity.Sinif.Sube;
            txtBolum.Text = _uyeEntity.Sinif.Bolumu;
            gridControlTelefon.DataSource = _uyeEntity.Telefonlar;
            gridControlAdres.DataSource = _uyeEntity.Adresler;
            gridControlUyeKitapHareket.DataSource = _uyeEntity.KitapHareketleri;
        }

        private void txtUyeBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var uyeEntity = uyeService.Getir(c => c.Barkod == txtUyeBarkod.Text);
                if (uyeEntity == null)
                {
                    MessageBox.Show("Girdiğiniz barkod bulunamadı.");
                }
                else
                {
                    UyeYukle(uyeEntity.Id);
                }

            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmUyeSec form = new FrmUyeSec();
            form.ShowDialog(); if (form._uyeEntity != null)
            {
                UyeYukle(form._uyeEntity.Id);
            }
        }
        private void calenderVerilisTarihi_DateTimeChanged(object sender, EventArgs e)
        {
            IslemOzetiGoster();
        }

        private void IslemOzetiGoster()
        {
            calenderTeslimEdilmesiGerekenTarih.DateTime = calenderVerilisTarihi.DateTime.AddDays(15);
            lblIslemOzeti.Text =
                $"İşlem Özeti\n\n{_barkodEntity.Barkodu} - {_kitapEntity.KitapAdi}\n\nYukarıda bilgileri gösterilen kitap {calenderVerilisTarihi.DateTime.ToString("d")} tarihinde 15 gün süreyle {_uyeEntity.Barkod} barkodlu {_uyeEntity.Adi} {_uyeEntity.Soyadi} üyesine {calenderTeslimEdilmesiGerekenTarih.DateTime.ToString("d")} tarihinde geri getirilmek şartıyla teslim edilecek. Onaylıyor musunuz?";
            if (chkKitapAl.Checked == false)
            {
                _kitapHareketentity.VerilisTarihi = calenderVerilisTarihi.DateTime;
                _kitapHareketentity.VerilisSuresi = 15;
            }

        }
        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            if (chkKitapAl.Checked == true)
            {
                _kitapHareketentity.DegerlendirmeYetkili = (int)ratingGenelDegerlendirme.Rating;
                _kitapHareketentity.DegerlendirmeKondisyon = (int)ratingKondisyon.Rating;
                _kitapHareketentity.DegerlendirmeZamanlama = (int)ratingZamanlama.Rating;
                _kitapHareketentity.TeslimEdildi = true;
                _kitapHareketentity.TeslimTarihi = calenderTeslimTarihi.DateTime;
            }
            else
            {
                _kitapHareketentity.UyeId = _uyeEntity.Id;

            }
            _kitapHareketentity.BarkodId = _barkodEntity.Id;
            _kitapHareketentity.KitapId = _kitapEntity.Id;

            kitapHareketService.EkleveyaGuncelle(_kitapHareketentity);
            kitapHareketService.Kaydet();
        }
        private void wizardControl1_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
        {
            //İşlem Seçim İşlemleri
            if (e.PrevPage == pageIslemSecim && e.Direction == Direction.Forward)
            {
                if (chkKitapAl.Checked == true)
                {
                    KitapAl();
                }
                else
                {
                    KitapVer();
                }
            }

            //Kitap Seçim İşlemleri
            if (e.PrevPage == pageKitapSec && e.Direction == Direction.Forward)
            {
                if (_kitapEntity == null)
                {
                    MessageBox.Show("Bir sonraki adıma geçebilmek için lütfen bir kitap seçin.");
                    e.Cancel = true;
                }
                else
                {
                    if (!_kitapEntity.OduncVerilebilir)
                    {
                        MessageBox.Show("Bu kitap ödünç verilemez.");
                        e.Cancel = true;
                    }


                    Entities.KitapHareket kitapHareketKontrol =
                        kitapHareketService.Getir(c => c.BarkodId == _barkodEntity.Id && c.TeslimEdildi == false);
                    if (chkKitapAl.Checked)
                    {
                        if (kitapHareketKontrol != null)
                        {
                            _kitapHareketentity = kitapHareketKontrol;
                        }
                        else
                        {
                            MessageBox.Show("Bu kitap zaten kütüphanede görünüyor.");
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        if (kitapHareketKontrol != null && duzenle == false)
                        {
                            MessageBox.Show(
                                $"Bu kitap {kitapHareketKontrol.Uye.Barkod} barkodlu {kitapHareketKontrol.Uye.Adi} {kitapHareketKontrol.Uye.Soyadi} üyesinde görünüyor. {kitapHareketKontrol.VerilisTarihi.AddDays(kitapHareketKontrol.VerilisSuresi).ToString("d")} tarihine kadar üyenin teslim etmesi gerekiyor.");
                            e.Cancel = true;
                        }
                    }

                }

            }
            //Üye Seçim İşlemleri
            if (e.PrevPage == pageUyeSec && _uyeEntity == null && e.Direction == Direction.Forward)
            {
                MessageBox.Show("Bir sonraki adıma geçebilmek için lütfen bir üye seçin.");
                e.Cancel = true;
            }
            //İşlem Özeti İşlemleri
            if (e.Page == pageIslemOzeti && e.Direction == Direction.Forward)
            {
                IslemOzetiGoster();
            }

        }
    }
}