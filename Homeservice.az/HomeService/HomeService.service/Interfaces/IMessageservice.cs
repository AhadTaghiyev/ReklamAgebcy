using HomeService.service.Dtos;
using HomeService.service.Dtos.MessageDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
   public interface IMessageservice
    {
        Task Create(MessagePostDto postDto);
        Task<GetAll<MessageGetDto>> GetALl();
        Task<MessageGetDto> Get(int id);
        Task Remove(int id);
    }
}
