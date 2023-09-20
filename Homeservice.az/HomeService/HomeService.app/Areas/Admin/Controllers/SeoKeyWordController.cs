using HomeService.app.ViewModel;
using HomeService.service.Dtos.SeoDescriptionDto;
using HomeService.service.Dtos.SeoKeyWordDto;
using HomeService.service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HomeService.app.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SeoKeyWordController : Controller
    {
        private readonly ISeoKeyWordService _ISeoKeyWordService;

        public SeoKeyWordController(ISeoKeyWordService seoKeyWordService)
        {
            _ISeoKeyWordService = seoKeyWordService;
        }

        public async Task<IActionResult> Index()
        {
            SeoKeyWordGetDto seoKeyWordGetDto = await _ISeoKeyWordService.Get();
            return View(seoKeyWordGetDto);
        }

        public async Task<IActionResult> Update(int id)
        {
            SeoKeyWordVM SeoKeyWordVM = new SeoKeyWordVM
            {
                SeoKeyWordGetDto=await _ISeoKeyWordService.GetByIdAsync(id),
            };
            return View(SeoKeyWordVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, SeoKeyWordVM SeoKeyWordVM)
        {
            await _ISeoKeyWordService.Update(id, SeoKeyWordVM.SeoKeyWordPostDto);
            return RedirectToAction(nameof(Index));
        }
    }


}
