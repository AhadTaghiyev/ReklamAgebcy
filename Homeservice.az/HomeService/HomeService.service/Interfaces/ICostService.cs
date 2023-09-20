using HomeService.service.Dtos;
using HomeService.service.Dtos.CostDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface ICostService
    {
        Task CreateAsync(CostPostDto postDto);
        Task<CostGetDto> Get(int id);

        Task<GetAll<CostGetDto>> GetAll();
         Task RemoveAync(int id);

        Task Update(int id, CostPostDto costPostDto);
    }
}
