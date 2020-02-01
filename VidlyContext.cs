using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly
{
  public class VidlyContext : DbContext
  {
    public VidlyContext(DbContextOptions<VidlyContext> options)
       : base(options)
    { }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql("Host=localhost;Database=vidly;Username=postgres;Password=password");

  }
}