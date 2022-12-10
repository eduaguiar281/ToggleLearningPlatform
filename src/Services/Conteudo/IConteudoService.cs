using System.Collections.Generic;
using ToggleLearningPlatform.Models;

namespace ToggleLearningPlatform.Services.Conteudo
{
    public interface IConteudoService
    {
        IEnumerable<ConteudoViewModel> ObterConteudo(CategoriaConteudo categoriaConteudo);
    }
}
