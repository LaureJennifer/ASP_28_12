using ASP_28_12.Domains.EF;
using ASP_View.Data;
using ASP_View.Services.Login;
using ASP_View.Services.Order;
using ASP_View.Services.OrderDetails;
using ASP_View.Services.Product;
using ASP_View.Services.User;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

namespace ASP_View
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            builder.Services.AddScoped<IAuthApiClient, AuthApiClient>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7066") });

            builder.Services.AddTransient<IProductApiClient, ProductApiClient>();
            builder.Services.AddTransient<IUserApiClient, UserApiClient>();
            builder.Services.AddTransient<IOrderApiClient, OrderApiClient>();
            builder.Services.AddTransient<IOrderDetailsApiClient, OrderDetailsApiClient>();

            builder.Services.AddMudServices();
            builder.Services.AddDbContext<FlowerDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
            });
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}