// Willian Rafael Veres - 23/08/2021
using System;

namespace QuadradoInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double resultado = 0;
            double inverso = 0;
            double quadrado = 0;

            Console.Clear();

            Console.WriteLine("Quadrado do inverso");
            Console.WriteLine("Digite um número:");
            numero = Convert.ToDouble(Console.ReadLine());
            inverso = 1 / numero;
            quadrado = inverso * inverso;
            resultado = (quadrado * numero);
            Console.WriteLine($"O resultado é {resultado}");
        }
    }
}
