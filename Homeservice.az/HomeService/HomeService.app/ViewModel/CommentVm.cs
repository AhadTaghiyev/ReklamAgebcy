using HomeService.service.Dtos;
using HomeService.service.Dtos.CommentDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class CommentVm
    {
        public CommentPostDto CommentPostDto { get; set; }
        public CommentGetDto CommentGetDto { get; set; }
        public GetAll<CommentGetDto> GetAll { get; set; }
    }
}
