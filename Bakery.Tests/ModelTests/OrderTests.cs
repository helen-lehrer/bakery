using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_ReturnSingleLoafCost_True()
    {
        Bread bread = new Bread();
        Assert.AreEqual(5, bread.BreadCost(1));
    }
  }
}