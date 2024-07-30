using System;

namespace Garage
{
  public class MilMi : Vehicle //Helicopter
  // Then each of the other, more specific, types would inherit from it. We use a colon between the class name and the base class name when inheriting.
  //subclass or child class
  {
    public double StorageCapacity { get; set; }
    // public string MainColor {get; set;}
    // public int MaximumOccupancy {get; set;}

    public void CheckList()
    {
      // method definition omitted
    }
    public override void Operate()
    {
      Console.WriteLine("The glaring hot pink Mil Mi flies overhead going Thrrrrrrrrrrrrrrrrrrrrrrrr!");
    }
  }
}