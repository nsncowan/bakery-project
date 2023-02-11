using System;
using System.Linq;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int Loaves{get; set;}
    public int BreadCost{get; set;}
    public int CostPerLoaf = 5;
    public BreadOrder (int loaves/* , int cost */)
    {
      Loaves = loaves;
      // Cost = cost; => discuss where to include cost
    }
    public int GetBreadPrice(int numberOfLoaves)
    {
      numberOfLoaves = Loaves;
      BreadCost = (numberOfLoaves * CostPerLoaf) - ((numberOfLoaves / 3) * CostPerLoaf);
      return BreadCost;
    }
  }
}


/* 
question: originally i had the "Cost" variable as a field in the BreadOrder constructor. Then I moved it outside the constructor, but still within the BreadOrder class. Both led to passing tests, I want to discuss ways to think about variable placement in this context. 

 */


// create object with fields for cost of pastry order and number of pastries ordered
// declare cost per pastry at $2
// gather number of pastries ordered
// set cost of every 4th pastry to $0
  // alt: divide total pastries by 4, then subtract (quotientInt * 2) from total. 
  // remember: arithmetic with int's will always be truncated
