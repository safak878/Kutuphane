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
using Kutuphane.Winform.Uye;

namespace Kutuphane.Winform.Sınıf
{
    public partial class FrmSinif : DevExpress.XtraEditors.XtraForm
    {
        ISinifService sinifService = new SinifManager();
        IUyeService uyeService=new UyeManager();
        private List<Sinif> sinifListe;
        public FrmSinif()
        {
            InitializeComponent();
            Listele();
    
        }

        private void Listele()
        {
            sinifService.OrnekOlustur(true);
            uyeService.OrnegeBagla(sinifService.OrnekOlustur(false));
            sinifListe = sinifService.Listele();
            gridControlSinif.DataSource = sinifListe;}
        private void gridSinif_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridControlUye.DataSource = sinifListe[gridSinif.FocusedRowHandle].Uyeler;
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            FrmSinifIslem form = new FrmSinifIslem(new Sinif());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifDuzenle_Click(object sender, EventArgs e)
        {
            Sinif sinifEntity = (Sinif)gridSinif.GetFocusedRow();
            FrmSinifIslem form = new FrmSinifIslem(sinifEntity);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            Sinif sinifEntity = (Sinif)gridSinif.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sinifService.Sil(sinifEntity);
                sinifService.Kaydet();
                Listele();
            }
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            Listele();}

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeIslem form=new FrmUyeIslem(new Entities.Uye());
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity = (Entities.Uye) layoutUye.GetFocusedRow();
            FrmUyeIslem form = new FrmUyeIslem(uyeEntity);
            form.ShowDialog();
            if (form.kaydedildi)
            {
                Listele();
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity = (Entities.Uye)layoutUye.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uyeService.Sil(uyeEntity);
                uyeService.Kaydet();
                Listele();
            }
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();}
    }
}