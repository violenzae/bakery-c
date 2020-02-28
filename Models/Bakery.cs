using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread
  {
    public string BName{ get; set; }
    public int BNumber{ get; set; }
    public int BAmount{ get; set; }
    public int BPrice{ get; set; }


    public Bread(string bName, int bNumber, int bAmount, int bPrice)
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

  public class Pastry 
  {
    public string PName{ get; set; }
    public int PNumber{ get; set; }
    public int PAmount{ get; set; }
    public int PPrice1{ get; set; }
    public int PPrice2 {get; set; }

    public Pastry(string pName, int pNumber, int pAmount, int pPrice1, int pPrice2)
    {
      PName = pName;
      PNumber = pNumber;
      PAmount = pAmount;
      PPrice1 = pPrice1;
      PPrice2 = pPrice2;

    }

    public int PastryDiscounter()
    {
      return (PAmount/3)*PPrice2 + (PAmount%3)*PPrice1;
    }
  }
}