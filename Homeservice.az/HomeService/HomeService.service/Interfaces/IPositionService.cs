using HomeService.service.Dtos;
using HomeService.service.Dtos.PositionDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface IPositionService
    {
        Task CreateAsync(PositionPostDto postDto);
        Task<PositionGetDto> Get(int id);
        Task<GetAll<PositionGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, PositionPostDto positionPostDto);
    }
}
