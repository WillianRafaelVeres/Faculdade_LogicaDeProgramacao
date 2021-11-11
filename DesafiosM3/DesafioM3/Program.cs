using System;

namespace DesafioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncaoParaContinuar();
        }
        /*
        static void RepetirPrograma(){
            
            int opcaoDeOperacao;
            

            Console.WriteLine("\n Opções disponiveis: \n 1 - Cilindro \n 2 - Círculo \n 3 - Elipse \n 4 - Esfera \n 5 - Losango \n 6 - Paralelogramo \n 7 - Quadrado \n 8 - Retângulo \n 9 - Trapézio \n 10 - Triângulo Equilátero \n 11 - Triângulo Isósceles \n 12 - Triângulo Retângulo \n");
            Console.WriteLine("Digite qual forma você deseja. Digite apenas o número do exercicio: ");
            opcaoDeOperacao = int.Parse(Console.ReadLine());

            
            switch(opcaoDeOperacao){

                case 1:
                    "---";
                    return;
                
                case 2:
                    "---";
                    return;

                case 3:
                    "---";
                    return;

                case 4:
                    "---";
                    return;

                case 5:
                    "---";
                    return;

                case 6:
                    "---";
                    return;

                case 7:
                    "---";
                    return;

                case 8:
                    "---";
                    return;

                case 9:
                    "---";
                    return;

                case 10:
                    "---";
                    return;

                case 11:
                    "---";
                    return;

                case 12:
                    "---";
                    return;
                
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    RepetirPrograma();
                    return;
            }
        }*/


        static void FuncaoParaContinuar(){

            int opcaoParaContinuar = 1;

            Console.WriteLine("\nDigite [1] - Para executar outra vez!");
            Console.WriteLine("Digite [2] - Para fechar o programa!");
            Console.Write("Opção:");

            try{
                opcaoParaContinuar = int.Parse(Console.ReadLine());
                
                if(opcaoParaContinuar == 1){
                //RepetirPrograma();
                Console.WriteLine("1");
                }

                else if( opcaoParaContinuar == 2){
                    Console.WriteLine("\nAté a próxima!\n");
                }

                else{
                    Console.WriteLine("Opção invélida, digite novamente!");
                   FuncaoParaContinuar();
                }
            }
            catch(Exception e){
                Console.WriteLine("Esta opção é uma opção inválida. Por Favor, digite apenas números.");
                FuncaoParaContinuar();
            }
        }
    }
}
