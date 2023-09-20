using HomeService.app.ViewModel;
using HomeService.core;
using HomeService.service.Dtos;
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

    public class SettingController : Controller
    {
        private readonly ISettingService _settingService;

        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _settingService.GetSetting());
        }

        public async Task<IActionResult> Update(int id)
        {
            SettingVM setting = new SettingVM
            {
                GetDto = await _settingService.GetByIdAsync(id)
            };
            return View(setting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, SettingVM settingVM)
        {
            SettingVM setting = new SettingVM
            {
                GetDto = await _settingService.GetByIdAsync(id)
            };
            if (settingVM.PostDto.LanguageText.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Mətinlər boş ola bilməz");
                return View(setting);
            }
            if (settingVM.PostDto.SocialIcons.Any(x => string.IsNullOrWhiteSpace(x))|settingVM.PostDto.SocialLinks.Any(x => string.IsNullOrWhiteSpace(x)))
            {
                ModelState.AddModelError("", "Sosial Şəbəkələr boş ola bilməz");
                return View(setting);
            }

            await _settingService.Update(id, settingVM.PostDto);
            return RedirectToAction(nameof(Index));
        }


    }
}
