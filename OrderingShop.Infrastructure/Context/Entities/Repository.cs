using OrderingShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderingShop.Infrastructure.Context.Entities
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly OrderingShopDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(OrderingShopDbContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<T?> GetByIdAsync(int? id) =>
        await _dbSet.AsNoTracking().SingleOrDefaultAsync(s => s.Id == id);
        public virtual async Task<bool> InsertAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public virtual async Task<bool> UpdateAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public virtual async Task<bool> DeleteAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
