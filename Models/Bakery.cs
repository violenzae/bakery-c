using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class BreadBag 
  {
    public int BAmount{ get; set; }
    public int BPrice{ get; set; }


    public Bread()
    {
      BName = ""
      BAmount = 0;
      BPrice = 0;
    }

    public int BreadDiscounter()
    {
     return (BAmount-(BAmount/3))*BPrice;
    }

  

  }

  public class PastryBag 
  {
    public int PAmount{ get; set; }
    public int PPrice1{ get; set; }
    public int PPrice2 {get; set; }

    public Pastry()
    {
      PName = "";
      PAmount = 0;
      PPrice1 = 0;
      PPrice2 = 0;

    }

    public int PastryDiscounter()
    {
      // 3 for 5 (pp2) and 1 for 2 (pp1)
      return (PAmount/3)*PPrice2 + (PAmount%3)*PPrice1;
    }
  }
}