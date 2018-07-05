using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlogSite.Data
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        IList<TEntity> GetAll();

        IList<TEntity> Where(Expression<Func<TEntity,bool>> predicate);

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}
