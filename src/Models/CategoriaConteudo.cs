﻿using System;

namespace ToggleLearningPlatform.Models
{
    [Flags]
    public enum CategoriaConteudo
    {
        None = 0,
        Fundamentos = 1,
        Avancado = 2,
        Arquitetura = 4
    }
}