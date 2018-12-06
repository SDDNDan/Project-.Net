using DomainLayer.Base.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DomainLayer.Base
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object key);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
