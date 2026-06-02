
using Microsoft.EntityFrameworkCore;

namespace DotNg.Data;

public class AppDbContext : DbContext 
{
   private DbSet<Students.Students>  Students { get; set; }
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseSqlServer(
         connectionString: "Server=Gabriel;Database=RiderApi;User Id=sa;Password=1234;TrustServerCertificate=True;");
      base.OnConfiguring(optionsBuilder);
   }
}