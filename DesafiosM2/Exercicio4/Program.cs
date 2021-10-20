//Victor e Willian - 20/10/2021
using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string retorno;

            // Função para limpar o terminal
            Console.Clear();

            numero = LerInt();
            retorno = Comparar(numero);

            Console.WriteLine($"\nA resposta é {retorno}\n");

        }

        static int LerInt(){
            
            Console.Write("Digite um número inteiro: ");
            return int.Parse(Console.ReadLine());

        }

        static string Comparar(int numero){

            if(numero <= 10){
                return "F1";
            }
            else if(numero > 10 && numero <= 100)
            {
                return "F2";
            }
            else
            {
                return "F3";
            }

        }
    }
}
