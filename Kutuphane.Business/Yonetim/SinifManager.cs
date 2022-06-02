using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.Business.Dogrulamalar;
using Kutuphane.Business.Servisler;
using Kutuphane.DataAccess.VeriErisim;
using Kutuphane.Entities;

namespace Kutuphane.Business.Yonetim
{
    public class SinifManager : YonetimSablonu<Sinif, SinifDal,SinifValidator>, ISinifService
    {
    }
}
