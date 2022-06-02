using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using Kutuphane.Entities;

namespace Kutuphane.DataAccess.VeriErisim
{
    public class AdresDal : EntityAnaSablon<Adres,KutuphaneContext>,IAdresDal
    {
      
    }
}
