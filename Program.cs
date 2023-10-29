using Microsoft.EntityFrameworkCore;
using Trab001.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer("Data Source = DESKTOP-126PQJ2\\MSSQLMATEPASO; Initial Catalog = bd_loja; User = sa; Password = p@gnossim1542004; TrustServerCertificate = True;"));

var app = builder.Build();

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
