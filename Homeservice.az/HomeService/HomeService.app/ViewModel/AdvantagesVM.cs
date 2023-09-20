using HomeService.service.Dtos;
using HomeService.service.Dtos.AdvantageDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class AdvantagesVM
    {
        public AdvantagePostDto AdvantagePostDto { get; set; }
        public AdvantageGetDto AdvantageGetDto { get; set; }
        public GetAll<AdvantageGetDto> GetAll { get; set; }
    }
}
