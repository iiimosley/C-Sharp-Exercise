using Microsoft.EntityFrameworkCore;

namespace restaurantAPI.Models
{
  public class RestaurantContext : DbContext
  {
    public RestaurantContext(DbContextOptions<RestaurantContext> options)
        : base(options)
    {
    }

    public DbSet<Restaurant> Restaurants { get; set; }
  }
}