using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repositories
{
   public class AdvanTageRepository:Repository<Advantage>,IAdvantageRepository
    {
        public AdvanTageRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
