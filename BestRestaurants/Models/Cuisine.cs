using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      JoinEntities = new HashSet<CuisineRestaurant>();
    }
    public int CuisineId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<CuisineRestaurant> JoinEntities { get; set; }
  }
}