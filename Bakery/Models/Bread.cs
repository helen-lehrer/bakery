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

    public string assignType (string breadTypeInput, Bread bread)
    {
      if (breadTypeInput == "1")
      {
        return bread.Type[0];
      }
      else if (breadTypeInput == "2")
      {
        return bread.Type[1];
      }
      else if (breadTypeInput == "3")
      {
        return bread.Type[2];
      }
      else 
      {
        return "You've entered an incorrect input. Please enter 1, 2, or 3.";
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