using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.QuestionDto;
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

    public class QuestionController : Controller
    {
        private readonly IQuestionServis _questionService;

        public QuestionController(IQuestionServis questionService)
        {
            _questionService = questionService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<QuestionGetDto> GetDto = await _questionService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionVM questionVM)
        {
         
            await _questionService.CreateAsync(questionVM.QuestionPostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            QuestionVM questionVM = new QuestionVM
            {
                QuestionGetDto = await _questionService.Get(id)
            };
            return View(questionVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, QuestionVM questionVM)
        {
            await _questionService.Update(id, questionVM.QuestionPostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _questionService.RemoveAync(id);
            return Json(new { status = 200 });
        }

    }
}
