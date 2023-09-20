using HomeService.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.core.Repositories
{
   public interface ISettingRepository:IRepository<Setting>
    {

        public  Task<Setting> GetSetting(params string[] includes);
    }
}
