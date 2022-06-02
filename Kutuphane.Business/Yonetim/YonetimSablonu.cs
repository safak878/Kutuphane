using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Kutuphane.Business.Araclar;
using Kutuphane.Business.Servisler;
using Kutuphane.DataAccess.Arayuzler;

namespace Kutuphane.Business.Yonetim
{
    public class YonetimSablonu<TEntity, TDal, TValidator> : IServisSablonu<TEntity>
    where TEntity : class, IEntity, new()
    where TDal : class, IEntitySablonu<TEntity>, new()
    where TValidator : IValidator, new()
    {
       protected TDal _dal = new TDal();
        DogrulamaAraci dogrulamaAraci = new DogrulamaAraci();
        TValidator dogrulama = new TValidator();
        public TEntity EkleveyaGuncelle(TEntity entity)
        {
            if (dogrulamaAraci.Dogrula(dogrulama, entity))
            {
                return _dal.EkleveyaGuncelle(entity);
            }
            else
            {
                return null;
            }
        }



        public TEntity Ekle(TEntity entity)
        {
            if (dogrulamaAraci.Dogrula(dogrulama, entity))
            {
                return _dal.Ekle(entity);
            }
            else
            {
                return null;
            }
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtre)
        {
            return _dal.Getir(filtre);
        }

        public TEntity Guncelle(TEntity entity)
        {
            if (dogrulamaAraci.Dogrula(dogrulama, entity))
            {
                return _dal.Guncelle(entity);
            }
            else
            {
                return null;
            }
        }
        public void Kaydet()
        {
            _dal.Kaydet();
        }
        public BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null)
        {
            return _dal.BaglantiNesnesi(filtre);
        }

        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            return _dal.Listele(filtre);
        }

        public DbContext OrnekOlustur(bool yeni = false)
        {
            return _dal.OrnekOlustur(yeni);
        }

        public void OrnegeBagla(DbContext context)
        {
            _dal.OrnegeBagla(context);
        }

        public virtual TEntity Sil(TEntity entity)
        {
            return _dal.Sil(entity);
        }

        public virtual void Sil(Expression<Func<TEntity, bool>> filtre)
        {
            _dal.Sil(filtre);
        }

        public bool KayitKontrol(Expression<Func<TEntity, bool>> filtre)
        {
            return _dal.KayitKontrol(filtre);
        }
    }
}
