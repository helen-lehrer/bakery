using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryCost_ReturnSinglePastryCost_True()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(2, pastry.PastryCost(1));
    } 
  }
}