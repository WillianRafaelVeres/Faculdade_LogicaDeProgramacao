// WIllian Rafael Veres - 22/08/2021
using System;

namespace SubtracaoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.Clear();

            Console.WriteLine("Subtração de dois números inteiros!");

            Console.WriteLine("Digite o 1º número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O resudade  de {numero1} subtraido por {numero2} é {numero1 - numero2}");
        }
    }
}
