using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread 
  {
    public double BPrice{ get; set; }
    public int BAmount{ get; set; }
    public double BTotal{ get; set; }

    public Bread(double bPrice, int bAmount, double bTotal)
    {
      BPrice = bPrice;
      BAmount = bAmount;
      BTotal = bTotal;
    }

    public int BreadDiscount()
    {
      
    }

  }

  public class Pastry 
  {
    public double PPrice{ get; set; }
    public int PAmount{ get; set; }
    public double PTotal{ get; set; }

    public Pastry(double pPrice, int pAmount, double pTotal)
    {
      PPrice = pPrice;
      PAmount = pAmount;
      PTotal = pTotal;
    }
  }
}