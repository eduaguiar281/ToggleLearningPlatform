using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using ToggleLearningPlatform.Models;
using ToggleLearningPlatform.Services.Conteudo;

namespace ToggleLearningPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConteudoService _conteudoService;

        public HomeController(IConteudoService conteudoService)
        {
            _conteudoService = conteudoService;
        }

        public IActionResult Index() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
