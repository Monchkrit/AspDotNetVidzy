using System;
using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly
{
  public class VidlyContext : DbContext
  {
    public VidlyContext()
    {
    }
    public VidlyContext(DbContextOptions<VidlyContext> options)
       : base(options)
    { }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MembershipType> MembershipTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql("Host=localhost;Database=vidly;Username=postgres;Password=password");
  }
}