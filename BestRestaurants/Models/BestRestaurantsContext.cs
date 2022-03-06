using Microsoft.EntityFrameworkCore;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContext : DbContext
  {
    public DbSet<DatabaseTablePlaceholder> DatabaseTablePlaceholder { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}