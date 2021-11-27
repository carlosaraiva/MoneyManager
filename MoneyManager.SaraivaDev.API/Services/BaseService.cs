using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Interfaces.Service;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Services
{
    public class BaseService<TEntity> : IService<TEntity> where TEntity : BaseModel
    {
        private IRepository<TEntity> Repository { get; set; }
        public BaseService(IRepository<TEntity> repository)
        {
            Repository = repository;
        }
        public Task<TEntity> CreateAsync(TEntity entity)
        {
            return Repository.CreateAsync(entity);
        }

        public Task DeleteAsync(string id)
        {
            return Repository.DeleteAsync(id);
        }

        public Task<TEntity> GetByIdAsync(string id)
        {
            return Repository.GetByIdAsync(id);
        }

        public Task<IList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression)
        {
            return Repository.ListAsync(expression);
        }

        public Task<IList<TEntity>> ListAsync()
        {
            return Repository.ListAsync();
        }

        public Task UpdateAsync(TEntity entity)
        {
            return Repository.UpdateAsync(entity);
        }
    }
}
