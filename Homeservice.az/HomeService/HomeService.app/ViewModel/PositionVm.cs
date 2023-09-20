using HomeService.service.Dtos;
using HomeService.service.Dtos.PositionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class PositionVm
    {
        public PositionPostDto PositionPostDto { get; set; }
        public PositionGetDto PositionGetDto { get; set; }
        public GetAll<PositionGetDto> GetAll { get; set; }
    }
}
