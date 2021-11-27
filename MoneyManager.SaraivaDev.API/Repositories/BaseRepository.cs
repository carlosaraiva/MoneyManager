using Microsoft.EntityFrameworkCore;
using MoneyManager.SaraivaDev.API.Contexts;
using MoneyManager.SaraivaDev.API.Interfaces.Repository;
using MoneyManager.SaraivaDev.API.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoneyManager.SaraivaDev.API.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        private readonly MoneyManagerContext _context;
        public BaseRepository(MoneyManagerContext context)
        {
            _context = context;
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IList<TEntity>> ListAsync(Expression<Func<TEntity, bool>> expression)
        {
            if (expression == null)
                return await ListAsync();
            
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }
        public async Task<IList<TEntity>> ListAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
