// Willian Rafael Veres - 22/08/2021
using System;

namespace DivisaoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 0;
            int divisor = 0;

            Console.Clear();

            Console.WriteLine("Divisão de Dois Números inteiros");

            Console.WriteLine("Digite um dividendo sendo ele um número inteiro: ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um divisor sendo ele um número inteiro: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A divisão dos números é " + (dividendo / divisor));
        }
    }
}
