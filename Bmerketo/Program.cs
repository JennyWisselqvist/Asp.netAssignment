using Bmerketo.Contexts;
using Bmerketo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("BmerketoSql")));
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("IdentitySql")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>(x =>
{
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
    x.SignIn.RequireConfirmedEmail = false;
}).AddEntityFrameworkStores<IdentityContext>();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Account/SignIn";
    x.AccessDeniedPath = "/Errors/AccessDenied";
});

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
