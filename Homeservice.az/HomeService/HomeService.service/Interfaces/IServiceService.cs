using HomeService.service.Dtos;
using HomeService.service.Dtos.ServiceDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface IServiceService
    {
        Task CreateAsync(ServicePostDto postDto);
        Task<ServicegetDto> Get(int id);
        Task<GetAll<ServicegetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, ServicePostDto servicePostDto);

    }
}
