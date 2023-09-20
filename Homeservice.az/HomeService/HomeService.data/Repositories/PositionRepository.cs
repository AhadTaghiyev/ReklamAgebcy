using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repositories
{
    public class PositionRepository:Repository<Position>,IPositionRepository
    {
        public PositionRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
