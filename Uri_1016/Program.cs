using System;

namespace Uri_1016
{
    class Program
    {
        public static void CalculaDivisaoNotas(int valor, int valorInicial, int? numeroNotas100 = 0, int? numeroNotas50 = 0,
            int? numeroNotas20 = 0, int? numeroNotas10 = 0, int? numeroNotas5 = 0,
            int? numeroNotas2 = 0, int? numeroNotas1 = 0)
        {
            var notas100 = numeroNotas100;
            var notas50 = numeroNotas50;
            var notas20 = numeroNotas20;
            var notas10 = numeroNotas10;
            var notas5 = numeroNotas5;
            var notas2 = numeroNotas2;
            var notas1 = numeroNotas1;

            int novoValor;

            if (valor >= 1000000)
                return;

            if (valor >= 100)
            {
                notas100 = valor / 100;
                novoValor = valor % 100;
            }
            else if (valor >= 50)
            {
                notas50 = valor / 50;
                novoValor = valor % 50;
            }
            else if (valor >= 20)
            {
                notas20 = valor / 20;
                novoValor = valor % 20;
            }
            else if (valor >= 10)
            {
                notas10 = valor / 10;
                novoValor = valor % 10;
            }
            else if (valor >= 5)
            {
                notas5 = valor / 5;
                novoValor = valor % 5;
            }
            else if (valor >= 2)
            {
                notas2 = valor / 2;
                novoValor = valor % 2;
            }
            else if (valor == 1)
            {
                notas1 = valor / 1;
                novoValor = valor % 1;
            }
            else
            {
                Console.WriteLine(valorInicial);
                Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
                Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
                Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
                Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
                Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
                Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
                Console.WriteLine($"{notas1} nota(s) de R$ 1,00");

                return;
            }

            CalculaDivisaoNotas(valor: novoValor, valorInicial: valorInicial, numeroNotas100: notas100, numeroNotas50: notas50,
              numeroNotas20: notas20, numeroNotas10: notas10, numeroNotas5: notas5,
              numeroNotas2: notas2, numeroNotas1: notas1);
        }

        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            CalculaDivisaoNotas(valor: valor, valorInicial: valor);
        }
    }
}