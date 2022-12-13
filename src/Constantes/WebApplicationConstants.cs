﻿namespace ToggleLearningPlatform.Constantes
{
    public static class WebApplicationConstants
    {
        public const string Versao = "1.3.0";

        public static IWebHostEnvironment LocalEnvironment;

        public static string Ambiente() => LocalEnvironment is null ? "Development" : LocalEnvironment.EnvironmentName;
    }
}
