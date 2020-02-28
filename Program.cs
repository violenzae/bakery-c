
using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery 
{
  public class Program 
  {
    public static void Main()
    {
      Bread newBread = new Bread("", "", 0, 0);
      // Pastry newPastry = new Pastry();

      Bread french = new Bread("French Bread", "1", 0, 8);
      Bread white = new Bread("White Bread", "2", 0, 5);
      Bread rye = new Bread("Rye Bread", "3", 0, 6);
      Bread pumpernickel = new Bread("Pumpernickel", "4", 0, 4);

        
      List<Bread> breadShelf = new List<Bread>(4) { french, white, rye, pumpernickel };

      Console.WriteLine("Welcome to Pierre's Bakery! We have a 'Buy 2 and get 1 free' sale on bread, 'discount on 3' sale on pastries. Press y to see our shelves.");

      string response1 = Console.ReadLine();

      if (response1 == "y" || response1 == "Y")
      {
        foreach(Bread item in breadShelf)
        {
          Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
          Console.WriteLine(item.BNumber + "  " + item.BName + " --- $" + item.BPrice + " per loaf");
        }

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("Which kind of bread would you like? Enter the number next to the name.");

        string breadPick = Console.ReadLine();
        
        foreach(Bread item in breadShelf)
          if(breadPick == item.BNumber)
        {
            newBread.BName = item.BName;
            newBread.BNumber = item.BNumber;
            newBread.BPrice = item.BPrice;
        }

         Console.WriteLine("How many loaves of bread would you like?");
         string stringBread = Console.ReadLine();
         newBread.BAmount = int.Parse(stringBread);
      }
 
        //
     
      

      Console.WriteLine("Total Bread Price: $" + newBread.BreadDiscounter());

      // Console.WriteLine("How many pastries would you like?");
      // string stringPastry = Console.ReadLine();
      // newPastry.PAmount = int.Parse(stringPastry);

      // Console.WriteLine("Total Pastry Price: $" + newPastry.PastryDiscounter());

      // Console.WriteLine("Your total order price comes to $" + (newBread.BreadDiscounter()+newPastry.PastryDiscounter())+".");

      }
    }
  }
