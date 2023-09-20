using HomeService.app.ViewModel;
using HomeService.core;
using HomeService.data;
using HomeService.service.Dtos;
using HomeService.service.Dtos.MessageDto;
using HomeService.service.Implementations;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAdvantageService advantageService;
        private readonly ICommentService commentService;
        private readonly ICostService costService;
        private readonly IPositionService positionService;
        private readonly IQuestionServis questionService;
        private readonly IServiceService serviceService;
        private readonly ITeamService teamService;
        private readonly ISettingService settingService;
        private readonly IMessageservice _messageservice;
        private readonly IBlogService blogService;

        public HomeController(IAdvantageService advantageService,ICommentService commentService,ICostService costService,IPositionService positionService,IQuestionServis questionService,IServiceService serviceService,ITeamService teamService,ISettingService settingService,IMessageservice messageservice,IBlogService blogService)
        {
            this.advantageService = advantageService;
            this.commentService = commentService;
            this.costService = costService;
            this.positionService = positionService;
            this.questionService = questionService;
            this.serviceService = serviceService;
            this.teamService = teamService;
            this.settingService = settingService;
            _messageservice = messageservice;
            this.blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM home = new HomeVM
            {
                Advantages = await advantageService.GetAll(),
                Comments = await commentService.GetAll(),
                Costs = await costService.GetAll(),
                Positions = await positionService.GetAll(),
                Questions = await questionService.GetAll(),
                Services = await serviceService.GetAll(),
                Teams = await teamService.GetAll(),
                settingGet = await settingService.GetByIdAsync(1),
                Blogs = await blogService.GetAll()
            };
            return View(home);
            
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(MessagePostDto postDto)
        {
            if (string.IsNullOrEmpty(postDto.FullName)|| string.IsNullOrEmpty(postDto.Email)|| string.IsNullOrEmpty(postDto.Subject)|| string.IsNullOrEmpty(postDto.Content))
            {
                return Json("Xanaları düzgün doldurduqdan əmin olun");
            }

            await _messageservice.Create(postDto);

            return Json(new { status = 200 });
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> NotFound()
        {
            return View();
        }

    }
}
