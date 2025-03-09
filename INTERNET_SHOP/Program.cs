using INTERNET_SHOP.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using INTERNET_SHOP.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<INTERNET_SHOPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("INTERNET_SHOPContext") ?? throw new InvalidOperationException("Connection string 'INTERNET_SHOPContext' not found.")));


builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Authentication and Authorization
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "auth_token";
        options.LoginPath = "/login";
        options.Cookie.MaxAge = TimeSpan.FromMinutes(60);
        options.AccessDeniedPath = "/access-denied";
    });
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddDbContext<INTERNET_SHOPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("INTERNET_SHOPContext") ?? throw new InvalidOperationException("Connection string 'INTERNET_SHOPContext' not found.")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

//Errors
app.UseStatusCodePagesWithReExecute("/not-found");

app.UseStaticFiles();
app.UseAntiforgery();

//Authentication and Authorization
app.UseAuthentication();
app.UseAuthorization();



app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
