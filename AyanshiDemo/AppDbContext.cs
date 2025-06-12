using AyanshiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace AyanshiDemo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
    }
}
