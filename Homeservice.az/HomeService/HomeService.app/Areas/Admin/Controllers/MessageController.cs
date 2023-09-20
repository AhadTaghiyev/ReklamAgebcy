using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IMessageservice _messageService;

        public MessageController(IMessageservice messageService)
        {
            _messageService = messageService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _messageService.GetALl());
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _messageService.Remove(id);
            return Json(new { status = 200 });
        }
    }
}
