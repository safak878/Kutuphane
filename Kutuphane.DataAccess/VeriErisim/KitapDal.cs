using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.Entities;

namespace Kutuphane.DataAccess.VeriErisim
{
    public class KitapDal :EntityAnaSablon<Kitap, KutuphaneContext>, IKitapDal
    {
    }
}
