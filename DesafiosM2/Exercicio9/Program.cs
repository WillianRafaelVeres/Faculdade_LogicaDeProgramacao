using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Clear();
            numero = LerNumero();

            while(numero > 0){
                Console.WriteLine(numero);
                numero--;
            }

            
        }

        static int LerNumero(){

            int numero;

            Console.WriteLine("Digite um número inteiro maior que 0: ");

            numero = int.Parse(Console.ReadLine());

            while(numero <= 0){
                Console.Write("Valor inválido, só são aceitos numeros inteiros maiores que 0!\nTente Novamente: ");
                numero = int.Parse(Console.ReadLine());
            }

            return numero;

        }
    }
}
