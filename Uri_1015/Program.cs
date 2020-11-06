using System;
using System.Globalization;

namespace Uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] valores = new string[3, 3];

            double x1, y1, x2, y2, r;

            for (int i = 0; i < 2; i++)
            {
                string[] valoresEscopoFor = Console.ReadLine().Split(' ');

                for (int j = 0; j < 2; j++)
                {
                    valores[i, j] = valoresEscopoFor[j];
                }
            }

            x1 = double.Parse(valores[0, 0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[0, 1], CultureInfo.InvariantCulture);
            x2 = double.Parse(valores[1, 0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores[1, 1], CultureInfo.InvariantCulture);

            r = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);

            Console.WriteLine(Math.Sqrt(r).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
