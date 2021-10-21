//Victor e Willian - 20/10/2021
using System;

namespace Exercicio5
{
    class Program
    {

        // Arrey de 3 numeros - Acessivel por todas as funções
        static int[] numeros = new int[3];

        static void Main(string[] args){ // Programa principal

            // Função para limpar o terminal
            Console.Clear();

            // Mostra mensagem sobre o programa
            Console.WriteLine("Lista ordenado");

            // Chama a função para ler um número inteiro
            LerInt();
            // Coloca os elementos do arrey em ordem crescente
            Array.Sort(numeros);
            // Procedimento para mostrar os numeros(arrey como parâmetro)
            MostrarNumeros(numeros);
        }

        // Função para ler numero inteiro
        static void LerInt(){
            
            // For de 3 loops
            for (int i = 0; i < 3; i++)
            {
                // Mostra mensagem pedindo um número inteiro
                Console.Write("Digite um número inteiro: ");
                // Armazena o que for digitado convertido para inteiro no arrey de acordo com a posição do i(index)
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        // Função para mostrar numeros
        static void MostrarNumeros(int[] numerosLista){

            // Mostra mensagem
            Console.WriteLine($"\nLista ordenada:");
            // For de 3 loops
            for (int i = 0; i < 3; i++)
            {
                // Mostra na tela o numero de arrey de acordo com a posição do i(index)
                Console.WriteLine($"{numerosLista[i]}");
            }
            // Apenas para deixar um espaço no final
            Console.WriteLine();
        }
    }
}
