using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealerShip.Controllers;
using CarDealerShip.Models;

namespace CarDealerShip.Test
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Home_ReturnsCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult carView = controller.Form();

      //Assert
      Assert.IsInstanceOfType(carView, typeof(ViewResult));
    }
  }

  [TestClass]
  public class CarsControllerTest
  {
    [TestMethod]
    public void Car_HasCorrectModelType_True()
    {
      //arrange
      CarsController controller = new CarsController();
      IActionResult actionResult = controller.Car();
      ViewResult carView = controller.Car() as ViewResult;

      //act
      var result = carView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Cars>));
    }
  }
}
