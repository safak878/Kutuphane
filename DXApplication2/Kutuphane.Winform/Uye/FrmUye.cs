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

namespace Kutuphane.Winform.Uye
{
    public partial class FrmUye : DevExpress.XtraEditors.XtraForm
    {IUyeService uyeService=new UyeManager();
        public FrmUye()
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
            Listele();
        }

        private void Listele()
        {
            gridControlKitap.DataSource = uyeService.Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmUyeIslem form=new FrmUyeIslem(new Entities.Uye());
            form.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Entities.Uye uyeEntity =(Entities.Uye) gridKitap.GetFocusedRow();
            FrmUyeIslem form = new FrmUyeIslem(uyeEntity);form.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}