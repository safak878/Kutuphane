using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;

namespace Kutuphane.Business.Servisler
{
    public interface IServisSablonu<TEntity> where TEntity : class, IEntity, new()
    {
        List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null);
        TEntity Getir(Expression<Func<TEntity, bool>> filtre);
        TEntity Ekle(TEntity entity);
        TEntity Guncelle(TEntity entity);
        TEntity Sil(TEntity entity);
        TEntity EkleveyaGuncelle(TEntity entity);
        bool KayitKontrol(Expression<Func<TEntity, bool>> filtre);
        void Kaydet();
        BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null);
        DbContext OrnekOlustur(bool yeni = false);
        void OrnegeBagla(DbContext context);
        void Sil(Expression<Func<TEntity, bool>> filtre);
    }
}
