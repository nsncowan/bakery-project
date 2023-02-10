using System;
using System.Linq;

namespace Bakery.Models
{
  public class BreadOrder
  {
    public int Loaves{get; set;}
    public int Cost{get; set;}
    public int CostPerLoaf = 5;

    public BreadOrder (int loaves, int cost)
    {
      Loaves = loaves;
      Cost = cost;
    }

    public int BreadOrderCost(int numberOfLoaves)
    {
      numberOfLoaves = Loaves;
      int breadTotal = (numberOfLoaves * CostPerLoaf) - ((numberOfLoaves / 3) * CostPerLoaf);
      return breadTotal;
    }


    // create object with fields for cost of bread order and number of loaves ordered
    // declare cost per loaf at $5
    // gather number of loaves ordered
    // set cost of every 3rd loaf to $0
      // alt: divide total loaves by 3, then subtract (quotientInt * 5) from total. 
      // remember: arithmetic with int's will always be truncated
  }



  public class PastryOrder
  {
    // create object with fields for cost of pastry order and number of pastries ordered
    // declare cost per pastry at $2
    // gather number of pastries ordered
    // set cost of every 4th pastry to $0
      // alt: divide total pastries by 4, then subtract (quotientInt * 2) from total. 
      // remember: arithmetic with int's will always be truncated
  }
}