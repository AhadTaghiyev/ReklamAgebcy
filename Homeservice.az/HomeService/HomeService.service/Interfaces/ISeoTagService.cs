using HomeService.service.Dtos.BlogDto;
using HomeService.service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HomeService.service.Dtos.SeoTagDto;

namespace HomeService.service.Interfaces
{
    public interface ISeoTagService
    {
        Task CreateAsync(SeoTagPostDto postDto);
        Task<SeoTagGetDto> Get(int id);
        Task<GetAll<SeoTagGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, SeoTagPostDto PostDto);
    }
}
