namespace backend;

public class AppConfig
{

    public static string ConnectionString { get; private set; } = null!; // private set means you can only change the value within this AppConfig file itself
    public static bool IsDevelopment { get; private set; }
    public static bool IsProduction { get; private set; }
    public static string JwtKey { get; private set; } = "The Amazing Talent Class - עם ישראל חי! The Amazing Talent Class - עם ישראל חי!";

    public static void Configure(IWebHostEnvironment env)
    {
        IsDevelopment = env.IsDevelopment();
        IsProduction = env.IsProduction();
        IConfigurationRoot settings = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json").Build(); // appsettings.Development.json or appsettings.Production.json
        // this should give back the correct connection string
        ConnectionString = settings.GetConnectionString("OnlineLearningPlatform")!;
    }

}
