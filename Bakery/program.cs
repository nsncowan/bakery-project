using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! \nBread is $5/loaf. Buy 2 get 1 free! \nPastries are $2/each. Buy 3 get 1 free!");
      Console.WriteLine("How many loaves of bread would you like?");
      int inputLoaves = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int inputPastries = int.Parse(Console.ReadLine());

      BreadOrder myBreadOrder = new BreadOrder(inputLoaves);
      PastryOrder myPastryOrder = new PastryOrder(inputPastries);

      int myBreadCost = myBreadOrder.GetBreadPrice(inputLoaves);
      int myPastryCost = myPastryOrder.GetPastryPrice(inputPastries);
      int totalCost = myBreadCost + myPastryCost;

      Console.WriteLine($"Your Bread order is ${myBreadCost}. \nAnd your Pastry order is ${myPastryCost}. \nYour grand total is ${totalCost}.");

    }
  }
}