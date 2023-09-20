using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.QuestionDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
   public class QuestionService:IQuestionServis
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(QuestionPostDto postDto)
        {


            Questions questions = new Questions
            {
                QuestionLanguages = new List<QuestionLanguage>()
            };
            await _unitOfWork.QuestionRepository.AddAsync(questions);

            for (int i = 0; i < postDto.Text.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Text[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                QuestionLanguage questionLanguage = new QuestionLanguage
                {
                    Language = language,
                    Question = questions
                };
                questions.QuestionLanguages.Add(questionLanguage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<QuestionGetDto> Get(int id)
        {
            Questions questions = await _unitOfWork.QuestionRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "QuestionLanguages.Language");

            if (questions == null)
                throw new ItemNotFoundExeption("Item is not found");

            QuestionGetDto questionGet = new QuestionGetDto()
            {

                Id = questions.Id,
                QuestionAz = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "QuestionAz").Language.Text,
                QuestionEn = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "QuestionEn").Language.Text,
                QuestionRU = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "QuestionRu").Language.Text,
                AnswerAz = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "AnswerAz").Language.Text,
                AnswerEn = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "AnswerEn").Language.Text,
                AnswerRu = questions.QuestionLanguages.FirstOrDefault(x => x.QuestionId == id && x.Language.Key == "AnswerRu").Language.Text,
            };
            return questionGet;
        }

        public async Task<GetAll<QuestionGetDto>> GetAll()
        {
            var query = _unitOfWork.QuestionRepository.GetAll(x => x.IsDeleted==false, "QuestionLanguages");

            GetAll<QuestionGetDto> GetDto = new GetAll<QuestionGetDto>();


            GetDto.Items = query.Select(x => new QuestionGetDto()
            {
                Id = x.Id,
                QuestionAz = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "QuestionAz").Language.Text,
                QuestionEn = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "QuestionEn").Language.Text,
                QuestionRU = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "QuestionRU").Language.Text,
                AnswerAz = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "AnswerAz").Language.Text,
                AnswerEn = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "AnswerEn").Language.Text,
                AnswerRu = x.QuestionLanguages.FirstOrDefault(x =>x.Language.Key == "AnswerRu").Language.Text,

            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Questions questions = await _unitOfWork.QuestionRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "QuestionLanguages.Language");

            if (questions == null)
                throw new ItemNotFoundExeption("Item is not found");

            questions.IsDeleted=true;
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, QuestionPostDto questionPostDto)
        {
            Questions questions = await _unitOfWork.QuestionRepository.GetAsync(x => x.Id == id&&x.IsDeleted==false, "QuestionLanguages.Language");

            if (questions == null)
                throw new ItemNotFoundExeption("Item is not found");

            List<QuestionLanguage> RemovableLanguages = questions.QuestionLanguages.Where(x => x.QuestionId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (QuestionLanguage questionLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(questionLanguage.Language);
                }



            for (int i = 0; i < questionPostDto.Text.Count; i++)
            {
                Language language = new Language
                {
                    Text = questionPostDto.Text[i],
                    Key = questionPostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                QuestionLanguage questionLanguage = new QuestionLanguage
                {
                    Language = language,
                    Question = questions
                };
                questions.QuestionLanguages.Add(questionLanguage);
            }
           

            await _unitOfWork.CommitAsync();
        }
    }
}
