using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
using HomeService.core.Repositories;
using HomeService.service.Dtos;
using HomeService.service.Dtos.SeoDescriptionDto;
using HomeService.service.Dtos.SeoKeyWordDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class SeoKeyWordService : ISeoKeyWordService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mappermapper;

        public SeoKeyWordService(IUnitOfWork unitOfWork, IMapper mappermapper)
        {
            _unitOfWork = unitOfWork;
            _mappermapper = mappermapper;
        }

        public async Task<SeoKeyWordGetDto> GetByIdAsync(int id)
        {
            SeoKeyword SeoKeyword = await _unitOfWork.SeoKeyWordRepository.GetAsync(x => x.Id == id);

            if (SeoKeyword == null)
                throw new ItemNotFoundExeption("Item not found");

            SeoKeyWordGetDto SeoKeyWordGetDto = _mappermapper.Map<SeoKeyWordGetDto>(SeoKeyword);
            return SeoKeyWordGetDto;
        }

        public async Task<SeoKeyWordGetDto> Get()
        {
            SeoKeyword SeoKeyword = await _unitOfWork.SeoKeyWordRepository.GetAsync();

            if (SeoKeyword == null)
                throw new ItemNotFoundExeption("Item not found");

            SeoKeyWordGetDto SeoKeyWordGetDto = _mappermapper.Map<SeoKeyWordGetDto>(SeoKeyword);
            return SeoKeyWordGetDto;
        }


        public async Task Update(int id, SeoKeyWordPostDto SeoKeyWordPostDto)
        {
            SeoKeyword SeoKeyword = await _unitOfWork.SeoKeyWordRepository.GetAsync();
            SeoKeyword.Name = SeoKeyWordPostDto.Name;
            await _unitOfWork.CommitAsync();
        }

    }
}
