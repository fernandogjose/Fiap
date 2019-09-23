using Fiap.Application.Interfaces.AppServices;
using Fiap.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Mvc.Controllers
{

    public class HomeController : Controller {

        private readonly IBlogAppService _blogAppService;

        public HomeController (IBlogAppService blogAppService) {
            _blogAppService = blogAppService;
        }

        public IActionResult Index () {
            try {
                BlogViewModel blog = _blogAppService.ListTop10 ("https://www.minutoseguros.com.br/blog/feed/");
                return View (blog);
            } catch {
                return View (null);
            }

        }
    }
}