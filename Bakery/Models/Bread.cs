using System;

namespace Bakery.Models
{
  public class Bread
  {
    public string Type { get; set;}
    public string Cost { get; set;}
    public string Deals {get; set;}

    public Bread(string type, string cost, string deals)
    {
      Type = type;
      Cost = cost;
      Deals = deals;
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