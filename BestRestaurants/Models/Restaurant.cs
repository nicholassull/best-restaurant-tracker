using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public string Location { get; set; }
    public int AvgMealCost { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}