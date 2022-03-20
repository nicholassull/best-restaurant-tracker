namespace BestRestaurants.Models
{
  public class CuisineRestaurant
  {
    public int CuisineRestaurantId { get; set; }
    public int CuisineId { get; set; }
    public int RestaurantId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}