//Victor e Willian - 20/10/2021
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args) // Programa principal
        {
            // Váriavel da média do saldo
            double mediaSaldo;

            // Função para limpar o terminal
            Console.Clear();

            // Mostra na tela a mensagem sobre o programa
            Console.WriteLine("Calculo de crédito");

            // Armazena o que for retornado da função LerMediaSaldo
            mediaSaldo = LerMediaSaldo();
            // Chama o procedimento e passa o parâmetro
            CalculaCredito(mediaSaldo);

        }

        // Função para ler a média
        static double LerMediaSaldo(){ 
            // Mostra na tela a mensagem pedindo a média
            Console.Write("Digite o valor da média anual do saldo:");
            // Retorna o que for digitado convertido para double
            return double.Parse(Console.ReadLine());
        }

        // Função para Calcular o cérdito(pede o saldo como parâmetro)
        static void CalculaCredito(double saldo){ 

            // Váriavel do valor do crédito 
            double valorCredito = 0;
            // Váriavel do valor total
            double valorTotal = 0;

            // Se o saldo for menor que 200
            if (saldo <= 200)
            {
                // Mostra mensagem sobre o credito
                Console.WriteLine("\nSeu saldo não se encaixa em nenhum crédito especial!");
                // Valor do crédito recebe 0
                valorCredito = 0;
            }

            // Se o saldo for menor que 400
            else if (saldo <= 400)
            {
                // Mostra mensagem sobre o credito
                Console.WriteLine("\nSeu saldo se encaixa em 20% de crédito especial!");
                // Valor do crédito recebe 20% do valor do saldo
                valorCredito = saldo * 20 / 100;
            }

            // Se o saldo for menor que 600
            else if (saldo <= 600)
            {
                // Mostra mensagem sobre o credito
                Console.WriteLine("\nSeu saldo se encaixa em 30% de crédito especial!");
                // Valor do crédito recebe 30% do valor do saldo
                valorCredito = saldo * 30 / 100;
            }

            // Se o saldo for maior que 600
            else if (saldo > 600)
            {
                // Mostra mensagem sobre o credito
                Console.WriteLine("\nSeu saldo se encaixa em 40% de crédito especial!");
                // Valor do crédito recebe 40% do valor do saldo
                valorCredito = saldo * 40 / 100;
            }

            // Valor total recebe o valor do crédito mais o saldo
            valorTotal = valorCredito + saldo;

            // Mostra o saldo com duas casas decimais
            Console.WriteLine($"Valor saldo: R${Math.Round(saldo,2)}");
            // Mostra o credito especial com duas casas decimais
            Console.WriteLine($"Valor do crédito especial: R${Math.Round(valorCredito,2)}");
            // Mostra o valor total com duas casas decimais
            Console.WriteLine($"Valor total: R${Math.Round(valorTotal,2)}\n");
        }
    }
}
