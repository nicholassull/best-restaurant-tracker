using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public string Location { get; set; }
    public int AvgMealCost { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
  }
}