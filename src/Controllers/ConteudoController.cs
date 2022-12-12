using Microsoft.AspNetCore.Mvc;
using ToggleLearningPlatform.Models;
using ToggleLearningPlatform.Services.Conteudo;

namespace ToggleLearningPlatform.Controllers
{
    public class ConteudoController : Controller
    {
        private readonly IConteudoService _conteudoService;

        public ConteudoController(IConteudoService conteudoService)
        {
            _conteudoService = conteudoService;
        }

        public IActionResult Fundamentos() => View(_conteudoService.ObterConteudo(CategoriaConteudo.Fundamentos));

        public IActionResult Avancado() => View(_conteudoService.ObterConteudo(CategoriaConteudo.Avancado));

        public IActionResult Arquitetura() => View(_conteudoService.ObterConteudo(CategoriaConteudo.Arquitetura));
        public IActionResult TenhoInteresse() => View();

    }
}
