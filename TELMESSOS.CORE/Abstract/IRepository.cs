using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter=null);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        IEnumerable<TEntity> Select(Expression<Func<TEntity, bool>> filter = null);
        void Insert(TEntity entity);
        void Insert(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);

    }
}
