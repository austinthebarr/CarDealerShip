using Microsoft.AspNetCore.Mvc;
using CarDealerShip.Models;
using System.Collections.Generic;

namespace CarDealerShip.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/Cars")]
    public ActionResult Car()
    {
      Cars newCars = new Cars(Request.Query["car-make"], Request.Query["car-year"]);
      newCars.Save();
      List<Cars> all = Cars.GetAll();
      return View(all);
    }
  }
}
