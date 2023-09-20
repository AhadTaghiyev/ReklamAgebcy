using HomeService.service.Dtos;
using HomeService.service.Dtos.SeoDescriptionDto;
using HomeService.service.Dtos.SeoKeyWordDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface ISeoKeyWordService
    {
        Task Update(int id,SeoKeyWordPostDto postdto);
        Task<SeoKeyWordGetDto> GetByIdAsync(int id);
        Task<SeoKeyWordGetDto> Get();
    }
}
