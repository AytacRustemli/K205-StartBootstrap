using K205Deneme.Models;
using Microsoft.EntityFrameworkCore;

namespace K205Deneme.Data
{
    public class DenemeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DenemeDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Masthead> Mastheads { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
