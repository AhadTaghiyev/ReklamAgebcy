using HomeService.app.ViewModel;
using HomeService.core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public async Task< IActionResult> Index()
        {
            List<AppUser> users =  _userManager.Users.ToList();
            return View(users);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginvm)
        {
            if (loginvm.UserName==null||loginvm.Password==null)
            {
                ModelState.AddModelError("", "Sifre ve Parolu duzgun daxil edin");
                return View();
            }

            AppUser appUser = await _userManager.FindByNameAsync(loginvm.UserName);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Sifre ve Parolu duzgun daxil edin");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginvm.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "duzgun username ve sifre daxil edin");
                return View();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public async Task<IActionResult> AdminCreate()
        {

            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminCreate(LoginVM loginVM)
        {
            if (loginVM.UserName == null||loginVM.Password==null)
            {
                ModelState.AddModelError("", "Xanaları düzgün doldurun");
                return View();
            }
           
           
            AppUser appuser = new AppUser
            {
              UserName=loginVM.UserName
            };

            IdentityResult result = await _userManager.CreateAsync(appuser, loginVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appuser, "Admin");
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

    }
}
