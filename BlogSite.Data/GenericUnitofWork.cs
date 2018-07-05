using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogSite.Data
{
    public class GenericUnitofWork
    {

        private readonly BlogContext _context;

        public GenericUnitofWork(BlogContext context)
        {
            _context = context;
        }

        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity:class
        {
            if(repositories.Keys.Contains(typeof(TEntity))==true)
                {
                return repositories[typeof(TEntity)] as IGenericRepository<TEntity>;

                }

            IGenericRepository<TEntity> repository = new GenericRepository<TEntity>(_context);
            repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }


    }
}
