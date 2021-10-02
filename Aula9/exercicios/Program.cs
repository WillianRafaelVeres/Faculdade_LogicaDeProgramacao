using System;

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

            int[] numeros;
            int soma;

            Console.Clear();
            Console.WriteLine("Exercício6");

            for( int contador = 0; contador <= 9; contador++){

                Console.WriteLine("Digite um numero:");
                numeros[contador] = int.Parse(Console.ReadLine());
            }

            for( int contador = 0; contador <= 9; contador++){

                soma += numeros[contador];

            }

            Console.WriteLine($"A soma dos números é {soma}!");
            Console.WriteLine($"A média dos números é {soma/10}!");


            FuncaoParaContinuar();

        }

        static void Exercicio7(){

            Console.Clear();
            Console.WriteLine("Exercício7");
            FuncaoParaContinuar();

        }

        static void Exercicio8(){

            Console.Clear();
            Console.WriteLine("Exercício8");
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

            Console.WriteLine("Digite [1] - Para executar outro exercicio!");
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
