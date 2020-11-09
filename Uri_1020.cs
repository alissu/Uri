using System;

namespace Uri_1020
{
  class Program
  {
    public const int daysInYear = 365;
    public const int daysInMonth = 30;

    static void Main(string[] args)
    {
      int ageDays = int.Parse(Console.ReadLine());

      int years = 0, months = 0, days = 0;

      while (true)
      {
        if (ageDays >= daysInYear)
        {
          years = ageDays / daysInYear;
          ageDays = ageDays % daysInYear;
        }
        else if (ageDays >= daysInMonth)
        {
          months = ageDays / daysInMonth;
          ageDays = ageDays % daysInMonth;
        }
        else
        {
          days = ageDays;
          break;
        }
      }

      Console.WriteLine($"{years} ano(s)");
      Console.WriteLine($"{months} mes(es)");
      Console.WriteLine($"{days} dia(s)");
    }
  }
}
