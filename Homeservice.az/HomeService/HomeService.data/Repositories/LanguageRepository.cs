using HomeService.core.Models;
using HomeService.core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data.Repository
{
   public class LanguageRepository:Repository<Language>,ILanguageRepository
    {
        public LanguageRepository(HomeServiceDbContext context):base(context)
        {

        }
    }
}
