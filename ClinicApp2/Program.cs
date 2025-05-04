using ClinicApp2.DAL;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContexts>(opt =>
            opt.UseSqlServer(@"Server = SLYMNF29\SQLEXPRESS; Database =ClinicDB ; Trusted_Connection = True;TrustServerCertificate=True"));
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
                );
            app.MapControllerRoute(
                name: "default",
                pattern: "{Controller=Home}/{Action=Index}/{id?}"
                );

            

            app.Run();
        }
    }
}
