
namespace BestRestaurants.Models
{
  public class Review
  {
    public int Stars { get; set; }
    public string User { get; set; }
    public string Text { get; set; }
    public int RestaurantId { get; set; }
    // public virtual Cuisine Cuisine { get; set; }
  }
}