using Lab6.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Lab6.Data;

public sealed class LibraryDbContext : DbContext
{
    public DbSet<Person> Person { get; set; } = null!;
    public DbSet<Goods> Goods { get; set; } = null!;
    public DbSet<Company> Company { get; set; } = null!;
    
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
