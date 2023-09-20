using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.ServiceDto;
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

    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;


        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<ServicegetDto> GetDto = await _serviceService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceVM serviceVM)
        {
            await _serviceService.CreateAsync(serviceVM.ServicePostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            ServiceVM serviceVM = new ServiceVM
            {
                ServicegetDto = await _serviceService.Get(id)
            };
            return View(serviceVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, ServiceVM serviceVM)
        {

            await _serviceService.Update(id, serviceVM.ServicePostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _serviceService.RemoveAync(id);
            return Json(new { status = 200 });
        }

    }
}
