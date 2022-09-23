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
      Pastry pastry = new Pastry();
      Assert.AreEqual(2, pastry.PastryCost(1));
    } 

    [TestMethod]
    public void PastryCost_ReturnThreePastriesCost_Int()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(5, pastry.PastryCost(3));
    }

    [TestMethod]
    public void PastryCost_ReturnFourPastriesCost_Int()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(7, pastry.PastryCost(4));
    }  

    [TestMethod]
    public void PastryCost_ReturnFivePastriesCost_Int()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(9, pastry.PastryCost(5));
    }  

    [TestMethod]
    public void PastryCost_ReturnSixPastriesCost_Int()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(10, pastry.PastryCost(6));
    }  

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    // [TestMethod]
    // public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    // {
    //   Pastry pastry = new Pastry();
    //   Assert.AreEqual(typeof(Pastry), pastry.GetType());
    // }
  }
}