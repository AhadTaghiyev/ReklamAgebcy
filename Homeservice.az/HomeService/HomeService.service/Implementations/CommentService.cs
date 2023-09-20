using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.CommentDto;
using HomeService.service.Dtos.ServiceDto;
using HomeService.service.Exeptions;
using HomeService.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(CommentPostDto postDto)
        {


            Comment comment = new Comment
            {
                FullName = postDto.FullName,
                CommentLanguages = new List<CommentLanguage>()
            };
            await _unitOfWork.CommentRepository.AddAsync(comment);

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                CommentLanguage commentLanguage = new CommentLanguage
                {
                    Language = language,
                    Comment = comment
                };
                comment.CommentLanguages.Add(commentLanguage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<CommentGetDto> Get(int id)
        {
            Comment comment = await _unitOfWork.CommentRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "CommentLanguages.Language");

            if (comment == null)
                throw new ItemNotFoundExeption("Item is not found");

            CommentGetDto commentGetDto = new CommentGetDto
            {
                Id = comment.Id,
                FullName=comment.FullName,
                TextAz = comment.CommentLanguages.FirstOrDefault(x => x.CommentId == id && x.Language.Key == "TextAz").Language.Text,
                TextEn = comment.CommentLanguages.FirstOrDefault(x => x.CommentId == id && x.Language.Key == "TextEn").Language.Text,
                TextRu = comment.CommentLanguages.FirstOrDefault(x => x.CommentId == id && x.Language.Key == "TextRu").Language.Text,
         
            };
            return commentGetDto;
        }

        public async Task<GetAll<CommentGetDto>> GetAll()
        {
            var query = _unitOfWork.CommentRepository.GetAll(x => x.IsDeleted == false, "CommentLanguages");

            GetAll<CommentGetDto> GetDto = new GetAll<CommentGetDto>();

            GetDto.Items = query.Select(x => new CommentGetDto()
            {
                Id = x.Id,
                FullName=x.FullName,
                TextAz = x.CommentLanguages.FirstOrDefault(x => x.Language.Key == "TextAz").Language.Text,
                TextEn = x.CommentLanguages.FirstOrDefault(x => x.Language.Key == "TextEn").Language.Text,
                TextRu = x.CommentLanguages.FirstOrDefault(x => x.Language.Key == "TextRu").Language.Text,
        

            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Comment comment = await _unitOfWork.CommentRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "CommentLanguages");

            if (comment == null)
                throw new ItemNotFoundExeption("Item is not found");


            _unitOfWork.CommentRepository.Remove(comment);
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, CommentPostDto commentPostDto)
        {
            Comment comment = await _unitOfWork.CommentRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "CommentLanguages");

            if (comment == null)
                throw new ItemNotFoundExeption("Item is not found");

            List<CommentLanguage> RemovableLanguages = comment.CommentLanguages.Where(x => x.CommentId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (CommentLanguage commentLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(commentLanguage.Language);
                }



            for (int i = 0; i < commentPostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = commentPostDto.Texts[i],
                    Key = commentPostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                CommentLanguage commentLanguage = new CommentLanguage
                {
                    Language = language,
                    Comment = comment
                };
                comment.CommentLanguages.Add(commentLanguage);
            }
            comment.FullName = commentPostDto.FullName;

            await _unitOfWork.CommitAsync();
        }


    }
}
