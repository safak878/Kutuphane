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

namespace Kutuphane.Winform.Kitap
{
    public partial class FrmKitapSec : DevExpress.XtraEditors.XtraForm
    {
        IKitapService kitapService = new KitapManager();
        public Barkod barkodEntity;
        public bool secildi = false;
        public FrmKitapSec()
        {
            InitializeComponent();
            kitapService.OrnekOlustur(true);
            gridControlKitap.DataSource = kitapService.Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (navigationFrame1.SelectedPage == navigationPage1)
            {
                Entities.Kitap kitapEntity = (Entities.Kitap)gridKitap.GetFocusedRow();
                navigationFrame1.SelectedPage = navigationPage2;
                gridControlBarkod.DataSource = kitapEntity.Barkodlar;
                lblBaslik.Text = "Lütfen Bir Barkod Seçin - " + kitapEntity.KitapAdi;

            }
            else
            {
                barkodEntity = (Barkod)gridBarkod.GetFocusedRow();

                secildi = true;
                this.Close();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
            lblBaslik.Text = "Lütfen Bir Kitap Seçin";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}