using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.Entities;

namespace Kutuphane.DataAccess.VeriErisim{public class KitapHareketDal : EntityAnaSablon<KitapHareket, KutuphaneContext>, IKitapHareketDal
    {
        public object EnCokOkunan(int kayitSayisi)
        {
            return _context.Kitaplar.GroupJoin(_context.KitapHareketleri, c => c.Id, c => c.KitapId,
                (kitap, kitapHareket) => new
                {
                    kitap,
                    OkunmaSayisi = kitapHareket.Count()
                }).OrderByDescending(c=>c.OkunmaSayisi).Take(kayitSayisi).ToList();
        }

        public object EnCokOkuyan(int kayitSayisi)
        {
            return _context.Uyeler.GroupJoin(_context.KitapHareketleri, c => c.Id, c => c.UyeId,
                (uye, kitapHareket) => new
                {
                    uye,
                    OkunmaSayisi = kitapHareket.Count()
                }).OrderByDescending(c => c.OkunmaSayisi).Take(kayitSayisi).ToList();
        }
    }
}
