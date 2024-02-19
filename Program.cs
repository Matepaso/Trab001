
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using Trab001.Models;
using Trab001.Repositorio;

var builder = WebApplication.CreateBuilder(args);
var defaultCulture = "pt-BR";
var ci = new CultureInfo(defaultCulture);
ci.NumberFormat.NumberDecimalSeparator = ".";
ci.NumberFormat.CurrencyDecimalSeparator = ".";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer("Data Source = DESKTOP-126PQJ2\\MSSQLMATEPASO; Initial Catalog = bd_loja; User = sa; Password = p@gnossim1542004; TrustServerCertificate = True;"));
builder.Services.AddDbContext<ContextoUsuario>(options => options.UseSqlServer("Data Source = DESKTOP-126PQJ2\\MSSQLMATEPASO; Initial Catalog = bd_loja; User = sa; Password = p@gnossim1542004; TrustServerCertificate = True;"));

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
var app = builder.Build();

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(ci),
    SupportedCultures = new List<CultureInfo>
    {
        ci,
    },
    SupportedUICultures = new List<CultureInfo>
    {
        ci,
    }
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


