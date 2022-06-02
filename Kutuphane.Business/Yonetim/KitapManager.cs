using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.Business.Dogrulamalar;
using Kutuphane.Business.Servisler;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.VeriErisim;
using Kutuphane.Entities;

namespace Kutuphane.Business.Yonetim
{
    public class KitapManager : YonetimSablonu<Kitap, KitapDal,KitapValidator>, IKitapService
    {
        public Kitap IdDegerineGoreGetir(int Id)
        {
            return this.Getir(c => c.Id == Id);
        }

        public override Kitap Sil(Kitap entity)
        {
            IKitapHareketService kitapHareketService = new KitapHareketManager();
            kitapHareketService.Sil(c => c.KitapId == entity.Id);
            return base.Sil(entity);
        }
    }
}
