using Microsoft.EntityFrameworkCore;
using MultipleDatabase.DataAccess;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("MySqlConnection");
// Add services to the container.
builder.Services.AddDbContext<ApplicationDatabaseContext>(options =>
                options.UseMySql(connection,ServerVersion.AutoDetect(connection)));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
