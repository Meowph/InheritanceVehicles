using System;

namespace Garage
{
  public class Kia : Vehicle //Car
  // Then each of the other, more specific, types would inherit from it. We use a colon between the class name and the base class name when inheriting.
  //subclass or child class
  {
    public bool GoodOnGas { get; set; }
    // public string MainColor {get; set;}
    // public int MaximumOccupany {get; set;}

    public void RefuelTank()
    {
      // method definition omitted
    }
    public override void Operate()
    {
      Console.WriteLine("The deep red Kia flies around the bend going Vrrrrrrrooooom!");
    }
  }
}