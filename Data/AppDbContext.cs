
using Microsoft.EntityFrameworkCore;

namespace DotNg.Data;

public class AppDbContext : DbContext 
{
   public DbSet<Students.Students>  Students { get; set; }
   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseSqlServer(
         connectionString: "Server=Gabriel;Database=RiderApi;User Id=sa;Password=1234;TrustServerCertificate=True;");
      optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
      
      base.OnConfiguring(optionsBuilder);
   }
}