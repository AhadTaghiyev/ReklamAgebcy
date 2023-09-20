using AutoMapper;
using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.SeoTagDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class SeoTagService : ISeoTagService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SeoTagService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(SeoTagPostDto postDto)
        {
            SeoTag seoTag = new SeoTag { Tag = postDto.Tag };
            await _unitOfWork.SeoTagRepository.AddAsync(seoTag);
            await _unitOfWork.CommitAsync();
        }

        public async Task<SeoTagGetDto> Get(int id)
        {
            SeoTag seoTag = await _unitOfWork.SeoTagRepository.GetAsync(x => x.Id == id && !x.IsDeleted);

            if (seoTag == null)
                throw new ItemNotFoundExeption("Item not Found");

            SeoTagGetDto seoTagGetDto = _mapper.Map<SeoTagGetDto>(seoTag);
            return seoTagGetDto;
        }

        public async Task<GetAll<SeoTagGetDto>> GetAll()
        {
            var SeoQuery = _unitOfWork.SeoTagRepository.GetAll(x=>x.IsDeleted==false);

            GetAll<SeoTagGetDto> getAll = new GetAll<SeoTagGetDto>();
            getAll.Items = await SeoQuery.Select(x => new SeoTagGetDto { Id = x.Id, Tag = x.Tag }).ToListAsync();
            return getAll;
        }

        public async Task RemoveAync(int id)
        {
            SeoTag seoTag = await _unitOfWork.SeoTagRepository.GetAsync(x => x.Id == id&&!x.IsDeleted);

            if (seoTag == null)
                throw new ItemNotFoundExeption("Item not Found");

            seoTag.IsDeleted = true;

            await _unitOfWork.CommitAsync();
        }

        public async Task Update(int id, SeoTagPostDto PostDto)
        {
            SeoTag seoTag = await _unitOfWork.SeoTagRepository.GetAsync(x => x.Id == id&&!x.IsDeleted);

            if (seoTag == null)
                throw new ItemNotFoundExeption("Item not Found");

            seoTag.Tag=PostDto.Tag;
            await _unitOfWork.CommitAsync();

        }
    }
}
