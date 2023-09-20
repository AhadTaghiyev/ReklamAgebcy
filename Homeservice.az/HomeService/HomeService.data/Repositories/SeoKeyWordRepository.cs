using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repositories
{
   public class SeoKeyWordRepository : Repository<SeoKeyword>, ISeoKeyWordRepository
    {
        public SeoKeyWordRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
