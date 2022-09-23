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
        else
        {
        return 1;
        }
    }
    // properties, methods, etc. will go here.

  }
}