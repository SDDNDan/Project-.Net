using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DomainLayer.Base;
using DataAccessLayer.Base.DataContext;

namespace DataAccessLayer.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected BaseRepository(IDataContext dataContext)
        {
            CurrentDataContext = dataContext;
        }

        protected IDataContext CurrentDataContext { get; }

        public TEntity GetById(object key)
        {
            return CurrentDataContext.Set<TEntity>().Find(key);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CurrentDataContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = CurrentDataContext.Set<TEntity>().Where(filter);

            if (includeProperties != null && includeProperties.Any())
            {
                query = includeProperties.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }

        public TEntity Add(TEntity entity)
        {
            var addedEntity = CurrentDataContext.Set<TEntity>().Add(entity);

            return addedEntity.Entity;
        }

        public void Delete(object id)
        {
            var entity = CurrentDataContext.Set<TEntity>().Find(id);
            CurrentDataContext.Set<TEntity>().Remove(entity);
        }
    }
}
