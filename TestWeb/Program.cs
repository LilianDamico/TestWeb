using Microsoft.EntityFrameworkCore;
using TestWeb.Context;
using TestWeb.Repositories;
using TestWeb.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddTransient<IMovimentationTypeRepository, MovimentationTypeRepository>();
builder.Services.AddTransient<IMovimentationRepository, MovimentationRepository>();
builder.Services.AddTransient<IContainerRepository, ContainerRepository>();



var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "LoginPage",
    pattern: "{action=LoginPage}/{id?}");

app.MapControllerRoute(
    name: "Container",
    pattern: "{action=Container}/{id?}");

app.MapControllerRoute(
    name: "Movimentation",
    pattern: "{action=Movimentation}/{id?}");

app.Run();
