using Microsoft.EntityFrameworkCore;
using SparePartsOutletApp.Context.SeedData;
using SparePartsOutletApp.Models.Entities;

namespace SparePartsOutletApp.Context
{
    public class AppDbContext : DbContext
    {
        private readonly ISeedData _seedData;

        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, ISeedData seedData) : base(options)
        {
            _seedData = seedData;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(_seedData.SeedAdmin());
        }
    }
}
