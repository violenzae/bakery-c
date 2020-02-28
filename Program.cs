
using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery 
{
  public class Program 
  {
    public static void Main()
    {
      Bread newBread = new Bread(5.00, 0, 0.00);
      Pastry newPastry = new Pastry(2.00, 0, 0.00);
      Console.WriteLine("Welcome to Pierre's Bakery! Each loaf of bread is $" + newBread.BPrice + " and each pastry is $" + newPastry.PPrice + ". We have a 'Buy 2 and get 1 free' sale on bread, and a 3 for $5 sale on pastries.");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBread = Console.ReadLine();
      newBread.bAmount = double.Parse(stringBread);

      Console.WriteLine("How many pastries would you like?");
      string stringPastry = Console.ReadLine();
      newPastry.pAmount = double.Parse(stringPastry);
    }
  }
}