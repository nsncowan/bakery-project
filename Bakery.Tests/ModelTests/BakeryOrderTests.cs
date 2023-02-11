using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void CreateBreadOrderObject_CreateBreadOrderObject()
    {
      int loaves = 1;
      /* int cost = 5; */
      BreadOrder test = new BreadOrder(loaves/* , cost */);
      Assert.AreEqual(typeof(BreadOrder), test.GetType());
      Assert.AreEqual(1, test.Loaves);
    }

    [TestMethod]
    public void BreadOrderCost_ReturnBreadOrderCost_Int()
    {
      int testloaves = 7;
      /* int testcost = 25; */
      BreadOrder test2 = new BreadOrder(testloaves/* , testcost */);
      Assert.AreEqual(test2.GetBreadPrice(testloaves), 25);
    }
  }

  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void CreatePastryOrderObject_CreatePastryOrderObject()
    {
      int pastries = 1;
      /* int cost = 2; */
      PastryOrder test = new PastryOrder(pastries/* , cost */);
      Assert.AreEqual(typeof(PastryOrder), test.GetType());
      Assert.AreEqual(1, test.Pastries);
    }

    [TestMethod]
    public void BreadOrderCost_ReturnBreadOrderCost_Int()
    {
      int testloaves = 7;
      /* int testcost = 25; */
      BreadOrder test2 = new BreadOrder(testloaves/* , testcost */);
      Assert.AreEqual(test2.GetBreadPrice(testloaves), 25);
    }
  }
}
