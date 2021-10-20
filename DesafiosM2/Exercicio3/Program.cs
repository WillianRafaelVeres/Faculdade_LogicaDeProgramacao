//Victor e Willian - 20/10/2021
using System;

namespace Exercicio3
{
    class Program
    {
            static int saldoConta;
            static int operacao;
            static int valorOperacao;

        static void Main(string[] args)
        {
            int numeroConta;
            
            // Função para limpar o terminal
            Console.Clear();

            numeroConta = LerInt("o numero da sua conta");
            saldoConta = LerInt("o saldo de sua conta");
            operacao = LerOperacao();
            valorOperacao = LerInt("o valor da operação");
            RealizarOperacao(operacao);
            Situacao();

            Console.WriteLine($"Conta: {numeroConta}");
            Console.WriteLine($"Saldo: R$ {saldoConta},00\n");

        }

        static int LerInt(string mensagem){

            Console.Write($"\nAPENAS NUMEROS INTEIROS\nPor Favor, Digite {mensagem}:");
            return Int32.Parse(Console.ReadLine());

        }

        static int LerOperacao(){

            int operacaoDigitada;

            Console.Write("\n[1] - Depósito \n[2] - Retirada \nPor Favor, Digite a operação desejada:  ");
            operacaoDigitada = int.Parse(Console.ReadLine());

            if (operacaoDigitada == 1 || operacaoDigitada == 2)
            {
                return operacaoDigitada;
            }

            else
            {
                Console.WriteLine("\nOpçao inválida! Tente Novamente!");
                LerOperacao();
                return 0;
            }
        }

        static void RealizarOperacao(int opera){

            if (opera == 1)
            {
                saldoConta += valorOperacao;
            }

            else
            {
                saldoConta -= valorOperacao;
            }
        }

        static void Situacao(){

            if (saldoConta < 0)
            {
                Console.WriteLine("\n\n\nConta estourada!");
            }
            else
            {
                Console.WriteLine("\n\n\nOperação realizada com sucesso!");
            }
        }
    }
}