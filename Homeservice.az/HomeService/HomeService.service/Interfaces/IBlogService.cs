using HomeService.service.Dtos;
using HomeService.service.Dtos.BlogDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface IBlogService
    {
        Task CreateAsync(BlogPostDto postDto);
        Task<BlogGetDto> Get(int id);
        Task<GetAll<BlogGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, BlogPostDto blogPost);
    }
}
