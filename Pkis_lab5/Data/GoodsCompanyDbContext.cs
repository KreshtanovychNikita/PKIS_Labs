using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Lab5.Data;

public sealed class GoodsCompanyDbContext : DbContext
{
   public DbSet<Person> Person { get; set; } = null!;
    public DbSet<Goods> Goods { get; set; } = null!;
    public DbSet<Company> Company { get; set; } = null!;
    
    public GoodsCompanyDbContext(DbContextOptions<GoodsCompanyDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
