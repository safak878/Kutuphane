using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.Entities;

namespace Kutuphane.DataAccess.VeriErisim
{
    public class YazarDal : EntityAnaSablon<Yazar, KutuphaneContext>, IYazarDal
    {
    }
}
