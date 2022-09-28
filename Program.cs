using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AiresAcondDomi.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(IdentityOptions options =>
{
    //Autenticacion del ususrio
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;

    //Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;

    //user settings
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstUvyzABCDEFGHIJKLMNOPQRSTUVYZ0123456789-.@+";
    options.User.RequireUniqueEmail = false;
});

builder.Services.ConfigureApplicationCookie(CookieAuthenticationOptions options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpam = TimeSpan.FromMinutes(5);
    
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccesDenied";
    options.SlidingExpiration = true;
});
builder.Services.AddDbContext<AppAuthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppAuthDbContext") ?? throw new InvalidOperationException("Connection string 'AppAuthDbContext' not found.")));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
