using Microsoft.AspNetCore.Mvc;

namespace BestRestaurants.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Home";
      return View();
    }
  }
}