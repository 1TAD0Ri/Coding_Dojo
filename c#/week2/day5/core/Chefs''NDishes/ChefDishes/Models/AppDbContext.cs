#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;

namespace ChefDishes.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Our Database Tables 
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Chef> Chefs { get; set; }
}