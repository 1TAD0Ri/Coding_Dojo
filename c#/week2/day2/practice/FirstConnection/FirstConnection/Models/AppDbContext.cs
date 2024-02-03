#pragma warning disable CS8618
using FirstConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstConnection.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Database tables must be added (Declared) Here : 
    public DbSet<Pet> Pets {get;set;}
    // public DbSet<User> Users {get; set;}
}