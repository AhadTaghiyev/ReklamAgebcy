using HomeService.service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface ISettingService
    {
        Task Update(int id,SettingPostDto settingPostDto);
        Task<SettingGetDto> GetByIdAsync(int id);
        Task<SettingGetDto> GetSetting();
    }
}
