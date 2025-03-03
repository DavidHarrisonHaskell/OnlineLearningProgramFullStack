using System.IdentityModel.Tokens.Jwt;
using System.Text.Json.Serialization;
//using AspNetCoreRateLimit;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;


namespace backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            AppConfig.Configure(builder.Environment);

            // build entire database inside the container if it doesn't exist yet:

            using(OnlineLearningPlatformContext db = new OnlineLearningPlatformContext())
            {
                db.Database.EnsureCreated();
            }


            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
