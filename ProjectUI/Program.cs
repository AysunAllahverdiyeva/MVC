using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjectDataAccsesLayer.Abstract.Products;
using ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Products;
using ProjectDataAccsesLayer.EntityFrameworks.Context;
using ProjectBusinessLogic.Ioc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FootWearContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("Local")));
builder.Services.AddServices(); 


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
