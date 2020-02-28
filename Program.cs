
using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery 
{
  public class Program 
  {
    public static void Main()
    {
      BreadBag newBread = new BreadBag();
      PastryBag newPastry = new PastryBag();

      Console.WriteLine("Welcome to Pierre's Bakery! We have a 'Buy 2 and get 1 free' sale on bread, 'discount on 3' sale on pastries. Press y to see our shelves.");

      if (response1 == "y" || response1 == "Y")
      {
      Console.WriteLine("Shelf list here");
      }

      Console.WriteLine("Which kind of bread would you like? Enter the number next to the name.");
      breadCart.add()

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