using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_ReturnSinglePastryCost_Int()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(2, pastry.PastryCost(1));
    } 

    [TestMethod]
    public void PastryCost_ReturnThreePastriesCost_Int()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(5, pastry.PastryCost(3));
    }

    [TestMethod]
    public void PastryCost_ReturnFourPastriesCost_Int()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(7, pastry.PastryCost(4));
    }  

    [TestMethod]
    public void PastryCost_ReturnFivePastriesCost_Int()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(9, pastry.PastryCost(5));
    }  

    [TestMethod]
    public void PastryCost_ReturnSixPastriesCost_Int()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(10, pastry.PastryCost(6));
    }  

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void GetCost_ReturnsCost_String()
    {
      string[] pastryTypes = {"croissant", "puff", "macaron"};
      Pastry pastry = new Pastry(pastryTypes, "2", "3 for $5! 4 for $7! 5 for $9! 6 for $10!");
      Assert.AreEqual("2", pastry.Cost);
    }
  }
}