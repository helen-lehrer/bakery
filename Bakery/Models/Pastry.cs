using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public string Type { get; set;}
    public string Cost { get; set;}
    public string Deals {get; set;}

    public Pastry(string type, string cost, string deals)
    {
      Type = type;
      Cost = cost;
      Deals = deals;
    }    

    public int PastryCost(int numPastry)
    {
      if (numPastry == 3 || numPastry == 4 || numPastry == 5)
      {
        return ((numPastry * 2) - 1);
      }
      else if (numPastry > 5)
      {
        decimal dividedBySix = Decimal.Floor(numPastry / 6);
        int convertToInt = Convert.ToInt32(dividedBySix);
        return ((numPastry * 2) - (convertToInt * 2));
      }
      else 
      {
        return numPastry * 2;
      }
    }
  }
}