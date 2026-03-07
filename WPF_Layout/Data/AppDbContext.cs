using Microsoft.EntityFrameworkCore;
using WPF_Layout.Models;

namespace WPF_Layout.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=WPFAppLearnDB.db");
            }
        }
    }
}
