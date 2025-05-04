using ClinicApp2.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp2.DAL
{
    public class AppDbContexts:DbContext
    {
        public AppDbContexts(DbContextOptions<AppDbContexts> opt):base(opt) 
        {
            
        }
        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             base.OnConfiguring(optionsBuilder);
             optionsBuilder.UseSqlServer(@"Server = SLYMNF29\SQLEXPRESS; Database =ClinicDB ; Trusted_Connection = True;TrustServerCertificate=True");
         }*/
       public DbSet<Department> Departments { get; set; }
       public DbSet<Doctor> Doctors { get; set; }
    }
}
