using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.PositionDto;
using HomeService.service.Dtos.SeoTagDto;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class SeoTagController : Controller
    {
        private readonly ISeoTagService _seoTagService;

        public SeoTagController(ISeoTagService seoTagService)
        {
            _seoTagService = seoTagService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<SeoTagGetDto> GetDto = await _seoTagService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SeoTagPostDto seoTagPostDto)
        {
       
            await _seoTagService.CreateAsync(seoTagPostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            SeoTagVM positionVm = new SeoTagVM
            {
                SeoTagGetDto = await _seoTagService.Get(id)
            };
            return View(positionVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, SeoTagVM SeoTagVM)
        {
          
            await _seoTagService.Update(id,SeoTagVM.SeoTagPostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _seoTagService.RemoveAync(id);
            return Json(new { status = 200 });
        }
    }
}
