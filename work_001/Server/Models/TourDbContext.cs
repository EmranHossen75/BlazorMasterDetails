using Microsoft.EntityFrameworkCore;
using work_001.Shared;

namespace work_001.Server.Models
{
    public class TourDbContext:DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options):base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Spot> Spots { get; set; }=default!;
        public DbSet<BookingEntry> BookingEntries { get; set; }= default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spot>().HasData(
                new Spot { SpotId=1,SpotName="Coxs Bazar"},
                new Spot { SpotId=2,SpotName="Bandarban"},
                new Spot { SpotId=3,SpotName="Darjeling"},
                new Spot { SpotId=4,SpotName="Shilong"},
                new Spot { SpotId=5,SpotName="Meghaloy"}
                );
        }

    }
}
