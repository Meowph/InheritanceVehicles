using System;

namespace Garage
{
  public class Kawasaki : Vehicle //Motorcycle
  // Then each of the other, more specific, types would inherit from it. We use a colon between the class name and the base class name when inheriting.
  //subclass or child class
  {
    public double Distance { get; set; }
    // public string MainColor {get; set;}
    // public int MaximumOccupany {get; set;}

    public void TravelTime()
    {
      // method definition omitted
    }
    public override void Operate()
    {
      Console.WriteLine("The dazzling green Kawasaki speeds past going Nyyyyyooooooooommmmm!");
    }

    // public override void Turn()
    // {
    //     Console.WriteLine("The dazzling green Kawasaki speeds past going Nyyyyyooooooooommmmm!");
    // }

    //         public override void Stop()
    // {
    //     Console.WriteLine("The dazzling green Kawasaki speeds past going Nyyyyyooooooooommmmm!");
    // }
  }
}