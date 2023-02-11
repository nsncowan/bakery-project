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

