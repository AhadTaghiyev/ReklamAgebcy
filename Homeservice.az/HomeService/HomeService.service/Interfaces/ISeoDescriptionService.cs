using HomeService.service.Dtos;
using HomeService.service.Dtos.SeoDescriptionDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface ISeoDescriptionService
    {
        Task Update(int id,SeoDescriptionPostDto seoDescriptionPost);
        Task<SeoDescriptionGetDto> GetByIdAsync(int id);
        Task<SeoDescriptionGetDto> Get();
    }
}
