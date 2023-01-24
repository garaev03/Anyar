using Core.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Implementations
{
    public class TEntityRepository<T, Context> : ITEntityRepository<T>
        where T : class, new()
        where Context : IdentityDbContext<IdentityUser>
    {
        private readonly Context _context;
        public TEntityRepository(Context context)
        {
            _context = context;
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> exp, params string[]? includes)
        {
            IQueryable<T> query=_context.Set<T>();
            if(includes is not null)
            {
                foreach (string name in includes)
                {
                    query.Include(name);
                }
            }
            return query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
            => await _context.Set<T>().FindAsync(id);
        public async Task CreateAsync(T model)
        {
            await _context.Set<T>().AddAsync(model);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
