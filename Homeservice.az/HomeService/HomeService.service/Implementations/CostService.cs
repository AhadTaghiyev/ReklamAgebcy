using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.CommentDto;
using HomeService.service.Dtos.CostDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
   public class CostService:ICostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(CostPostDto postDto)
        {
            Cost cost = new Cost();
            cost.Skills = new List<Skill>();
            cost.CostLanguages = new List<CostLanguage>();
           
            await _unitOfWork.CostRespository.AddAsync(cost);
            await _unitOfWork.CommitAsync();

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                CostLanguage costLanguage = new CostLanguage
                {
                    Language = language,
                    Cost = cost
                };
                cost.CostLanguages.Add(costLanguage);
            }

            for (int i = 0; i < postDto.SkillTexts.Count; i++)
            {

                Skill skill = new Skill
                {
                    SkillContent = postDto.SkillContents[i],
                    SkillTitle = postDto.SkillContents[i],
                    CostId=cost.Id
                  
                };
                cost.Skills.Add(skill);

            }

            await _unitOfWork.CommitAsync();
        }

        public async Task<CostGetDto> Get(int id)
        {
            Cost cost = await _unitOfWork.CostRespository.GetAsync(x => x.Id == id && x.IsDeleted == false, "Skills", "CostLanguages.Language");

            if (cost == null)
                throw new ItemNotFoundExeption("Item is not found");

            CostGetDto costGetDto = new CostGetDto
            {
                Id = cost.Id,
                  
                TitleAz = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "TitleAz").Language.Text,
                TitleEn = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "TitleEn").Language.Text,
                TitleRu = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "DescriptionEn").Language.Text,
                DescriptionRu = cost.CostLanguages.FirstOrDefault(x => x.CostId == id && x.Language.Key == "DescriptionRu").Language.Text,
                Skills=cost.Skills
                
            };
           
            return costGetDto;
        }

        public async Task<GetAll<CostGetDto>> GetAll()
        {
            var query =  _unitOfWork.CostRespository.GetAll(x => x.IsDeleted == false, "Skills", "CostLanguages.Language");

            GetAll<CostGetDto> GetDto = new GetAll<CostGetDto>();
             

            
            GetDto.Items = query.Select(x => new CostGetDto()
            {
                Id = x.Id,
                TitleAz = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "TitleAz").Language.Text,
                TitleEn = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "TitleEn").Language.Text,
                TitleRu = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionEn").Language.Text,
                DescriptionRu = x.CostLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionRu").Language.Text,
             
                Skills = x.Skills
            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Cost cost = await _unitOfWork.CostRespository.GetAsync(x => x.Id == id && x.IsDeleted == false, "Skills", "CostLanguages.Language");

            if (cost == null)
                throw new ItemNotFoundExeption("Item is not found");


            cost.IsDeleted=true;
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, CostPostDto costPostDto)
        {
            Cost cost = await _unitOfWork.CostRespository.GetAsync(x => x.Id == id && x.IsDeleted == false, "Skills", "CostLanguages.Language");

            if (cost == null)
                throw new ItemNotFoundExeption("Item is not found");

            List<CostLanguage> RemovableLanguages = cost.CostLanguages.Where(x => x.CostId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (CostLanguage costLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(costLanguage.Language);
                }



            for (int i = 0; i < costPostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = costPostDto.Texts[i],
                    Key = costPostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                CostLanguage costLanguage = new CostLanguage
                {
                    Language = language,
                    Cost = cost
                };
                cost.CostLanguages.Add(costLanguage);
            }


            List<Skill> RemovableSocials = cost.Skills.ToList();

            cost.Skills.RemoveAll(x => RemovableSocials.Any());

            for (int i = 0; i < costPostDto.SkillTexts.Count; i++)
            {

                Skill skill = new Skill
                {
                    SkillContent = costPostDto.SkillContents[i],
                    SkillTitle = costPostDto.SkillContents[i],
                    CostId = cost.Id

                };
                cost.Skills.Add(skill);

            }
            await _unitOfWork.CommitAsync();
        }

    }
}
