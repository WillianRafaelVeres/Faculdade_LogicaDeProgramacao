//Victor e Willian - 20/10/2021
using System;

namespace Exercicio5
{
    class Program
    {

        static int[] numeros = new int[3];

        static void Main(string[] args){

            // Função para limpar o terminal
            Console.Clear();

            LerInt();
            Array.Sort(numeros);
            MostrarNumeros(numeros);
        }

        static void LerInt(){
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite um número inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

        }

        static void MostrarNumeros(int[] numerosLista){

            Console.WriteLine($"\nLista ordenada:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{numerosLista[i]}");
            }
            Console.WriteLine();
        }
    }
}
