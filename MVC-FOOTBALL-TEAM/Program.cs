using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_FOOTBALL_TEAM.Data;
using MVC_FOOTBALL_TEAM.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVC_FOOTBALL_TEAMContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVC_FOOTBALL_TEAMContext") ?? throw new InvalidOperationException("Connection string 'MVC_FOOTBALL_TEAMContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData2.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData3.Initialize(services);
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData4.Initialize(services);
}

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

app.Run();
