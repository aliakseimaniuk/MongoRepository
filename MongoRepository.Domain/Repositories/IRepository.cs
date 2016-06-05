using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoRepository.Domain.Entities;

namespace MongoRepository.Domain.Repositories
{
    public interface IRepository<TEntity, in TKey> where TEntity : IEntity<TKey>
    {
        Task<TEntity> GetByIdAsync(TKey id);

        Task<TEntity> SaveAsync(TEntity entity);

        Task DeleteAsync(TKey id);

        Task<ICollection<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
