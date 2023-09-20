using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.MessageDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
   public class MessageService:IMessageservice
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public MessageService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task Create(MessagePostDto postDto)
        {
            Message message = new Message();
            message = _mapper.Map<Message>(postDto);
            await _unitOfWork.MessageRepository.AddAsync(message);
            await _unitOfWork.CommitAsync();
        }

        public async Task<MessageGetDto> Get(int id)
        {
            Message message = await _unitOfWork.MessageRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false);

            if (message == null)
                throw new ItemNotFoundExeption("Item is not found");

            MessageGetDto GetDto = _mapper.Map<MessageGetDto>(message);
            return GetDto;
        }

        public async Task<GetAll<MessageGetDto>> GetALl()
        {
            var query = _unitOfWork.MessageRepository.GetAll(x => x.IsDeleted == false);

            GetAll<MessageGetDto> getListDto = new GetAll<MessageGetDto>();
            getListDto.Items = query.Select(x => new MessageGetDto { FullName = x.FullName, Email = x.Email, Subject = x.Subject, Content = x.Content, Id = x.Id  }).ToList();
            return getListDto;
        }

        public async Task Remove(int id)
        {
            Message message = await _unitOfWork.MessageRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false);

            if (message == null)
                throw new ItemNotFoundExeption("Item is not found");

            message.IsDeleted = true;
            await _unitOfWork.CommitAsync();
        }
    }
}
