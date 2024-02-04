#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace LogReg.Models;

 public class AppDbContext : DbContext
 {
    public AppDbContext(DbContextOptions options):base(options){}
    
        //our DataBase Tables
        public DbSet<User> Users { get; set; }

    
 }