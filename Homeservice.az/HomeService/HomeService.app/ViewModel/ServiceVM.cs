using HomeService.service.Dtos;
using HomeService.service.Dtos.ServiceDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class ServiceVM
    {
        public ServicePostDto ServicePostDto { get; set; }
        public ServicegetDto ServicegetDto { get; set; }
        public GetAll<ServicegetDto> GetAll { get; set; }
    }
}
