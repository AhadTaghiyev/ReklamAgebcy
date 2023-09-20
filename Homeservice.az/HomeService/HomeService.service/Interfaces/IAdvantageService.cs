using HomeService.service.Dtos;
using HomeService.service.Dtos.AdvantageDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface IAdvantageService
    {
        Task Update(int id, AdvantagePostDto advantagePostDto);

        Task CreateAsync(AdvantagePostDto postDto);
        Task RemoveAync(int id);
        Task<AdvantageGetDto> Get(int id);
        Task<GetAll<AdvantageGetDto>> GetAll();
    }
}
