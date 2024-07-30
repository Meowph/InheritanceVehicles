using System;

namespace Garage
{
  public class Vehicle // base class or parent class
  //When two classes are involved in an inheritance relationship, we call the more general type (e.g. Vehicle) the base class or parent class and we call the more specific (e.g. Kia) the subclass or child class.

  {
    public string? MainColor { get; set; } //The "?" gets rid of the yellow warning squiggle under MainColor... That is literally it
    public int MaximumOccupancy { get; set; }

    public virtual void Operate()
    {
      Console.WriteLine("Beep Beep!");
    }

    public virtual void Turn()
    {
      Console.WriteLine("The vehicle sharply turns right");
    }

    public virtual void Stop()
    {
      Console.WriteLine("The vehicle stops abruptly!");
    }
  }
}