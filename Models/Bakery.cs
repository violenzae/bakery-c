using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread 
  {
    public int BPrice{ get; set; }
    public int BAmount{ get; set; }
    public int BTotal{ get; set; }

    public Bread(int bPrice, int bAmount, int bTotal)
    {
      BPrice = bPrice;
      BAmount = bAmount;
      BTotal = bTotal;
    }
  }

  public class Pastry 
  {
    public int PPrice{ get; set; }
    public int PAmount{ get; set; }
    public int PTotal{ get; set; }

    public Pastry(int pPrice, int pAmount, int pTotal)
    {
      PPrice = pPrice;
      PAmount = pAmount;
      PTotal = pTotal;
    }
  }
}