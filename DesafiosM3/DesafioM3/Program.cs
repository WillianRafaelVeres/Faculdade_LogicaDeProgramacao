using System;

namespace DesafioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarElipse();
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

            Console.Clear();

            double areaDaBase;
            double areaLateral;
            double areaTotal;
            double perimetro;
            double volume;

            double raio;
            double altura;

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Cilindro cilindro = new Cilindro(raio, altura);

            cilindro.CalculaAreaDaBase();
            cilindro.CalculaAreaLateral();
            cilindro.CalculaAreaTotal();
            cilindro.CalculaPerimetro();
            cilindro.CalculaVolume();

            areaDaBase = cilindro.get_areaDaBase();
            areaLateral = cilindro.get_areaLateral();
            areaTotal = cilindro.get_areaTotal();
            perimetro = cilindro.get_perimetro();
            volume = cilindro.get_volume();

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Area da Base: {Math.Round(areaDaBase,4)} m²");
            Console.WriteLine($"Area Lateral: {Math.Round(areaLateral,4)} m²");
            Console.WriteLine($"Area Total: {Math.Round(areaTotal,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            //FuncaoParaContinuar();
        }

        static void ExecutarCirculo(){

            Console.Clear();

            double area;
            double perimetro;

            double raio;

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Circulo circulo = new Circulo(raio);

            circulo.CalculaArea();
            circulo.CalculaPerimetro();

            area = circulo.get_area();
            perimetro = circulo.get_perimetro();

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Area da Base: {Math.Round(area,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            //FuncaoParaContinuar();
        }
    
        static void ExecutarElipse(){

            Console.Clear();

            double area;
            double perimetroAproximadoA;
            double perimetroAproximadoB;
            double volumeProlato;
            double volumeOblato;
            double areaProlato;
            double areaOblato;

            double raioMaior;
            double raioMenor;

            Console.Write("Digite o raio horizontal: ");
            raioMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite o raio vertical: ");
            raioMenor = double.Parse(Console.ReadLine());

            Elipse elipse = new Elipse(raioMaior, raioMenor);

            elipse.CalculaArea();
            elipse.CalculaPerimetroAproximadoA();
            elipse.CalculaPerimetroAproximadoB();
            elipse.CalculaProlato();
            elipse.CalculaOblato();
            elipse.CalculaAreaProlato();
            elipse.CalculaAreaOblato();

            area = elipse.get_area();
            perimetroAproximadoA = elipse.get_PerimetroAproximadoA();
            perimetroAproximadoB = elipse.get_PerimetroAproximadoB();
            volumeOblato = elipse.get_VolumeOblato();
            volumeProlato = elipse.get_VolumeProlato();
            areaProlato = elipse.get_AreaProlato();
            areaOblato = elipse.get_AreaOblato();

            Console.WriteLine("\nResultados");
            Console.WriteLine($"Área: {Math.Round(area,4)} m2");
            if(raioMaior>raioMenor){
                Console.WriteLine($"Perimetro aproximado: {Math.Round(perimetroAproximadoA,4)} m");
                Console.WriteLine($"Volume Oblato: {Math.Round(volumeOblato,4)} m3");
                Console.WriteLine($"Area Oblato: {Math.Round(areaOblato,4)} m²");
            }
            else{
                Console.WriteLine($"Perimetro aproximado: {Math.Round(perimetroAproximadoB,4)} m");
                Console.WriteLine($"Volume Prolato: {Math.Round(volumeProlato,4)} m3");
                Console.WriteLine($"Area Prolato: {Math.Round(areaProlato,4)} m²");
            }

            //FuncaoParaContinuar();
        }

    }
}
