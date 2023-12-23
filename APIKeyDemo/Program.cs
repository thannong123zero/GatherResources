
using APIKeyDemo.CustomFilterActions;
using APIKeyDemo.Midleware;

namespace APIKeyDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IApiKeyValidation, ApiKeyValidation>();
            //builder.Services.AddScoped<ApiKeyAuthFilter>();
            //Also, we should register the IHttpContextAccessor service in the Program class to be able to access the HttpContext:
            //builder.Services.AddHttpContextAccessor();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseMiddleware<ApiKeyMiddleware>();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}