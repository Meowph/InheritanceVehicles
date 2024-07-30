using System;
using System.Runtime.CompilerServices;

namespace Garage
{
  class Program
  {
    static void Main(string[] args)
    {
      Kia sportage = new Kia();
      MilMi model26 = new MilMi();
      Kawasaki zx6r = new Kawasaki();

      sportage.Operate();
      sportage.Turn();
      sportage.Stop();

      Console.WriteLine("----------------");

      model26.Operate();
      model26.Turn();
      model26.Stop();

      Console.WriteLine("----------------");

      zx6r.Operate();
      zx6r.Turn();
      zx6r.Stop();

    }
  }
}