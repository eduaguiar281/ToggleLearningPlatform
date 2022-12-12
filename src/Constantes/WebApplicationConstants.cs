namespace ToggleLearningPlatform.Constantes
{
    public static class WebApplicationConstants
    {
        public const string Versao = "1.0.0";

        public static IWebHostEnvironment Environment;

        public static readonly string Ambiente = Environment is null ? "Development" : Environment.EnvironmentName;
    }
}
