using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero01 = 0;
            int numero02 = 0;

            Console.Clear();
            Console.Write("Digite o primeiro número para a soma:");
            numero01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número para a soma:");
            numero02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A soma é " + somaDoisNumeros(numero01, numero02));

        }

        static int somaDoisNumeros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
