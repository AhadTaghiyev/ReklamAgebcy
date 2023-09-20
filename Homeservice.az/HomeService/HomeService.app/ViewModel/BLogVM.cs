using HomeService.service.Dtos;
using HomeService.service.Dtos.BlogDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class BLogVM
    {
        public BlogPostDto postDto { get; set; }
        public BlogGetDto getDto { get; set; }
        public GetAll<BlogGetDto> GetAll { get; set; }
    }
}
