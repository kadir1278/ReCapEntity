using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreLayer.DataAccess
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        #region Veri Ekleme
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedTEntity = context.Entry(entity);
                addedTEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        #endregion
        #region Veri Silme
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedTEntity = context.Entry(entity);
                deletedTEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        #endregion
        #region Filtreye Göre Veri Getir
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        #endregion
        #region Tüm Veriları Getir
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                                      : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        #endregion
        #region Veri Güncelleme
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedTEntity = context.Entry(entity);
                updatedTEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion
    }
}

