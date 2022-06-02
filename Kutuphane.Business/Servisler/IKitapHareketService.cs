using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.Entities;

namespace Kutuphane.Business.Servisler
{
   public interface IKitapHareketService:IServisSablonu<KitapHareket>
   {
       object EnCokOkunan(int kayitSayisi);
       object EnCokOkuyan(int kayitSayisi);
    }
}
