using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_ReturnSingleLoafCost_Int()
    {
      string[] breadTypes = {"white", "whole wheat", "pumpernickel"};
      Bread bread = new Bread(breadTypes, "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(5, bread.BreadCost(1));
    }

    [TestMethod]
    public void BreadCost_ReturnBogoCost_Int()
    {
      string[] breadTypes = {"white", "whole wheat", "pumpernickel"};
      Bread bread = new Bread(breadTypes, "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(10, bread.BreadCost(3));
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      string[] breadTypes = {"white", "whole wheat", "pumpernickel"};
      Bread bread = new Bread(breadTypes, "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetCost_ReturnsCost_String()
    {
      string[] breadTypes = {"white", "whole wheat", "pumpernickel"};
      Bread bread = new Bread(breadTypes, "5", "Buy 1, get 1 Free!");
      Assert.AreEqual("5", bread.Cost);
    }

  }
}