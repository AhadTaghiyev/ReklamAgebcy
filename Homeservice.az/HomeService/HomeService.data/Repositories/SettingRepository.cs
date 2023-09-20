using HomeService.core.Models;
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
    public class SettingRepository : Repository<Setting>, ISettingRepository
    {
        private readonly HomeServiceDbContext _context;

        public SettingRepository(HomeServiceDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Setting> GetSetting(params string[] includes)
        {
            var query = _context.Set<Setting>().AsQueryable();
          
           

            //if (includes != null)
            //{
            //    foreach (string include in includes)
            //    {
            //        query = query.Include(include);
            //    }

            //}
            return await query.FirstOrDefaultAsync();
        }
    }

}
