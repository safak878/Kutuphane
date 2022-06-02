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
    public partial class FrmKitapAlisveris : DevExpress.XtraEditors.XtraForm
    {
        IKitapHareketService kitapHareketService = new KitapHareketManager();
        public FrmKitapAlisveris()
        {
            InitializeComponent();
            kitapHareketService.OrnekOlustur(true);
            Listele();
        }
        private void Listele()
        {
            kitapHareketService.OrnekOlustur(true);
            gridControl1.DataSource = kitapHareketService.Listele(c => c.TeslimEdildi == false);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKitapAlisverisIslem form = new FrmKitapAlisverisIslem();
            form.ShowDialog();
            Listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var secilen = (Entities.KitapHareket)gridView1.GetFocusedRow();
            FrmKitapAlisverisIslem form = new FrmKitapAlisverisIslem(secilen);
            form.ShowDialog();
            Listele();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
      
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Entities.KitapHareket Silinecek = (Entities.KitapHareket)gridView1.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kitapHareketService.Sil(Silinecek);
                kitapHareketService.Kaydet();
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}