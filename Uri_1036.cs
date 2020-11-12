using System;
using System.Globalization;

namespace Uri_1036
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] valores = Console.ReadLine().Split(' ');
      double a, b, c, r1, r2;

      a = double.Parse(valores[0], CultureInfo.InvariantCulture);
      b = double.Parse(valores[1], CultureInfo.InvariantCulture);
      c = double.Parse(valores[2], CultureInfo.InvariantCulture);

      double sqrt = b * b - 4 * a * c;

      if (a == 0.0 || sqrt < 0)
      {
        Console.WriteLine("Impossivel calcular");
        return;
      }

      r1 = (-b + Math.Sqrt(sqrt)) / (2 * a);
      r2 = (-b - Math.Sqrt(sqrt)) / (2 * a);

      Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
    }
  }
}
