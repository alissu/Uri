using System;
using System.Globalization;

namespace Uri_1021
{
  class Program
  {
    static void Main(string[] args)
    {
      decimal value = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      decimal qteNotas100 = 0.0M, qteNotas50 = 0.0M, qteNotas20 = 0.0M, qteNotas10 = 0.0M, qteNotas5 = 0.0M, qteNotas2 = 0.0M;
      decimal qteMoedas1 = 0.0M, qteMoedas0_50 = 0.0M, qteMoedas0_25 = 0.0M, qteMoedas0_10 = 0.0M, qteMoedas0_05 = 0.0M, qteMoedas0_01 = 0.0M;

      while (true)
      {
        if (value >= 100.00M)
        {
          qteNotas100 = Math.Truncate(value / 100.00M);
          value %= 100;
        }
        else if (value >= 50.00M)
        {
          qteNotas50 = Math.Truncate(value / 50.00M);
          value %= 50;
        }
        else if (value >= 20.00M)
        {
          qteNotas20 = Math.Truncate(value / 20.00M);
          value %= 20;
        }
        else if (value >= 10.00M)
        {
          qteNotas10 = Math.Truncate(value / 10.00M);
          value %= 10;
        }
        else if (value >= 5.00M)
        {
          qteNotas5 = Math.Truncate(value / 5.00M);
          value %= 5;
        }
        else if (value >= 2.00M)
        {
          qteNotas2 = Math.Truncate(value / 2.00M);
          value %= 2;
        }
        else
        {
          if (value >= 1.00M)
          {
            qteMoedas1 = Math.Truncate(value / 1.00M);
            value %= 1;
          }
          else if (value >= 0.50M)
          {
            qteMoedas0_50 = Math.Truncate(value / 0.50M);
            value %= 0.50M;
          }
          else if (value >= 0.25M)
          {
            qteMoedas0_25 = Math.Truncate(value / 0.25M);
            value %= 0.25M;
          }
          else if (value >= 0.10M)
          {
            qteMoedas0_10 = Math.Truncate(value / 0.10M);
            value %= 0.10M;
          }
          else if (value >= 0.05M)
          {
            qteMoedas0_05 = Math.Truncate(value / 0.05M);
            value %= 0.05M;
          }
          else
          {
            qteMoedas0_01 = Math.Truncate(value / 0.01M);
            value %= 0.01M;
            break;
          }
        }
      }

      Console.WriteLine("NOTAS:");
      Console.WriteLine($"{qteNotas100.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 100.00");
      Console.WriteLine($"{qteNotas50.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 50.00");
      Console.WriteLine($"{qteNotas20.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 20.00");
      Console.WriteLine($"{qteNotas10.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 10.00");
      Console.WriteLine($"{qteNotas5.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 5.00");
      Console.WriteLine($"{qteNotas2.ToString("F0", CultureInfo.InvariantCulture)} nota(s) de R$ 2.00");
      Console.WriteLine("MOEDAS:");
      Console.WriteLine($"{qteMoedas1.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 1.00");
      Console.WriteLine($"{qteMoedas0_50.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 0.50");
      Console.WriteLine($"{qteMoedas0_25.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 0.25");
      Console.WriteLine($"{qteMoedas0_10.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 0.10");
      Console.WriteLine($"{qteMoedas0_05.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 0.05");
      Console.WriteLine($"{qteMoedas0_01.ToString("F0", CultureInfo.InvariantCulture)} moeda(s) de R$ 0.01");
    }
  }
}
