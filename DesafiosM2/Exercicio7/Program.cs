using System;

namespace Exercicio7
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

            int i = 0;
            
            while(i < 2){
                Console.Write("Digite um numero: ");
                numeros[i] = double.Parse(Console.ReadLine());
                i++;
            }

            if (numeros[1] == 0)
            {

                while(true){
                    Console.Write("Valor inválido! Tente Novamente: ");
                    numeros[1] = double.Parse(Console.ReadLine());
                    if(numeros[1] != 0){
                        break;
                    }
                }
            }
        }

        static double Divisao(){

            return numeros[0]/numeros[1];

        }

        static void MostrarResultado(double resultado){
            int i = 0;

            Console.WriteLine("\nOs números digitados foram:");
            while(i < 2){
                Console.WriteLine(numeros[i].ToString());
                i++;
            }
            Console.WriteLine($"\nO resultado foi: {resultado}!\n");
        }

    }
}
