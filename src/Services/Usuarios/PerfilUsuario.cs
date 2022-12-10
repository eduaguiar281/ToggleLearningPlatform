using System;

namespace ToggleLearningPlatform.Services.Usuarios
{
    [Flags]
    public enum PerfilUsuario
    {
        None = 0,
        Padrao = 1,
        Expert = 2,
        Premium = 4,
        Exclusivo = 8
    }
}
