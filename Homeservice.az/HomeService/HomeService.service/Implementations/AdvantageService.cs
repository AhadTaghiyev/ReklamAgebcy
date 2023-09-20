using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.AdvantageDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class AdvantageService : IAdvantageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdvantageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(AdvantagePostDto postDto)
        {


            Advantage advantage = new Advantage
            {
                Icon = postDto.Icon,
                LanguageAdnvantage=new List<LanguageAdnvantage>()
            };
            await _unitOfWork.AdvantageRepository.AddAsync(advantage);

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                LanguageAdnvantage languageAdnvantage = new LanguageAdnvantage
                {
                    Language=language,
                    Advantage=advantage
                };
                advantage.LanguageAdnvantage.Add(languageAdnvantage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<AdvantageGetDto> Get(int id)
        {
            Advantage advantage = await _unitOfWork.AdvantageRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "LanguageAdnvantage.Language");

            if(advantage==null)
                throw new ItemNotFoundExeption("Item is not found");


            AdvantageGetDto advantageGet = new AdvantageGetDto
            {
                Icon = advantage.Icon,
                Id=advantage.Id,
                TextAz = advantage.LanguageAdnvantage.FirstOrDefault(x => x.AdvantageId == id && x.Language.Key == "TextAz").Language.Text,
                TextEn = advantage.LanguageAdnvantage.FirstOrDefault(x => x.AdvantageId == id && x.Language.Key == "TextEn").Language.Text,
                TextRu = advantage.LanguageAdnvantage.FirstOrDefault(x => x.AdvantageId == id && x.Language.Key == "TextRu").Language.Text,
            };
            return advantageGet;
        }

        public async Task<GetAll<AdvantageGetDto>> GetAll()
        {
            var query = _unitOfWork.AdvantageRepository.GetAll(x => x.IsDeleted == false, "LanguageAdnvantage");

            GetAll<AdvantageGetDto> GetDto = new GetAll<AdvantageGetDto>();

            GetDto.Items = query.Select(x => new AdvantageGetDto()
            {
                Icon = x.Icon,
                Id=x.Id,
                TextAz = x.LanguageAdnvantage.FirstOrDefault(x => x.Language.Key == "TextAz").Language.Text,
                TextEn = x.LanguageAdnvantage.FirstOrDefault(x => x.Language.Key == "TextEn").Language.Text,
                TextRu = x.LanguageAdnvantage.FirstOrDefault(x => x.Language.Key == "TextRu").Language.Text

            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Advantage advantage = await _unitOfWork.AdvantageRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "LanguageAdnvantage");

            if(advantage == null)
                throw new ItemNotFoundExeption("Item is not found");

            advantage.IsDeleted=true;
            await _unitOfWork.CommitAsync();
            
        }

        public async Task Update(int id, AdvantagePostDto advantagePostDto)
        {
            Advantage advantage = await _unitOfWork.AdvantageRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "LanguageAdnvantage.Language");

            if(advantage == null)
                throw new ItemNotFoundExeption("Item is not found");


            advantage.Icon = advantagePostDto.Icon;

            List<LanguageAdnvantage> RemovableLanguages = advantage.LanguageAdnvantage.Where(x => x.AdvantageId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (LanguageAdnvantage LanguageAdnvantage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(LanguageAdnvantage.Language);
                }

             

            for (int i = 0; i < advantagePostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = advantagePostDto.Texts[i],
                    Key = advantagePostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                LanguageAdnvantage languageAdnvantage = new LanguageAdnvantage
                {
                    Language = language,
                    Advantage = advantage
                };
                advantage.LanguageAdnvantage.Add(languageAdnvantage);
            }


            await _unitOfWork.CommitAsync();
        }
    }
}
