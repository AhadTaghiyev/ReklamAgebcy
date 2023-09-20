using HomeService.core;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.BlogDto;
using HomeService.service.Exeptions;
using HomeService.service.Extentions;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Implementations
{
  public  class BlogService:IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;

        public BlogService(IUnitOfWork unitOfWork,IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public async Task CreateAsync(BlogPostDto postDto)
        {
           

            Blog blog = new Blog
            {
                
                
                PositionId=postDto.PositionId,
                BlogLanguages = new List<BlogLanguage>()
            };

            if (postDto.ImageFile != null)
                blog.Image = postDto.ImageFile.SaveImage(_env.WebRootPath, "assets/images/blog");


            await _unitOfWork.BlogRepository.AddAsync(blog);

            for (int i = 0; i < postDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = postDto.Texts[i],
                    Key = postDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                BlogLanguage blogLanguage =new BlogLanguage
                {
                    Language = language,
                    Blog = blog
                };
                blog.BlogLanguages.Add(blogLanguage);
            }
            await _unitOfWork.CommitAsync();
        }

        public async Task<BlogGetDto> Get(int id)
        {
            Blog blog = await _unitOfWork.BlogRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "BlogLanguages.Language","Position");

            if (blog == null)
                throw new ItemNotFoundExeption("Item is not found");

            BlogGetDto serviceget = new BlogGetDto
            {
            
                Id = blog.Id,
                ImageFile=blog.Image,
                PositionId=blog.Id,
                TitleAz = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "TitleAz").Language.Text,
                TitleEn = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "TitleEn").Language.Text,
                TitleRu = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "DescriptionEn").Language.Text,
                DescriptionRu = blog.BlogLanguages.FirstOrDefault(x => x.BlogId == id && x.Language.Key == "DescriptionRu").Language.Text,
            };
            return serviceget;
        }

        public async Task<GetAll<BlogGetDto>> GetAll()
        {
            var query = _unitOfWork.BlogRepository.GetAll(x =>x.IsDeleted == false, "BlogLanguages.Language", "Position");

            GetAll<BlogGetDto> GetDto = new GetAll<BlogGetDto>();


            GetDto.Items = query.Select(x => new BlogGetDto()
            {
                Id = x.Id,
                ImageFile=x.Image,
                PositionId=x.PositionId,
                TitleAz = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "TitleAz").Language.Text,
                TitleEn = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "TitleEn").Language.Text,
                TitleRu = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "TitleRu").Language.Text,
                DescriptionAz = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionAz").Language.Text,
                DescriptionEn = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionEn").Language.Text,
                DescriptionRu = x.BlogLanguages.FirstOrDefault(x => x.Language.Key == "DescriptionRu").Language.Text,

            }).ToList();
            return GetDto;
        }

        public async Task RemoveAync(int id)
        {
            Blog blog = await _unitOfWork.BlogRepository.GetAsync(x => x.Id == id && x.IsDeleted == false, "BlogLanguages.Language","Position");

            if (blog == null)
                throw new ItemNotFoundExeption("Item is not found");

            blog.IsDeleted=true;
            await _unitOfWork.CommitAsync();

        }

        public async Task Update(int id, BlogPostDto blogPostDto)
        {
            Blog blog = await _unitOfWork.BlogRepository.GetAsync(x => x.Id == id && x.IsDeleted == false , "BlogLanguages.Language","Position");


            if (blog == null)
                throw new ItemNotFoundExeption("Item is not found");

            if (blogPostDto.ImageFile!=null)
            {
                
                  if (blog.Image!=null)
                {
                    Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images/blog", blog.Image);
                }
                
                blog.Image = blogPostDto.ImageFile.SaveImage(_env.WebRootPath, "assets/images/blog");
            }
            
            blog.PositionId = blogPostDto.PositionId;
            List<BlogLanguage> RemovableLanguages = blog.BlogLanguages.Where(x => x.BlogId == id).ToList();

            if (RemovableLanguages.Count > 0)
                foreach (BlogLanguage blogLanguage in RemovableLanguages)
                {
                    _unitOfWork.LanguageRepository.Remove(blogLanguage.Language);
                }

            for (int i = 0; i < blogPostDto.Texts.Count; i++)
            {
                Language language = new Language
                {
                    Text = blogPostDto.Texts[i],
                    Key = blogPostDto.Keys[i],
                };
                await _unitOfWork.LanguageRepository.AddAsync(language);

                BlogLanguage blogLanguage = new BlogLanguage
                {
                    Language = language,
                    Blog = blog
                };
                blog.BlogLanguages.Add(blogLanguage);
            }
            blog.PositionId = blogPostDto.PositionId;

            await _unitOfWork.CommitAsync();
        }

    }
}
