using System;
using System.Globalization;

namespace Uri_1040
{
    class Program
    {
        public const int peso1 = 2, peso2 = 3, peso3 = 4, peso4 = 1;
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            decimal n1, n2, n3, n4;

            decimal result1, result2;
            string result;

            n1 = decimal.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = decimal.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = decimal.Parse(valores[2], CultureInfo.InvariantCulture);
            n4 = decimal.Parse(valores[3], CultureInfo.InvariantCulture);

            result1 = (n1 * peso1 + n2 * peso2 + n3 * peso3 + n4 * peso4) / (peso1 + peso2 + peso3 + peso4);

            result = result1.ToString("F2", CultureInfo.InvariantCulture).Substring(0, 3);

            Console.WriteLine($"Media: {result}");

            if (result1 >= 7.0M)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (result1 >= 5.0M && result1 < 7.0M)
            {
                result2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {result2.ToString("F1", CultureInfo.InvariantCulture)}");
                decimal mediaFinal = (result1 + result2) / 2.0M;

                if (mediaFinal >= 5.0M)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                /*
                    Substring pois resposta deve ser com uma casa decimal e em alguns casos a precisão falha ao aplicar o:
                    ToString("F1", CultureInfo.InvariantCulture)
                    Por exemplo em 4.9
                */
                result = mediaFinal.ToString("F2", CultureInfo.InvariantCulture).Substring(0, 3);

                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
