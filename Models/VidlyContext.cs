using Microsoft.EntityFrameworkCore;

namespace Vidly.Models
{
  public class VidlyContext : DbContext
  {
    public VidlyContext(DbContextOptions<VidlyContext> options)
      :base(options)
      {
      }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Customer> Customers { get; set; }
  }
}