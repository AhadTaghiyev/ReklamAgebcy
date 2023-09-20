using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.PositionDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
   public class PositionService:IPositionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PositionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(PositionPostDto postDto)
        {
            Position position = new Position();
         
            position.PositionLanguages = new List<PositionLanguage>();

            await _unitOfWork.PositionRepository.AddAsync(position);
            await _unitOfWork.CommitAsync();

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                PositionLanguage positionLanguage = new PositionLanguage
                {
                    Language = language,
                    Position = position
                };
                position.PositionLanguages.Add(positionLanguage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<PositionGetDto> Get(int id)
        {
            Position position = await _unitOfWork.PositionRepository.GetAsync(x => x.Id == id,  "PositionLanguages.Language");

            if (position == null)
                throw new ItemNotFoundExeption("Item is not found");

            PositionGetDto positionGetDto = new PositionGetDto
            {
                Id = position.Id,

                PositionAz = position.PositionLanguages.FirstOrDefault(x=>x.Language.Key == "PositionAz").Language.Text,
                PositionEn = position.PositionLanguages.FirstOrDefault(x=> x.Language.Key == "PositionEn").Language.Text,
                PositionRu = position.PositionLanguages.FirstOrDefault(x => x.Language.Key == "PositionRu").Language.Text,
            };

            return positionGetDto;
        }

        public async Task<GetAll<PositionGetDto>> GetAll()
        {
            var query = _unitOfWork.PositionRepository.GetAll(x =>x.IsDeleted == false, "PositionLanguages.Language");

            GetAll<PositionGetDto> GetDto = new GetAll<PositionGetDto>();



            GetDto.Items = query.Select(x => new PositionGetDto()
            {
                PositionAz = x.PositionLanguages.FirstOrDefault(x => x.Language.Key == "PositionAz").Language.Text,
                PositionEn = x.PositionLanguages.FirstOrDefault(x => x.Language.Key == "PositionEn").Language.Text,
                PositionRu = x.PositionLanguages.FirstOrDefault(x => x.Language.Key == "PositionRu").Language.Text,
                Id=x.Id
            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Position position = await _unitOfWork.PositionRepository.GetAsync(x => x.Id == id, "PositionLanguages.Language");

            if (position == null)
                throw new ItemNotFoundExeption("Item is not found");

            position.IsDeleted=true;
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, PositionPostDto positionPostDto)
        {
            Position position = await _unitOfWork.PositionRepository.GetAsync(x => x.Id == id,  "PositionLanguages.Language");

            if (position == null)
                throw new ItemNotFoundExeption("Item is not found");

            List<PositionLanguage> RemovableLanguages = position.PositionLanguages.Where(x => x.PositionId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (PositionLanguage costLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(costLanguage.Language);
                }



            for (int i = 0; i < positionPostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = positionPostDto.Texts[i],
                    Key = positionPostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                PositionLanguage positionLanguage = new PositionLanguage
                {
                    Language = language,
                    Position = position
                };
                position.PositionLanguages.Add(positionLanguage);
            }

            await _unitOfWork.CommitAsync();
        }
    }
}
