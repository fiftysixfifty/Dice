namespace MVCViewProject;

public class Program
{
    internal static void Main(string[] args)
    {
        WebApplication webApplication;
        {
            WebApplicationBuilder webApplicationBuilder =
                WebApplication.CreateBuilder(args: args);

            // Add services to the container.
            webApplicationBuilder.Services.AddControllersWithViews();

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