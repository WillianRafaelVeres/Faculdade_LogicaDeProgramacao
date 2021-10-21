//Victor e Willian - 20/10/2021
using System;

namespace Exercicio3
{
    class Program
    {
            // Varialvel estática do saldo da conta - Acessivel por todas as funções
            static int saldoConta;
            // Varialvel estática da operação - Acessivel por todas as funções
            static int operacao;
            // Varialvel estática do valor da operação - Acessivel por todas as funções
            static int valorOperacao;

        static void Main(string[] args) // Programa principal
        {
            // Variavel do numero da conta
            int numeroConta;
            
            // Função para limpar o terminal
            Console.Clear();

            // Armazena o numero da conta retornado pela função(Mensagem como parâmetro)
            numeroConta = LerInt("o numero da sua conta");
            // Armazena o saldo da conta retornado pela função(Mensagem como parâmetro)
            saldoConta = LerInt("o saldo de sua conta");
            // Armazena o que for retornado pela função;
            operacao = LerOperacao();
            // Armazena o valor da operção retornado pela função(Mensagem como parâmetro)
            valorOperacao = LerInt("o valor da operação");
            // Chama o procedimento e passa a operação como parâmetro
            RealizarOperacao(operacao);
            // Chama a função de Situação
            Situacao();

            // Mostra na tela o numero da conta
            Console.WriteLine($"Conta: {numeroConta}");
            // Mostra na tela o Saldo
            Console.WriteLine($"Saldo: R$ {saldoConta},00\n");
        }

        // Função para ler numero inteiro
        static int LerInt(string mensagem){

            // Mensagem pendo para digitar um numero inteiro
            Console.Write($"\nAPENAS NUMEROS INTEIROS\nPor Favor, Digite {mensagem}:");
            // Retorna o que for digitado convertido para inteiro
            return Int32.Parse(Console.ReadLine());
        }

        // Função para ler operação
        static int LerOperacao(){

            // Variavel da opção da operação
            int operacaoDigitada;

            // Mostra mensagem
            Console.Write("\n[1] - Depósito \n[2] - Retirada \nPor Favor, Digite a operação desejada:  ");
            // Armazena o que for digitado convertido para double
            operacaoDigitada = int.Parse(Console.ReadLine());

            // Verifica se operação digitada é igual a 1 ou 2
            if (operacaoDigitada == 1 || operacaoDigitada == 2)
            {
                // Retorna a operação digitada
                return operacaoDigitada;
            }

            // Senão
            else
            {
                //Mostra mensagem
                Console.WriteLine("\nOpçao inválida! Tente Novamente!");
                // Chama o procedimento para ler operação
                LerOperacao();
                // Retorna 0
                return 0;
            }
        }

        // Função para realizar operção
        static void RealizarOperacao(int opera){

            // Se opera for igual a 1
            if (opera == 1)
            {
                // Saldo acrecenta o valor da operação
                saldoConta += valorOperacao;
            }
            // Senão
            else if (opera == 2)
            {
                // Saldo subtrai o valor da operação
                saldoConta -= valorOperacao;
            }
        }

        // Função sobre a situação
        static void Situacao(){

            // Se o saldo for menor que 0
            if (saldoConta < 0)
            {
                // Mostra a mensagem
                Console.WriteLine("\n\n\nConta estourada!");
            }
            // Senão
            else
            {
                // Mostra outra mensagem
                Console.WriteLine("\n\n\nOperação realizada com sucesso!");
            }
        }
    }
}