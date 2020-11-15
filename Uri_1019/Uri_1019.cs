using System;

namespace Uri_1019
{
  class Program
  {
    public const int hourInSeconds = 3600;
    public const int minuteInSeconds = 60;

    static void Main(string[] args)
    {
      int seconds = int.Parse(Console.ReadLine());

      int exec = seconds;
      int minutes = 0;
      int hours = 0;

      while (true)
      {
        if (exec >= hourInSeconds)
        {
          hours = exec / hourInSeconds;
          exec %= hourInSeconds;
        }
        else if (exec >= minuteInSeconds)
        {
          minutes = exec / minuteInSeconds;
          exec %= minuteInSeconds;
        }
        else
        {
          seconds = exec;
          break;
        }
      }

      Console.WriteLine($"{hours}:{minutes}:{seconds}");
    }
  }
}
