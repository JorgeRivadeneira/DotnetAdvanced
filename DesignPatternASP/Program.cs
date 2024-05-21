using DesignPatternASP.Configuration;
using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using Microsoft.EntityFrameworkCore;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<MyConfig>(options =>
{
    builder.Configuration.GetSection("MyConfig").Bind(options);
});

builder.Services.AddDbContext<DesignPatternsConsoleDbContext>(opciones =>
    opciones.UseSqlServer("DefaultConnection"));

builder.Services.AddTransient<LocalEarnFactory>(provider =>
{
    return new LocalEarnFactory(builder.Configuration.GetSection("MyConfig").GetValue<decimal>("LocalPercentage"));
});

builder.Services.AddTransient<ForeignEarnFactory>(provider =>
{
    var foreignPct = builder.Configuration.GetSection("MyConfig").GetValue<decimal>("ForeignPercentage");
    var extra = builder.Configuration.GetSection("MyConfig").GetValue<decimal>("Extra");
    return new ForeignEarnFactory(foreignPct, extra);
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

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

app.Run();
