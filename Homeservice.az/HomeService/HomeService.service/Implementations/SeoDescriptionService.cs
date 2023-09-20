using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
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
    public class SeoDescriptionService : ISeoDescriptionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mappermapper;

        public SeoDescriptionService(IUnitOfWork unitOfWork, IMapper mappermapper)
        {
            _unitOfWork = unitOfWork;
            _mappermapper = mappermapper;
        }

        public async Task<SeoDescriptionGetDto> GetByIdAsync(int id)
        {
            SeoDescription seoDescription = await _unitOfWork.SeoDescriptionRepository.GetAsync(x => x.Id == id);

            if (seoDescription == null)
                throw new ItemNotFoundExeption("Item not found");

            SeoDescriptionGetDto SeoDescriptionGetDto = _mappermapper.Map<SeoDescriptionGetDto>(seoDescription);
            return SeoDescriptionGetDto;
        }

        public async Task<SeoDescriptionGetDto> Get()
        {
            SeoDescription seoDescription = await _unitOfWork.SeoDescriptionRepository.GetAsync();

            if (seoDescription == null)
                throw new ItemNotFoundExeption("Item not found");

            SeoDescriptionGetDto SeoDescriptionGetDto = _mappermapper.Map<SeoDescriptionGetDto>(seoDescription);
            return SeoDescriptionGetDto;
        }


        public async Task Update(int id, SeoDescriptionPostDto SeoDescriptionPostDto)
        {
            SeoDescription SeoDescription = await _unitOfWork.SeoDescriptionRepository.GetAsync();
            SeoDescription.Name = SeoDescriptionPostDto.Name;
            await _unitOfWork.CommitAsync();
        }
    }
}
