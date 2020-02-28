using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread
  {
    public string BName{ get; set; }
    public string BNumber{ get; set; }
    public int BAmount{ get; set; }
    public int BPrice{ get; set; }


    public Bread(string bName, string bNumber, int bAmount, int bPrice)
    {
      BName = bName;
      BNumber = bNumber;
      BAmount = bAmount;
      BPrice = bPrice;
    }

    public int BreadDiscounter()
    {
     return (BAmount-(BAmount/3))*BPrice;
    }

  

  }

  // public class Pastry 
  // {
  //   public int PAmount{ get; set; }
  //   public int PPrice1{ get; set; }
  //   public int PPrice2 {get; set; }

  //   public Pastry(string pName)
  //   {
  //     PName = pName;
  //     PAmount = 0;
  //     PPrice1 = 0;
  //     PPrice2 = 0;

  //   }

  //   public int PastryDiscounter()
  //   {
  //     // 3 for 5 (pp2) and 1 for 2 (pp1)
  //     return (PAmount/3)*PPrice2 + (PAmount%3)*PPrice1;
  //   }
  // }
}