using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDBContext _context; 
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var resoult = await _context.Set<T>().ToListAsync();
            return resoult;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var resoult = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return resoult;
        }

        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
