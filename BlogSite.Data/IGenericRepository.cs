using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlogSite.Data
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Where(Expression<Func<TEntity,bool>> predicate);


        IEnumerable<TEntity> OrderByDescending(Expression<Func<TEntity, int>> predicate);

        TEntity GetById(int id);

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

    }
}
