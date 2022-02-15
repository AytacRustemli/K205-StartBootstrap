using K205Deneme.Models;
using Microsoft.EntityFrameworkCore;

namespace K205Deneme.Data
{
    public class DenemeDbContext : DbContext
    {
        public DenemeDbContext(DbContextOptions<DenemeDbContext> options)
            : base(options)
        {

        }

        public DbSet<Masthead> Mastheads { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
