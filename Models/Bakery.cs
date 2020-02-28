using System;
using System.Collections.Generic;

namespace Bakery.Models 
{
  public class Bread 
  {
    public int BAmount{ get; set; }


    public Bread()
    {
      BAmount = 0;
    }

    public int BreadDiscounter()
    {
     return (BAmount-(BAmount/3))*5;
    }

  }

  public class Pastry 
  {
    public int PAmount{ get; set; }

    public Pastry()
    {
      PAmount = 0;
    }

    public int PastryDiscounter()
    {
      return (PAmount/3)*5 + (PAmount%3)*2;
    }
  }
}