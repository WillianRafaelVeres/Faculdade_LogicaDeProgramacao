//Victor e Willian - 20/10/2021
using System;

namespace Exercicio9
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

            // Enquanto numero for maior que zero
            while(numero > 0){
                // Mostra o numero
                Console.WriteLine(numero);
                // Subtrai 1 do numero
                numero--;
            }
        }
        // Função para ler numero
        static int LerNumero(){

            // Variavel numero
            int numero;

            // Mensagem pedindo um numero
            Console.WriteLine("Digite um número inteiro maior que 0: ");

            // Armazena o que for digitado convertido para int
            numero = int.Parse(Console.ReadLine());

            // Enquanto numero for menor ou igual a 0
            while(numero <= 0){
                // Mostra mensagem
                Console.Write("Valor inválido, só são aceitos numeros inteiros maiores que 0!\nTente Novamente: ");
                // Armazena o que for digitado convertido para int
                numero = int.Parse(Console.ReadLine());
            }

            // Retorna o número
            return numero;
        }
    }
}
