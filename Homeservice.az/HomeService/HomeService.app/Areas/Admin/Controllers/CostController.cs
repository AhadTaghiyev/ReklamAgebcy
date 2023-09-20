using HomeService.app.ViewModel;
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

    public class CostController : Controller
    {
        private readonly ICostService _costservice;

        public CostController(ICostService costservice)
        {
            _costservice = costservice;
        }
        public async Task< IActionResult> Index()
        {
            CostVM costVM = new CostVM
            {
                GetAll = await _costservice.GetAll()
            };
            return View(costVM);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CostVM costVM)
        {
            await _costservice.CreateAsync(costVM.CostPostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            CostVM costVM = new CostVM
            {
                CostGetDto = await _costservice.Get(id)
            };
            return View(costVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CostVM costVM)
        {
            await _costservice.Update(id, costVM.CostPostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _costservice.RemoveAync(id);
            return Json(new { status = 200 });
        }
    }
}
