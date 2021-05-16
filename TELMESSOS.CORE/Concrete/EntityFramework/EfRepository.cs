using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TELMESSOS.CORE.Abstract;
using TELMESSOS.CORE.Entities;

namespace TELMESSOS.CORE.Concrete.EntityFramework
{
    public class EfRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : CoreEntity, new() where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().FirstOrDefault()
                                    : context.Set<TEntity>().FirstOrDefault(filter);
            }
        }
        
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter==null? context.Set<TEntity>().ToList()
                                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList()
                                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using(var context=new TContext())
            {
                //?buradaki TEntity kullanılmıyor mu?
                context.Entry<TEntity>(entity).State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Insert(IEnumerable<TEntity> entities)
        {
            using (var context = new TContext())
            {
                foreach (var entity in entities)
                {
                    context.Entry<TEntity>(entity).State = EntityState.Added;
                }
                
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            using (var context = new TContext())
            {
                foreach (var entity in entities)
                {
                    context.Entry<TEntity>(entity).State = EntityState.Modified;
                }

                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry<TEntity>(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            using (var context = new TContext())
            {
                foreach (var entity in entities)
                {
                    context.Entry<TEntity>(entity).State = EntityState.Deleted;
                }

                context.SaveChanges();
            }
        }
    }
}
