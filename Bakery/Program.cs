using System;
using Bakery.Models;

class Program
{
  public static void Main()
  {
    //Constructors
    string[] breadTypes = {"white", "whole wheat", "pumpernickel"};
    string[] pastryTypes = {"croissant", "puff", "macaron"};
    Bread bread = new Bread(breadTypes, "5", "Buy 2, get 1 free!");
    Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
    //Menu
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("------Menu------");
    Console.WriteLine("BREAD\nVarieties: "+ bread.Type[0] + ", " + bread.Type[1] + ", " + bread.Type[2]+"\nPrice: $" + bread.Cost + "\nDeals: " + bread.Deals +"\n");
     Console.WriteLine("PASTRIES\nVarieties: " + pastry.Type[0] + ", " + pastry.Type[1] + ", " + pastry.Type[2]+"\nPrice: $" + pastry.Cost + "\nDeals: " + pastry.Deals +"\n----------------");
     //Order
     Console.WriteLine("How many loaves of bread would you like to order?");
     string stringNumLoaves = Console.ReadLine();
     int intNumLoaves = Int32.Parse(stringNumLoaves);
     if (stringNumLoaves != "0")
     {
      Console.WriteLine("What variety of bread would you like?\nEnter 1 for white, 2 whole wheat, or 3 for pumpernickel");
      string breadTypeInput = Console.ReadLine();
     }
     Console.WriteLine("How many pastries would you like to order?");
     string stringNumPastries = Console.ReadLine();
     int intNumPastries = Int32.Parse(stringNumPastries);
     int totalCost = bread.BreadCost(intNumLoaves) + pastry.PastryCost(intNumPastries);
     //Display Total Cost
     Console.WriteLine(stringNumLoaves +" Order(s) of Bread: $" + bread.BreadCost(intNumLoaves) + " (" + ")");
     Console.WriteLine(stringNumPastries +" Order(s) of Pastries: $" + pastry.PastryCost(intNumPastries));
     Console.WriteLine("Total Cost = $" + totalCost);
     //Exit App or Return to Menu
     Console.WriteLine("Would you like to place another order? (Y/N)");
     string exitApp = Console.ReadLine();
     if (exitApp == "Y" | exitApp == "y")
     {
      Main();
     }
  }
}
