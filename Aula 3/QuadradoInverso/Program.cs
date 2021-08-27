// Willian Rafael Veres - 23/08/2021
using System;

namespace QuadradoInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int resultado = 0;
            int inverso = 0;
            int quadrado = 0;

            Console.Clear();

            Console.WriteLine("Quadrado do inverso");
            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());
            inverso = 1 / numero;
            quadrado = inverso * inverso;
            resultado = (quadrado * numero);
            Console.WriteLine($"O resultado é {resultado}");
        }
    }
}
