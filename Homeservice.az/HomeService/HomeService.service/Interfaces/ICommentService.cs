using HomeService.service.Dtos;
using HomeService.service.Dtos.CommentDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HomeService.service.Interfaces
{
    public interface ICommentService
    {
        Task CreateAsync(CommentPostDto postDto);
        Task<CommentGetDto> Get(int id);
        Task<GetAll<CommentGetDto>> GetAll();
        Task RemoveAync(int id);
        Task Update(int id, CommentPostDto servicePostDto);
    }
}
