using HomeService.app.ViewModel;
using HomeService.service.Dtos.SeoDescriptionDto;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SeoDescriptionController : Controller
    {
        private readonly ISeoDescriptionService _seoDescriptionService;

        public SeoDescriptionController(ISeoDescriptionService seoDescriptionService)
        {
            _seoDescriptionService = seoDescriptionService;
        }

        public async Task<IActionResult> Index()
        {
            SeoDescriptionGetDto seoDescriptionGet = await _seoDescriptionService.Get();
            return View(seoDescriptionGet);
        }

        public async Task<IActionResult> Update(int id)
        {
            SeoDescriptionVM seoDescriptionVM = new SeoDescriptionVM
            {
                SeoDescriptionGetDto=await _seoDescriptionService.GetByIdAsync(id),
            };
            return View(seoDescriptionVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,SeoDescriptionVM seoDescriptionVM)
        {
            await _seoDescriptionService.Update(id,seoDescriptionVM.SeoDescriptionPostDto);
            return RedirectToAction("Index","SeoDescription");
        }
    }


}
