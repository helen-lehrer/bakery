using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost(int numLoaves)
    {
        if (numLoaves == 1)
        {
            return 5;
        }
        else if (numLoaves == 2 | numLoaves == 3)
        {
            return 10;
        }
        // else if (numLoaves > 3)
        // {
           
        //    decimal dividedByThree = Decimal.Floor(numLoaves / 3);
        //    Math.Truncate(dividedByThree);
        //    return (numLoaves - dividedByThree * 5); 
        // }
        else 
        {
            return 10000;
        }
    }
    // properties, methods, etc. will go here.

  }
}