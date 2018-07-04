using Microsoft.AspNetCore.Mvc;
using CarDealerShip.Models;

namespace CarDealerShip.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Form()
    {
      return View();
    }
  }
}
