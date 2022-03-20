using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public string Location { get; set; }
    [DisplayName("Average Meal Cost")]
    public int AvgMealCost { get; set; }
    public virtual ICollection<CuisineRestaurant> JoinEntities { get; set; }
    public Restaurant()
    {
      JoinEntities = new HashSet<CuisineRestaurant>();
    }
  }
}