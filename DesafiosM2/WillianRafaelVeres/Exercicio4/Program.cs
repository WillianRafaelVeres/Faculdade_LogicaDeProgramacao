//Victor e Willian - 20/10/2021
using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args) // Programa principal
        {
            // Variavel para numero
            int numero;
            // Variavel do retorno
            string retorno;

            // Função para limpar o terminal
            Console.Clear();
            // Armazena o valor da operção retornado pela função
            numero = LerInt();
            // Armazena o valor da operação retornado pela função(numero como parâmetro)
            retorno = Comparar(numero);

            // Mostra a resposta
            Console.WriteLine($"\nA resposta é {retorno}\n");
        }

        // Função para ler numero inteiro
        static int LerInt(){

            // Mensagem pendo para digitar um numero inteiro
            Console.Write("Digite um número inteiro: ");
            // Retorna o que for digitado convertido para inteiro
            return Int32.Parse(Console.ReadLine());
        }

        // Função para comparar(numero como parâmetrp)
        static string Comparar(int numero){

            // Se numero for menor ou igual a 10
            if(numero <= 10){
                // Retorna F1
                return "F1";
            }
            // Se numero for maior que 10 e menor que 100
            else if(numero > 10 && numero <= 100)
            {
                // Retorna F2
                return "F2";
            }
            // Senão
            else
            {
                // Retorna F3
                return "F3";
            }
        }
    }
}
