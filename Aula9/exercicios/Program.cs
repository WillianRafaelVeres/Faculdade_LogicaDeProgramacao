using System;
using System.Collections.Generic;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            RepetirPrograma();
            
        }

        static void Exercicio5(){

            int numeroParaTabuada;

            Console.Clear();
            Console.WriteLine("Exercício5");

            Console.Write("Digite um número para tabuada: ");
            numeroParaTabuada = int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= 10; contador++){
                Console.WriteLine($"{contador} * {numeroParaTabuada} = {contador * numeroParaTabuada}");
            }

            FuncaoParaContinuar();

        }

        static void Exercicio6(){

            List<int> numeros = new List<int>();
            int soma = 0;

            Console.Clear();
            Console.WriteLine("Exercício6");

            for( int contador = 0; contador <= 9; contador++){

                Console.WriteLine("Digite um numero:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            for( int contador = 0; contador <= 9; contador++){

                soma += numeros[contador];

            }

            Console.WriteLine($"\nA soma dos números é {soma}!");
            Console.WriteLine($"A média dos números é {soma/10}!");

            FuncaoParaContinuar();

        }

        static void Exercicio7(){

            double numeroBase;
            double numeroDeElevacao;
            double somaDaSerie;

            Console.Clear();
            Console.WriteLine("Exercício7");

            Console.Write("Digite o número base: ");
            numeroBase = double.Parse(Console.ReadLine());
            Console.Write("A quanto esse número será elevado? ");
            numeroDeElevacao = double.Parse(Console.ReadLine());

            somaDaSerie = numeroBase;

            for(int contador = 2; contador <= numeroDeElevacao; contador++){

                somaDaSerie += (Math.Pow(numeroBase,contador));

            }

            Console.WriteLine($"A soma da série é {Math.Round(somaDaSerie,2)}!");

            FuncaoParaContinuar();

        }

        static void Exercicio8(){

            float numeroParaSerie;
            float resultado = 0;

            Console.Clear();
            Console.WriteLine("Exercício8");

            Console.Write("Digite um número para a série: ");
            numeroParaSerie = float.Parse(Console.ReadLine());

            for(float contador = 1; contador <= (numeroParaSerie + 1); contador++){
                
                if (contador == 1)
                {
                    Console.WriteLine();
                }

                Console.Write($" 1/{contador} ");
                resultado += 1/contador;

                if (contador <= numeroParaSerie)
                {
                    Console.Write("+");
                }
            }

            Console.WriteLine($"\n\nO resultado é {Math.Round(resultado,6)}!");




            FuncaoParaContinuar();

        }

        static void RepetirPrograma(){
            
            int opcaoDeExercicio;
            

            Console.WriteLine("\n Exercicios disponiveis... \n Exercício 5 \n Exercício 6 \n Exercício 7 \n Exercício 8");
            Console.WriteLine("Digite qual exercicio você deseja executar. Digite apenas o número do exercicio: ");
            opcaoDeExercicio = int.Parse(Console.ReadLine());

            if (opcaoDeExercicio == 5)
            {
                Exercicio5();
            }
            
            else if (opcaoDeExercicio == 6)
            {
                Exercicio6();
            }

            else if (opcaoDeExercicio == 7)
            {
                Exercicio7();
            }

            else if (opcaoDeExercicio == 8)
            {
                Exercicio8();
            }

            else{
                Console.Clear();
                Console.WriteLine("Opção inválida");
                RepetirPrograma();
            }

        }

        static void FuncaoParaContinuar(){

            int opcaoParaContinuar;

            Console.WriteLine("\nDigite [1] - Para executar outro exercicio!");
            Console.WriteLine("Digite [2] - Para fechar o programa!");

            opcaoParaContinuar = int.Parse(Console.ReadLine());

            if(opcaoParaContinuar == 1){
                RepetirPrograma();
            }

            else if( opcaoParaContinuar == 2){
                Console.WriteLine("\nAté a próxima!\n");
            }

            else{
                Console.WriteLine("Opção invélida, digite novamente!");
                FuncaoParaContinuar();
            }
        }
    }
}
