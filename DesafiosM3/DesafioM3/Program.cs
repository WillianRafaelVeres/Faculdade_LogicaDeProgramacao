using System;

namespace DesafioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarParalelogramo();
        }
        /*
        static void RepetirPrograma(){
            
            int opcaoDeOperacao;
            

            Console.WriteLine("\n Opções disponiveis: \n 1 - Cilindro \n 2 - Círculo \n 3 - Elipse \n 4 - Esfera \n 5 - Losango \n 6 - Paralelogramo \n 7 - Quadrado \n 8 - Retângulo \n 9 - Trapézio \n 10 - Triângulo Equilátero \n 11 - Triângulo Isósceles \n 12 - Triângulo Retângulo \n");
            Console.WriteLine("Digite qual forma você deseja. Digite apenas o número do exercicio: ");
            opcaoDeOperacao = int.Parse(Console.ReadLine());

            
            switch(opcaoDeOperacao){

                case 1:
                    ExecutarCilindro();
                    return;
                
                case 2:
                    ExecutarCirculo();
                    return;

                case 3:
                    "---";
                    return;

                case 4:
                    ExecutarEsfera();
                    return;

                case 5:
                    ExecutarLosango();
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

        static void ExecutarCilindro(){

            double raio;
            double altura;

            double volume;
            double areaDaBase;
            double areaLateral;
            double areaTotal;
            double perimetro;

            Console.Clear();

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = Cilindro.CalculaVolume(raio,altura);
            areaDaBase = Cilindro.CalculaAreaDaBase(raio);
            areaLateral = Cilindro.CalculaAreaLateral(raio,altura);
            areaTotal = Cilindro.CalculaAreaTotal(raio,altura);
            perimetro = Cilindro.CalculaPerimetro(raio);

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Area da Base: {Math.Round(areaDaBase,4)} m²");
            Console.WriteLine($"Area Lateral: {Math.Round(areaLateral,4)} m²");
            Console.WriteLine($"Area Total: {Math.Round(areaTotal,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            //FuncaoParaContinuar();
        }

        static void ExecutarCirculo(){

            double raio;

            double area;
            double perimetro;

            Console.Clear();

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            area = Circulo.CalculaArea(raio);
            perimetro = Circulo.CalculaPerimetro(raio);

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            //FuncaoParaContinuar();
        }

        static void ExecutarEsfera(){

            double raio;

            double area;
            double volume;

            Console.Clear();

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            area = Esfera.CalculaArea(raio);
            volume = Esfera.CalculaVolume(raio);

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m");

            //FuncaoParaContinuar();
        }
    
        static void ExecutarLosango(){

            double diagonalMenor;
            double diagonalMaior;
            double profundidade;

            double area;
            double volume;
            double perimetroDaBase;

            Console.Clear();

            Console.Write("Digite a diagonal menor: ");
            diagonalMenor = double.Parse(Console.ReadLine());

            Console.Write("Digite a diagonal maior: ");
            diagonalMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            area = Losango.CalculaArea(diagonalMenor, diagonalMaior);
            volume = Losango.CalculaVolume(diagonalMenor, diagonalMaior, profundidade);
            perimetroDaBase = Losango.CalculaPerimetroDaBase(diagonalMenor, diagonalMaior);

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Area: {Math.Round(area,4)} m³");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro Da Base: {Math.Round(perimetroDaBase,4)} m³"); //O site está aparentemente errado

            //FuncaoParaContinuar();
        }
    
        static void ExecutarParalelogramo(){

            double altura;
            double base1;
            double profundidade;

            double area;
            double volume;
            double perimetro;

            Console.Clear();

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            area = Paralelogramo.CalculaArea(altura,base1);
            volume = Paralelogramo.CalculaVolume(altura, base1, profundidade);
            perimetro = Paralelogramo.CalculaPerimetro(altura,base1);

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Area: {Math.Round(area,4)} m³");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m³");

            //FuncaoParaContinuar();
        }
    }
}
