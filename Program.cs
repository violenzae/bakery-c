
using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery 
{
  public class Program 
  {
    public static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      Console.WriteLine("Welcome to Pierre's Bakery! Each loaf of bread is $5 and each pastry is $2. We have a 'Buy 2 and get 1 free' sale on bread, and a 3 for $5 sale on pastries.");

      Console.WriteLine("How many loaves of bread would you like?");
      string stringBread = Console.ReadLine();
      newBread.BAmount = int.Parse(stringBread);

      Console.WriteLine("Total Bread Price: $" + newBread.BreadDiscounter());

      Console.WriteLine("How many pastries would you like?");
      string stringPastry = Console.ReadLine();
      newPastry.PAmount = int.Parse(stringPastry);

      Console.WriteLine("Total Pastry Price: $" + newPastry.PastryDiscounter());

      Console.WriteLine("Your total order price comes to $" + (newBread.BreadDiscounter()+newPastry.PastryDiscounter())+".");

    }
  }
}