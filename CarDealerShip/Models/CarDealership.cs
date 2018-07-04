using System;
using System.Collections.Generic;

namespace CarDealerShip.Models
{
  public class Cars
  {
    private string _makeModel;
    private string _price;
    private string _miles;
    private string _color;
    private string _year;
    private static List<Cars> _instances = new List<Cars> {};

    public Cars (string makeModel, string year)
    {
      _makeModel = makeModel;
      _year = year;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(string newPrice)
    {
      _price = newPrice;
    }
    public string GetPrice()
    {
      return _price;
    }

    public void SetMiles(string newMiles)
    {
      _miles = newMiles;
    }
    public string GetMiles()
    {
      return _miles;
    }

    public void SetColor(string newColor)
    {
      _color = newColor;
    }
    public string GetColor()
    {
      return _color;
    }

    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public string GetYear()
    {
      return _year;
    }

    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Cars> GetAll()
    {
      return _instances;
    }
  }
}
