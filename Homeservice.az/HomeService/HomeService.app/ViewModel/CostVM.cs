using HomeService.service.Dtos;
using HomeService.service.Dtos.CostDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class CostVM
    {
        public CostPostDto CostPostDto { get; set; }
        public CostGetDto CostGetDto { get; set; }
        public GetAll<CostGetDto> GetAll { get; set; }
    }
}
