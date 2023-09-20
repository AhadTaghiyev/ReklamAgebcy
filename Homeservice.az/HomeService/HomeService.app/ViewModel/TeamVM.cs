using HomeService.service.Dtos;
using HomeService.service.Dtos.TeamDto;
using HomeService.service.Dtos.TeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class TeamVM
    {
        public TeamPostDto postDto { get; set; }
        public TeamGetDto getDto { get; set; }
        public GetAll<TeamGetDto> GetAll { get; set; }
    }
}
