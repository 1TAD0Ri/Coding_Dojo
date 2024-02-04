#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace CruDelicious.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Database tables must be added (Declared) Here : 
    public DbSet<Dishe> Dishes {get;set;}
    // public DbSet<User> Users {get; set;}
}