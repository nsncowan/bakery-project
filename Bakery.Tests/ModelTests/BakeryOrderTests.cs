using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void CreateBakeryOrderObject_CreateBakeryOrderObject()
    {
      int loaves = 1;
      int cost = 5;
      BreadOrder test = new BreadOrder(loaves, cost);
      Assert.AreEqual(typeof(BreadOrder), test.GetType());
      Assert.AreEqual(1, test.Loaves);
    }
    
  }



  [TestClass]
  public class PastryOrderTests
  {
    
  }

}


// Example test format:

/*

[TestMethod]
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

 */