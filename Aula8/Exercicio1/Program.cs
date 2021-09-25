using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A idade informada é {Convert.ToString(idade)}!");

            if(idade < 18){
                
                Console.WriteLine("Encaixando-se em menor de idade!");
            }

            else if (idade > 65){
                Console.WriteLine("Encaixando-se em terceira idade!");
            }

            else{
                Console.WriteLine("Encaixando-se em maior de idade!");
            }

        }
    }
}
