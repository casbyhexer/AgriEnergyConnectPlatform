
using Microsoft.EntityFrameworkCore;
using AgriEnergyConnectPlatform.Models.Entities;

namespace AgriEnergyConnectPlatform.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
            Farmer = Set<Farmers>();
            Products = Set<Products>();
        }

        public DbSet<Farmers> Farmer { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farmers>()
                .HasNoKey(); // it is a keyless entity

            
        }

    }
}
