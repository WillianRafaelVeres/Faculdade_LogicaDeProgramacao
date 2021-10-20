using System;

namespace Exercicio8
{
    class Program
    {
        static int index = 0;

        static void Main(string[] args)
        {
            string resposta;

            while(true){

                Resultado();
                resposta = Repetir("Novo cálculo");

                if(resposta == "N"){
                    Console.WriteLine("\n---Até mais!---\n");
                    break;
                }
            }
        }  

        static int LerNotas(){

            int soma = 0;
            string resposta = "S";
            index = 0;

            while(true){

                Console.Write("\nAPENAS NÚMEROS INTEIROS - Nota: ");
                soma += int.Parse(Console.ReadLine());
                index ++;

                resposta = Repetir("Deseja adicionar uma nova nota");
                
                if(resposta == "N"){
                    break;
                }
            }

            return soma;

        }

        static string Repetir(string mensagem){

            string resposta;

            Console.Write($"\n{mensagem}? (S/N)");
            resposta = Console.ReadLine();

            while(resposta != "S" && resposta != "N"){
                Console.Write("Valor inválido! Digite novamente: ");
                resposta = Console.ReadLine();
            }

            return resposta;

        }

        static void Resultado(){

            int soma;

            Console.Clear();

            soma = LerNotas();
            Console.WriteLine($"\nA média das notas é {soma/index}");
        }
    }
}
