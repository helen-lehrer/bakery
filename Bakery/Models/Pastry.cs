using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost(int numPastry)
    {
      if (numPastry == 3 || numPastry == 5)
      {
        return ((numPastry * 2) - 1);
      }
      // else if (numPastry > 5)
      // {
      //   decimal dividedBySix = Decimal.Floor(numPastry / 6);
      //   int convertToInt = Convert.ToInt32(dividedBySix);
      //   return ((numPastry * 2) - (convertToInt * 2));
      // }
      else 
      {
        return numPastry * 2;
      }
    }
  }
}