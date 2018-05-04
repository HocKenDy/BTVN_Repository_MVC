using BTVeNha.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BTVeNha.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private TestDbContext context = new TestDbContext();
        private IDbSet<T> dbSet;
        protected RepositoryBase()
        {
            dbSet = context.Set<T>();
        }

        public T Add(T entity)
        {
            return dbSet.Add(entity);
        }

        public virtual void Commit()
        {
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsQueryable();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }
    }
}