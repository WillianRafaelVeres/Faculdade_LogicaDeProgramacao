using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite um némero:");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if(numeroDigitado == 5){
                Console.WriteLine("O número digitado é igual a 5!");
            }

            else if(numeroDigitado == 200){
                Console.WriteLine("O número digitado é igual a 200!");
            }

            else if(numeroDigitado == 400){
                Console.WriteLine("O número digitado é igual a 400!");
            }

            else if(numeroDigitado >= 500 && numeroDigitado <= 1000){
                Console.WriteLine("O número digitado está entre 500 e 1000!");
            }

            else{
                Console.WriteLine("O número digitado não se encaixa em nenhum dos escopos!");
            }
        }
    }
}
