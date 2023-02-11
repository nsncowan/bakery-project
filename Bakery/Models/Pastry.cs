using System;
using System.Linq;

namespace Bakery.Models
{
  public class PastryOrder
  {
    public int Pastries{get; set;}
    public int PastryCost{get; set;}
    public int CostPerPastry = 2;

    public PastryOrder (int pastries/* , int cost */)
    {
      Pastries = pastries;
      // Cost = cost; => discuss where to include cost
    }
    public int GetPastryPrice(int numberOfPastries)
    {
      numberOfPastries = Pastries;
      PastryCost = (numberOfPastries * CostPerPastry) - ((numberOfPastries / 4) * CostPerPastry);
      return PastryCost;
    }
  }
}