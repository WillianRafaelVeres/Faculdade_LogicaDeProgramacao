// Victor e Willian - 04_09_2021
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            double numero1; // Variável do numuro1
            double numero2; // Variável do numuro2
            double numero3; // Variável do numuro2

            Console.WriteLine("Programa para média de três números!"); // Mensagem sobre o programa

            numero1 = LerDouble(); // Chama a função para ler double e armazena em numero1
            numero2 = LerDouble(); // Chama a função para ler double e armazena em numero2
            numero3 = LerDouble(); // Chama a função para ler double e armazena em numero3

            MediaTresNumeros(numero1, numero2, numero3); // Chama a função para fazer a média e passa os parâmetros
        }

        static double LerDouble() // Função para ler double
        {   
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Por favor, digite um numero: "); // Mostra a mensagem solicitando um dado
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para double
        }

        static void MediaTresNumeros(double numero1, double numero2, double numero3) // Função para média de três números
        {
            Console.WriteLine($"O resultado é {(numero1 + numero2 + numero3) / 3}!"); // Mostra na tela o resultado da soma dos três númemos divididos por 3
        }
    }
}
