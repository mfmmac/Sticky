using Microsoft.AspNetCore.Mvc;
using StickyRegistration.Services;
using StickyRegistration.Models;

namespace StickyRegistration.Controllers
{
    public class StickyRegistrationController : Controller
    {

        private readonly IStickyService _stickyService;
        public StickyRegistrationController(IStickyService stickyService)
        {
            _stickyService = stickyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StickyResultView(StickyRegistrationViewModel stickyRegistrationViewModel)
        {
            var result = _stickyService.Sticky(stickyRegistrationViewModel);

            return View(result);
        }
    }
}
