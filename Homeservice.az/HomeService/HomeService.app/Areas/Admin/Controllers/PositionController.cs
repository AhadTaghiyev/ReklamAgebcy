using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.PositionDto;
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

    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<PositionGetDto> GetDto = await _positionService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PositionVm positionVm)
        {
       
            await _positionService.CreateAsync(positionVm.PositionPostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            PositionVm positionVm = new PositionVm
            {
                PositionGetDto = await _positionService.Get(id)
            };
            return View(positionVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, PositionVm positionVm)
        {
            PositionVm position = new PositionVm
            {
                PositionGetDto = await _positionService.Get(id)
            };
        
            await _positionService.Update(id, positionVm.PositionPostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _positionService.RemoveAync(id);
            return Json(new { status = 200 });
        }
    }
}
