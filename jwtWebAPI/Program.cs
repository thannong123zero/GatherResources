
using jwtWebAPI.Helpers;
using jwtWebAPI.Models;
using Microsoft.Extensions.Configuration;

namespace jwtWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            var appconfig = builder.Configuration.GetSection("JwtConfig");
            JwtConfig jwtConfig = appconfig.Get<JwtConfig>();
            builder.Services.AddSingleton(jwtConfig);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<MasterModelHelper>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}