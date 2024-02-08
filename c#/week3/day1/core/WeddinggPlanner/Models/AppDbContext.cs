#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;

namespace WeddinggPlanner.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Our Database Tables 

    public DbSet<User> Users { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Guest> Guests { get; set; }
}