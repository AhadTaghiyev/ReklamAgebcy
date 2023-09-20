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
    public class BlogController : Controller
    {
            private readonly IBlogService _blogService;
            private readonly IPositionService _positionService;

            public BlogController(IBlogService blogService, IPositionService positionService)
            {
                _blogService = blogService;
                _positionService = positionService;
            }
            public async Task<IActionResult> Index()
            {
                BLogVM bLogVM = new BLogVM
                {
                    GetAll = await _blogService.GetAll()
                };
                return View(bLogVM);
            }

            public async Task<IActionResult> Create()
            {
            ViewBag.Positions = await _positionService.GetAll();
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(BLogVM bLogVM)
            {
            ViewBag.Positions = await _positionService.GetAll();
            await _blogService.CreateAsync(bLogVM.postDto);
                return RedirectToAction(nameof(Index));
            }


            public async Task<IActionResult> Update(int id)
            {
                ViewBag.Positions = await _positionService.GetAll();
                BLogVM bLogVM = new BLogVM
                {
                    getDto = await _blogService.Get(id)
                };
                return View(bLogVM);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Update(int id, BLogVM bLogVM)
            {
                ViewBag.Positions = await _positionService.GetAll();
                await _blogService.Update(id, bLogVM.postDto);
                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Remove(int id)
            {
                await _blogService.RemoveAync(id);
                return Json(new { status = 200 });
            }
        }
    }

