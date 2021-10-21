//Victor e Willian - 20/10/2021
using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args) // Programa principal
        {
            // Variavel numero
            int numero;

            // Função para limpar o terminal
            Console.Clear();
            // Armazena o valor do numero retornado pela função
            numero = LerNumero();

            // Apenas para pular uma linha
            Console.WriteLine();

            // For de 10 loops
            for (int i = 0; i < 11; i++)
            {
                // Mostra a linha da tabuada (indice - numero - numero x indice)
                Console.WriteLine($"---    {i} X {numero} = {numero*i}");
            }

            // Apenas para pular uma linha
            Console.WriteLine();
        }

        // Função para ler numero
        static int LerNumero(){

            // Variavel numero
            int numero;

            // Mensagem pedindo um numero
            Console.WriteLine("Digite um número inteiro entre 1 e 10: ");

            // Armazena o que for digitado convertido para int
            numero = int.Parse(Console.ReadLine());

            // Enquanto numero for menor que 1 ou maior que 10
            while(numero <= 0 || numero >= 11){
                // Mostra mensagem
                Console.Write("Valor inválido, só são aceitos numeros inteiros entre 1 e 10:\nTente Novamente: ");
                // Armazena o que for digitado convertido para int
                numero = int.Parse(Console.ReadLine());
            }

            // Retorna o numero
            return numero;
        }
    }
}
