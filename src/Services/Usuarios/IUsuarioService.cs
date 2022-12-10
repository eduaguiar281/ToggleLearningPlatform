using System.Security.Claims;
using ToggleLearningPlatform.Models;

namespace ToggleLearningPlatform.Services.Usuarios
{
    public interface IUsuarioService
    {
        bool ConteudoLiberado(CategoriaConteudo categoria, ClaimsPrincipal user);
        PerfilUsuario ObterPerfil(string email);
    }
}
