using System;

namespace Exercicio6
{
    class Program
    {
        static double[] numeros = new double[2];

        static void Main(string[] args)
        {
            double resultado;

            Console.Clear();
            LerEValidarValores();
            resultado = Divisao();
            MostrarResultado(resultado);
        }

        static void LerEValidarValores(){
            
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            if (numeros[1] == 0)
            {
                int i3 = 1;

                for (int i = 0; i < i3; i++)
                {
                    Console.Write("Valor inválido! Tente Novamente: ");
                    numeros[1] = double.Parse(Console.ReadLine());
                    if(numeros[1] == 0){
                        i3 ++;
                    }

                }
            }
        }

        static double Divisao(){

            return numeros[0]/numeros[1];

        }

        static void MostrarResultado(double resultado){

            Console.WriteLine("\nOs números digitados foram:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(numeros[i].ToString());
            }
            Console.WriteLine($"\nO resultado foi: {resultado}!\n");
        }

    }
}
