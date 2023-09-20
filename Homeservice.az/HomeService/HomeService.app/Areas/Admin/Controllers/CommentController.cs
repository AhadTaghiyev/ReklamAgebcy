using HomeService.app.ViewModel;
using HomeService.service.Dtos;
using HomeService.service.Dtos.CommentDto;
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

    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<IActionResult> Index()
        {
            GetAll<CommentGetDto> GetDto = await _commentService.GetAll();
            return View(GetDto);
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CommentVm commentVm)
        {
            if (commentVm.CommentPostDto.Texts.Any(x => string.IsNullOrWhiteSpace(x)) || commentVm.CommentPostDto.Keys.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Mətinlər Boş ola bilməz");
                return View();
            }


            await _commentService.CreateAsync(commentVm.CommentPostDto);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id)
        {
            CommentVm commentVm = new CommentVm
            {
                CommentGetDto = await _commentService.Get(id)
            };
            return View(commentVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CommentVm commentVm)
        {
            CommentVm comment = new CommentVm
            {
                CommentGetDto = await _commentService.Get(id)
            };
            if (commentVm.CommentPostDto.Texts.Any(x => string.IsNullOrWhiteSpace(x)) || commentVm.CommentPostDto.Keys.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Mətinlər Boş ola bilməz");
                return View();
            }

            await _commentService.Update(id, commentVm.CommentPostDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _commentService.RemoveAync(id);
            return Json(new { status = 200 });
        }

    }
}
