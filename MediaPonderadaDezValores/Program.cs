// Willian Rafael Veres - 23/08/2021
using System;

namespace MediaPonderadaDezValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int contador = 1;

            Console.Clear();
            Console.WriteLine("Média ponderada de Dez números");

            while(contador <= 10)
            {
                Console.Write($"Digite o {contador}º número:");
                soma = soma + (Convert.ToInt32(Console.ReadLine())* contador);
                contador ++;
            }

            Console.WriteLine($"A a média dos 10 números digitados é igual a {soma/55}!");
        }
    }
}
