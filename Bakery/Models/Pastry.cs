using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost(int numPastry)
    {
      if (numPastry == 1)
      {
        return 2;
      }
      // else if (numLoaves == 2)
      // {
      //   return 10;
      // }
      // else if (numLoaves >= 3)
      // {
      //   decimal dividedByThree = Decimal.Floor(numLoaves / 3);
      //   int convertToInt = Convert.ToInt32(dividedByThree);
      //   return ((numLoaves - convertToInt) * 5); 
      // }
      else 
      {
        return 0;
      }
    }
  }
}