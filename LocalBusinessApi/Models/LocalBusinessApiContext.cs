using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
    public class LocalBusinessApiContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }

        public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Business>().HasData(
                new Business { BusinessId = 1, Name = "The Corner Store", BusinessType = "Convieniece Store", Description = "Beer, wine, and snacks", Reviews = "Basic seletion of snacks, good selection of beer, however the wine is not organic" },
                new Business { BusinessId = 2, Name = "Taste of PDX", BusinessType = "Resturant", Description = "Casual Dining with full menu and bar", Reviews = "Good place for group dinners and happy hour" },
                new Business { BusinessId = 3, Name = "Shelly's Hardware", BusinessType = "Hardware Store", Description = "Locally owned hardware store", Reviews = "Small hardware store with decent selection of DIY home repair" }
            );

        }
    }

}