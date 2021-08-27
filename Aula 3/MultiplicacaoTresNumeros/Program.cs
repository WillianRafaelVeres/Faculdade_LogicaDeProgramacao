// Willian Rafael Veres - 22/08/2021
using System;

namespace MultiplicacaoTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Multiplicação de três números inteiros!");

            Console.WriteLine("Digite o 1º número inteiro: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º número inteiro: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 3º número inteiro: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A multiplicação dos números é " + (numero1 * numero2 * numero3));
        }
    }
}
