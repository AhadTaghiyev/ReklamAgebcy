using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.TeamDto;
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

    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IPositionService _positionService;

        public TeamController(ITeamService teamService,IPositionService positionService)
        {
            _teamService = teamService;
            _positionService = positionService;
        }
        public async Task<IActionResult> Index()
        {
            TeamVM teamVM = new TeamVM
            {
                GetAll = await _teamService.GetAll()
            };
            return View(teamVM);
        }

        public async Task<IActionResult> Create()
        {
           ViewBag.Positions = await _positionService.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamVM teamVM)
        {
            ViewBag.Positions = await _positionService.GetAll();
            await _teamService.CreateAsync(teamVM.postDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            ViewBag.Positions = await _positionService.GetAll();
            TeamVM teamVM = new TeamVM
            {
                getDto = await _teamService.Get(id)
            };
            return View(teamVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, TeamVM teamVm)
        {
            ViewBag.Positions = await _positionService.GetAll();
            await _teamService.Update(id, teamVm.postDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _teamService.RemoveAync(id);
            return Json(new { status = 200 });
        }
    }
}
