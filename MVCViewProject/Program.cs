// For AddControllersWithViews():
using static Microsoft.Extensions.DependencyInjection.MvcServiceCollectionExtensions;

// GetConnectionString():
//using static Microsoft.Extensions.Configuration.ConfigurationExtensions;

// For UseSqlite():
//using static Microsoft.EntityFrameworkCore.SqliteDbContextOptionsBuilderExtensions;

// AddDbContext<>():
//using static
//    Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions;

// IsDevelopment():
using static Microsoft.Extensions.Hosting.HostEnvironmentEnvExtensions;

// UseExceptionHandler():
using static Microsoft.AspNetCore.Builder.ExceptionHandlerExtensions;

// UseHsts():
using static Microsoft.AspNetCore.Builder.HstsBuilderExtensions;

// UseHttpsRedirection():
using static Microsoft.AspNetCore.Builder.HttpsPolicyBuilderExtensions;

// UseStaticFiles():
using static Microsoft.AspNetCore.Builder.StaticFileExtensions;

// UseRouting():
using static Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions;

// UseAuthorization():
using static Microsoft.AspNetCore.Builder.AuthorizationAppBuilderExtensions;

// MapControllerRoute():
using static Microsoft.AspNetCore.Builder.ControllerEndpointRouteBuilderExtensions;

namespace MVCViewProject;

public class Program
{
    internal static void Main(string[] args)
    {
        Microsoft.AspNetCore.Builder.WebApplication webApplication;
        {
            Microsoft.AspNetCore.Builder.WebApplicationBuilder webApplicationBuilder =
                Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args: args);

            // Add services to the container.
            {
                Microsoft.Extensions.DependencyInjection.IServiceCollection
                    serviceCollection = webApplicationBuilder.Services;

                serviceCollection.AddControllersWithViews();

                /*string? connectionString =
                    webApplicationBuilder.Configuration.GetConnectionString(
                        name: "SQLite");

                MVCViewProject.Storage.DbContext.SetConnectionString(
                    connectionString: connectionString);
                serviceCollection.AddDbContext<MVCViewProject.Storage.DbContext>(
                    optionsAction:
                        (Microsoft.EntityFrameworkCore.DbContextOptionsBuilder
                            dbContextOptionsBuilder) =>
                        dbContextOptionsBuilder.UseSqlite(
                            connectionString: connectionString));*/
            }
            webApplication = webApplicationBuilder.Build();
        }

        // Configure the HTTP request pipeline.
        if (!webApplication.Environment.IsDevelopment())
        {
            webApplication.UseExceptionHandler(errorHandlingPath: "/Home/Error");

            // The default HSTS value is 30 days. You may want to change this for
            // production scenarios, see https://aka.ms/aspnetcore-hsts.
            webApplication.UseHsts();
        }

        webApplication.UseHttpsRedirection();
        webApplication.UseStaticFiles     ();

        webApplication.UseRouting();

        webApplication.UseAuthorization();

        webApplication.MapControllerRoute(
            name   : "default"                               ,
            pattern: "{controller=Home}/{action=Index}/{id?}");

        webApplication.Run();
    }
}