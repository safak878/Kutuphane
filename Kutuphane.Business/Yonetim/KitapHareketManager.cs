using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.Business.Dogrulamalar;
using Kutuphane.Business.Servisler;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.DataAccess.VeriErisim;
using Kutuphane.Entities;

namespace Kutuphane.Business.Yonetim
{
    public class KitapHareketManager : YonetimSablonu<KitapHareket, KitapHareketDal, KitapHareketValidator>, IKitapHareketService
    {
        public object EnCokOkunan(int kayitSayisi)
        {
            return _dal.EnCokOkunan(kayitSayisi);
        }

        public object EnCokOkuyan(int kayitSayisi)
        {
            return _dal.EnCokOkuyan(kayitSayisi);
        }
    }
}
