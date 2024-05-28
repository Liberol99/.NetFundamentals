using BusinessLayer.Abstract;
using BusinessLayer.AdoNet;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Validators;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Razor Component Ýçin Gerekli
builder.Services.AddServerSideBlazor();
// Dependecy Injection için IOC DbContext bildirildi.
builder.Services.AddDbContext<NorthwindContext>(_ => _.UseSqlServer(@"Server=DESKTOP-TUSNPG5\SQL22;Database=Northwind;User Id=sa;Password=s;"));
// Dependecy Injection için IOC bildirildi.
builder.Services.AddScoped<IAdoService, AdoManager>();
builder.Services.AddScoped<IProductDal, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICustomerDal, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
// FluentValidation bildirildi.
builder.Services.AddControllersWithViews().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CustomerValidator>());


// Authentication için gerekli iþlemler.
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option => {
        option.LoginPath = "/Login/Login";
        option.AccessDeniedPath = "/Login/AccessDenied";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Authentication ve Authorization için gerekli.
app.UseAuthentication();    
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Area için eklendi.
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
    );
});

// Razor component için gerekli. + Layoutta en alta bak
app.MapBlazorHub();

app.Run();
