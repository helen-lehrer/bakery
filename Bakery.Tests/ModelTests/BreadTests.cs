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
      Bread bread = new Bread("white,", "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(5, bread.BreadCost(1));
    }

    [TestMethod]
    public void BreadCost_ReturnBogoCost_Int()
    {
      Bread bread = new Bread("white,", "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(10, bread.BreadCost(3));
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread("white", "5", "Buy 1, get 1 Free!");
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsType_String()
    {
      Bread bread = new Bread("white", "5", "Buy 1, get 1 Free!");
      Assert.AreEqual("white", bread.Type);
    }

  }
}