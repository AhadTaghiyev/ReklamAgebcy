using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repositories
{
   public class ServiceRepository:Repository<Service>,IServiceRepository
    {
        public ServiceRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
