using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.BlogDto;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IPositionService _positionService;

        public BlogController(IBlogService blogService,IPositionService positionService)
        {
            _blogService = blogService;
            _positionService = positionService;
        }
        public async Task<IActionResult> Details(int id)
        {
            BlogGetDto blogGetDto = new BlogGetDto();
            blogGetDto = await _blogService.Get(id);
            
            return View(blogGetDto);
        }

        public async Task<IActionResult> Blogs()
        {
            HomeVM homeVM = new HomeVM
            {
                Blogs = await _blogService.GetAll(),
                Positions =await _positionService.GetAll()

            };
            return View(homeVM);
        }

    }
}
