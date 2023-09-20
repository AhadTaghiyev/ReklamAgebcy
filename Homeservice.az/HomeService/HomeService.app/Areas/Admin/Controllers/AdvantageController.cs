using HomeService.app.ViewModel;
using HomeService.core.Models;
using HomeService.service.Dtos;
using HomeService.service.Dtos.AdvantageDto;
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
    public class AdvantageController : Controller
    {
        private readonly IAdvantageService _advantageService;


        public AdvantageController(IAdvantageService advantageService)
        {
            _advantageService = advantageService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<AdvantageGetDto> GetDto = await _advantageService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdvantagesVM advantagesVM)
        {
            await _advantageService.CreateAsync(advantagesVM.AdvantagePostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            AdvantagesVM advantagesVM = new AdvantagesVM
            {
                AdvantageGetDto=await _advantageService.Get(id)
            };
            return View(advantagesVM);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Update(int id,AdvantagesVM advantagesVM)
        {
            await _advantageService.Update(id,advantagesVM.AdvantagePostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _advantageService.RemoveAync(id);
            return Json(new { status = 200 });
        }

    }
}
