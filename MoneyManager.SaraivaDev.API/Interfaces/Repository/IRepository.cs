using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Interfaces.Repository
{
    public interface IRepository<TEntity>
    {
        Task<IList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression);
        Task<IList<TEntity>> ListAsync();
        Task<TEntity> GetByIdAsync(string id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);
    }
}
