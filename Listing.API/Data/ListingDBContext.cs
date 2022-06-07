using Microsoft.EntityFrameworkCore;

namespace Listing.API.Data
{
    public class ListingDBContext : DbContext
    {
        public ListingDBContext(DbContextOptions options):base(options)
        {
        }


        public DbSet<Hotel> Hotels { set; get; }
        public DbSet<Country> Countries { set; get; }
    }
}
