using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.core.Repositories
{
   public interface IRepository<TEntity>
    {
        Task AddAsync(TEntity entity);
        Task<TEntity> GetAsync(Expression<Func<TEntity,bool>> expression,params string[]includes);
        Task<TEntity> GetAsync();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity,bool>> expression, params string[] includes);
        void Remove(TEntity entity);
        Task<int> CommitAsync();
        int Commit();
    }
}
