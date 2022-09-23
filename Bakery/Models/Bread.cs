using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string[] Type { get; set;}
    public string Cost { get; set;}
    public string Deals {get; set;}

    public Bread(string[] type, string cost, string deals)
    {
      Type = type;
      Cost = cost;
      Deals = deals;
    }

    public int assignType (string breadTypeInput)
    {
      if (breadTypeInput == "white")
      {
        return bread.Type[0];
      }
      else if (breadTypeInput == "whole wheat")
      {
        return bread.Type[1];
      }
      else if (breadTypeInput == "pumpernickel")
      {
        return bread.Type[2];
      }
      else 
      {
        return "Sorry, we do not have that variety. If it is listed on the menu, check for typos.";
      }
    }    
    
    public int BreadCost(int numLoaves)
    {
      if (numLoaves == 1)
      {
        return 5;
      }
      else if (numLoaves == 2)
      {
        return 10;
      }
      else if (numLoaves >= 3)
      {
        decimal dividedByThree = Decimal.Floor(numLoaves / 3);
        int convertToInt = Convert.ToInt32(dividedByThree);
        return ((numLoaves - convertToInt) * 5); 
      }
      else 
      {
        return 0;
      }
    }
  }
}