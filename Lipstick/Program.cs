using Lipstick;
using Lipstick._Convergence.DataAccess;
using Lipstick._Convergence.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

// #region Database
string connection = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connection));
//#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();
//add service language
#region ServiceLanguage
builder.Services.AddSingleton<WebAppLanguageService>();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization(options =>
    {
        options.DataAnnotationLocalizerProvider = (type, factory) =>
        {
            var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
            return factory.Create("SharedResource", assemblyName.Name);
        };
    });
builder.Services.Configure<RequestLocalizationOptions>(
    options =>
    {
        var supportedCultures = new List<CultureInfo>
            {
                            new CultureInfo("vi-VN"),
                            new CultureInfo("en-US"),
            };
        options.DefaultRequestCulture = new RequestCulture(supportedCultures.First());
        options.SupportedCultures = supportedCultures;
        options.SupportedUICultures = supportedCultures;

        var cookieProvider = options.RequestCultureProviders
            .OfType<CookieRequestCultureProvider>()
            .First();
        cookieProvider.Options.DefaultRequestCulture = new RequestCulture("vi-VN");
        options.RequestCultureProviders.Clear();
        options.RequestCultureProviders.Add(cookieProvider);


        options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
    });
#endregion
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.SignUp();
var app = builder.Build();
#region localize language
var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(locOptions.Value);
//app.UseRequestLocalization(new RequestLocalizationOptions
//{
//    ApplyCurrentCultureToResponseHeaders = true
//});
//app.UseRequestLocalization(options =>
//{
//    var questStringCultureProvider = options.RequestCultureProviders[0];
//    options.RequestCultureProviders.RemoveAt(0);
//    options.RequestCultureProviders.Insert(1, questStringCultureProvider);
//});
#endregion
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.UseStatusCodePagesWithRedirects("/Home/Lost");


app.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
