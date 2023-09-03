// For UseSqlite():
using static Microsoft.EntityFrameworkCore.SqliteDbContextOptionsBuilderExtensions;

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

                string? connectionString =
                    webApplicationBuilder.Configuration.GetConnectionString(
                        name: "SQLite");

                MVCViewProject.Storage.DbContext.SetConnectionString(
                    connectionString: connectionString);
                serviceCollection.AddDbContext<MVCViewProject.Storage.DbContext>(
                    optionsAction:
                        (Microsoft.EntityFrameworkCore.DbContextOptionsBuilder
                            dbContextOptionsBuilder) =>
                        dbContextOptionsBuilder.UseSqlite(
                            connectionString: connectionString));
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