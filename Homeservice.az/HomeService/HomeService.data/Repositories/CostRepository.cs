using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repositories
{
   public class CostRepository:Repository<Cost>,ICostRespository
    {
        public CostRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
