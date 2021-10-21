//Victor e Willian - 20/10/2021
using System;

namespace Exercicio8
{
    class Program
    {
        // Varialvel estática do index - Acessivel por todas as funções
        static int index = 0;

        static void Main(string[] args) // Programa principal
        {
            // Variavel da resposta
            string resposta;

            // loop "infinito"
            while(true){

                // Procedimento do resultado
                Resultado();
                // Armazena o valor da resposta retornado pela função(mensagem como parâmetro)
                resposta = Repetir("Novo cálculo");

                // Se resposta for N
                if(resposta == "N"){
                    // Mensagem
                    Console.WriteLine("\n---Até mais!---\n");
                    // Saí do loop
                    break;
                }
            }
        }  

        // Função para ler notas
        static int LerNotas(){

            // Varialvel da soma
            int soma = 0;
            // Varialvel da resposta
            string resposta = "S";
            // Index recebe 0
            index = 0;

            // Loop "infinito"
            while(true){

                // Mostra mensagem pedindo a nota
                Console.Write("\nAPENAS NÚMEROS INTEIROS - Nota: ");
                // Acrescenta o que for digitado convertido para inteiro em soma
                soma += int.Parse(Console.ReadLine());
                // Acrescenta 1 em index
                index ++;

                // Armazena o valor da resposta retornado pela função(mensagem como parâmetro)
                resposta = Repetir("Deseja adicionar uma nova nota");
                
                // Se resposta for N
                if(resposta == "N"){
                    // Saí do loop
                    break;
                }
            }

            // Retorna a soma
            return soma;

        }

        // Procedimento para repetir o código (mensagem como parâmetro)
        static string Repetir(string mensagem){

            // Variavel resposta
            string resposta;

            // Mostra na tela a mensagem
            Console.Write($"\n{mensagem}? (S/N)");
            // Armazena em resposta o que for digitado
            resposta = Console.ReadLine();

            // Enquanto resposta for diferente de S e N
            while(resposta != "S" && resposta != "N"){
                // Mensagem
                Console.Write("Valor inválido! Digite novamente: ");
                // // Armazena em resposta o que for digitado
                resposta = Console.ReadLine();
            }

            // Retorna a resposta
            return resposta;

        }

        // Procedimento do resultado
        static void Resultado(){

            // Variavel soma
            int soma;

            // Função para limpar o terminal
            Console.Clear();

            // Armazena o valor da soma retornado pela função
            soma = LerNotas();
            // Mostra a média das notas
            Console.WriteLine($"\nA média das notas é {soma/index}");
        }
    }
}
