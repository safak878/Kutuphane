using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;

namespace Kutuphane.DataAccess.VeriErisim
{
    public class EntityAnaSablon<TEntity, TContext> : IEntitySablonu<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        protected TContext _context;
        public TEntity EkleveyaGuncelle(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            return entity;
        }

        public TEntity Ekle(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            return entity;
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtre)
        {
            return _context.Set<TEntity>().SingleOrDefault(filtre);
        }

        public TEntity Guncelle(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }

        public void Kaydet()
        {
            _context.SaveChanges();
        }

        public DbContext OrnekOlustur(bool yeni = false)
        {
            return yeni == true
                ? _context = new TContext()
                : _context;
        }

        public void OrnegeBagla(DbContext context)
        {
            _context = (TContext)context;
        }

        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            return filtre == null
                   ? _context.Set<TEntity>().ToList()
                   : _context.Set<TEntity>().Where(filtre).ToList();
        }

        public TEntity Sil(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            return entity;
        }

        public void Sil(Expression<Func<TEntity, bool>> filtre)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filtre));
        }

        public BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null)
        {

            if (filtre == null)
            {
                _context.Set<TEntity>().Load();
            }
            else
            {
                _context.Set<TEntity>().Where(filtre).Load();
            }

            return _context.Set<TEntity>().Local.ToBindingList();
        }

        public bool KayitKontrol(Expression<Func<TEntity, bool>> filtre)
        {
            return _context.Set<TEntity>().Any(filtre);
        }
    }
}
