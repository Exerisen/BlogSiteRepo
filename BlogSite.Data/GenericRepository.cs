using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BlogSite.Data
{
    public  class GenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity:class
    {

        private readonly BlogContext _context;

        public GenericRepository(BlogContext context)
        {
            _context = context;
        }   


        public virtual IEnumerable<Tentity> GetAll()
        {
            return _context.Set<Tentity>().ToList();
           
            
        }

        public virtual IEnumerable<Tentity> Where(Expression<Func<Tentity, bool>> predicate)
        {
            var result = _context.Set<Tentity>().Where(predicate);
            return result.ToList();
        }

        public IEnumerable<Tentity> OrderByDescending(Expression<Func<Tentity, int>> predicate)
        {
          var result = _context.Set<Tentity>().OrderByDescending(predicate);
            return result.ToList();
        }
        public Tentity Create(Tentity entity)
        {
           var result= _context.Set<Tentity>().Add(entity);
            return entity;
        }

        public virtual void Update(Tentity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Delete(Tentity entity)
        {
            _context.Set<Tentity>().Remove(entity);
           
        }

        public virtual int SaveChange()
        {
            return _context.SaveChanges();
           
        }

     

        public Tentity GetById(int id)
        {
            throw new NotImplementedException();
        }

     
    }
}
