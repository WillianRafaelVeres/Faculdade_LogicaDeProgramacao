using System;

namespace DesafioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            RepetirPrograma();
        }
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
                    ExecutarElipse();
                    return;

                case 4:
                    ExecutarEsfera();
                    return;

                case 5:
                    ExecutarLosango();
                    return;

                case 6:
                    ExecutarParalelogramo();
                    return;

                case 7:
                    ExecutarQuadrado();
                    return;

                case 8:
                    ExecutarRetangulo();
                    return;

                case 9:
                    ExecutarTrapezio();
                    return;

                case 10:
                    ExecutarTrianguloEquilatero();
                    return;

                case 11:
                    ExecutarTrianguloIsosceles();
                    return;

                case 12:
                    ExecutarTrianguloRetangulo();
                    return;
                
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    RepetirPrograma();
                    return;
            }
        }


        static void FuncaoParaContinuar(){

            int opcaoParaContinuar = 1;

            Console.WriteLine("\nDigite [1] - Para executar outra vez!");
            Console.WriteLine("Digite [2] - Para fechar o programa!");
            Console.Write("Opção:");

            try{
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

            Console.WriteLine("\nResultados Cilindro");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Area da Base: {Math.Round(areaDaBase,4)} m²");
            Console.WriteLine($"Area Lateral: {Math.Round(areaLateral,4)} m²");
            Console.WriteLine($"Area Total: {Math.Round(areaTotal,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
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

            Console.WriteLine("\nResultados Circulo");
            Console.WriteLine($"Area da Base: {Math.Round(area,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
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

            Console.WriteLine("\nResultados Elipse");
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

            FuncaoParaContinuar();
        }

        static void ExecutarEsfera(){ 

            Console.Clear();

            double area;
            double volume;

            double raio;

            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Esfera esfera = new Esfera(raio);

            esfera.CalculaArea();
            esfera.CalculaVolume();

            area = esfera.get_area();
            volume = esfera.get_volume();

            Console.WriteLine("\nResultados Esfera");
            Console.WriteLine($"Area da Base: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");

            FuncaoParaContinuar();
        }

        static void ExecutarLosango(){

            Console.Clear();

            double area;
            double volume;
            double perimetroDaBase;

            double diagonalMenor;
            double diagonalMaior;
            double profundidade;

            Console.Write("Digite a diagonal Maior: ");
            diagonalMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite a diagonal Menor: ");
            diagonalMenor = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Losango losango = new Losango(diagonalMenor, diagonalMaior, profundidade);

            losango.CalculaArea();
            losango.CalculaVolume();
            losango.CalculaPerimetroDaBase();

            area = losango.get_area();
            volume = losango.get_volume();
            perimetroDaBase = losango.get_perimetroDaBase();

            Console.WriteLine("\nResultados Losango");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro da Base: {Math.Round(perimetroDaBase,4)} m");

            FuncaoParaContinuar();
        }

        static void ExecutarParalelogramo(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Paralelogramo paralelogramo = new Paralelogramo(altura, base1, profundidade);

            paralelogramo.CalculaArea();
            paralelogramo.CalculaVolume();
            paralelogramo.CalculaPerimetro();

            area = paralelogramo.get_area();
            volume = paralelogramo.get_volume();
            perimetro = paralelogramo.get_perimetro();

            Console.WriteLine("\nResultados Paralelogramo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        static void ExecutarQuadrado(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Quadrado quadrado = new Quadrado(altura, base1, profundidade);

            quadrado.CalculaArea();
            quadrado.CalculaVolume();
            quadrado.CalculaPerimetro();

            area = quadrado.get_area();
            volume = quadrado.get_volume();
            perimetro = quadrado.get_perimetro();

            Console.WriteLine("\nResultados quadrado");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        static void ExecutarRetangulo(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(altura, base1, profundidade);

            retangulo.CalculaArea();
            retangulo.CalculaVolume();
            retangulo.CalculaPerimetro();

            area = retangulo.get_area();
            volume = retangulo.get_volume();
            perimetro = retangulo.get_perimetro();

            Console.WriteLine("\nResultados retângulo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        static void ExecutarTrapezio(){

            Console.Clear();

            double area;
            double volume;

            double altura;
            double baseMaior;
            double baseMenor;
            double profundidade;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base Maior: ");
            baseMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite a base Menor: ");
            baseMenor = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Trapezio trapezio = new Trapezio(altura, baseMaior, baseMenor, profundidade);

            trapezio.CalculaArea();
            trapezio.CalculaVolume();


            area = trapezio.get_area();
            volume = trapezio.get_volume();

            Console.WriteLine("\nResultados trapézio");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");

            FuncaoParaContinuar();
        }

        static void ExecutarTrianguloEquilatero(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero(altura, profundidade);

            trianguloEquilatero.CalculaArea();
            trianguloEquilatero.CalculaVolume();
            trianguloEquilatero.CalculaPerimetro();


            area = trianguloEquilatero.get_area();
            volume = trianguloEquilatero.get_volume();
            perimetro = trianguloEquilatero.get_perimetro();

            Console.WriteLine("\nResultados Triângulo Equilátero");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Volume: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }

        static void ExecutarTrianguloIsosceles(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;
            double base1;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            TrianguloIsosceles trianguloIsosceles = new TrianguloIsosceles(altura, base1, profundidade);

            trianguloIsosceles.CalculaArea();
            trianguloIsosceles.CalculaVolume();
            trianguloIsosceles.CalculaPerimetro();


            area = trianguloIsosceles.get_area();
            volume = trianguloIsosceles.get_volume();
            perimetro = trianguloIsosceles.get_perimetro();

            Console.WriteLine("\nResultados Triângulo Isósceles");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }

        static void ExecutarTrianguloRetangulo(){

            Console.Clear();

            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;
            double base1;

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            TrianguloRetangulo trianguloRetangulo = new TrianguloRetangulo(altura, base1, profundidade);

            trianguloRetangulo.CalculaArea();
            trianguloRetangulo.CalculaVolume();
            trianguloRetangulo.CalculaPerimetro();


            area = trianguloRetangulo.get_area();
            volume = trianguloRetangulo.get_volume();
            perimetro = trianguloRetangulo.get_perimetro();

            Console.WriteLine("\nResultados Triângulo Retângulo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }
    }
}
