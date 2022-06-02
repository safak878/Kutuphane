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

namespace Kutuphane.Winform.Kitap
{
    public partial class FrmKitap : DevExpress.XtraEditors.XtraForm
    {
        private IKitapService kitapService = new KitapManager();
        public FrmKitap()
        {
            InitializeComponent();
            kitapService.OrnekOlustur(true);
            Listele();

        }

        private void Listele()
        {
            gridControlKitap.DataSource = kitapService.Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmKitapIslem form = new FrmKitapIslem(new Entities.Kitap());
            form.ShowDialog();
            if (form.Kaydedildi == true)
            {
                Listele();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridKitap.GetFocusedRowCellValue(colId));
            FrmKitapIslem form = new FrmKitapIslem(kitapService.Getir(c => c.Id == id));
            form.ShowDialog();
            if (form.Kaydedildi == true)
            {
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();}

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Entities.Kitap Silinecek = (Entities.Kitap)gridKitap.GetFocusedRow();
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kitapService.Sil(c => c.Id == Silinecek.Id);
                kitapService.Kaydet();
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}