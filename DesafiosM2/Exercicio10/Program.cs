using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Clear();

            numero = LerNumero();

            Console.WriteLine();

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"---    {i} X {numero} = {numero*i}");
            }
            
            Console.WriteLine();


        }

        static int LerNumero(){

            int numero;

            Console.WriteLine("Digite um número inteiro entre 1 e 10: ");

            numero = int.Parse(Console.ReadLine());

            while(numero <= 0 || numero >= 11){
                Console.Write("Valor inválido, só são aceitos numeros inteiros entre 1 e 10:\nTente Novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            return numero;

        }
    }
}
