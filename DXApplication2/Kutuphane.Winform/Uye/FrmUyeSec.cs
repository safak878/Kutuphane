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
    public partial class FrmUyeSec : DevExpress.XtraEditors.XtraForm
    {
        IUyeService uyeService=new UyeManager();
        public Entities.Uye _uyeEntity;
        public FrmUyeSec()
        {
            InitializeComponent();
            uyeService.OrnekOlustur(true);
            gridControlUye.DataSource = uyeService.Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _uyeEntity = (Entities.Uye) gridUye.GetFocusedRow();
            this.Close();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}