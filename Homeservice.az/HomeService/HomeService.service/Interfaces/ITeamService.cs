using HomeService.service.Dtos;
using HomeService.service.Dtos.TeamDto;
using HomeService.service.Dtos.TeamRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface ITeamService
    {
        Task CreateAsync(TeamPostDto postDto);
        Task<TeamGetDto> Get(int id);
        Task<GetAll<TeamGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, TeamPostDto postDto);
    }
}
