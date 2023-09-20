using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Dtos
{
   public class GetAll<TEntity>
    {
        public List<TEntity> Items { get; set; }
    }
}
