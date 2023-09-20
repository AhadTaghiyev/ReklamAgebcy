using HomeService.core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly HomeServiceDbContext _context;

        public Repository(HomeServiceDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression, params string[] includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();

            if (includes != null)
            {
                foreach (string include in includes)
                {
                  query=  query.Include(include);
                }
            }
            return query.Where(expression);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, params string[] includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();

            if (includes!=null)
            {
                foreach (string include in includes)
                {
                   query= query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync(expression);
        }

        public async Task<TEntity> GetAsync()
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync();
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
