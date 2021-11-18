// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Program
    {
        //inicio de entrada do programa
        static void Main(string[] args)
        {
            RepetirPrograma(); // Mostra as opções
        }

        // Procedimento para mostrar e iniciar as opções
        static void RepetirPrograma(){
            
            int opcaoDeOperacao; // Variável para armazenar as opções
            
            // Opções
            Console.WriteLine("\n Opções disponiveis: \n 1 - Cilindro \n 2 - Círculo \n 3 - Elipse \n 4 - Esfera \n 5 - Losango \n 6 - Paralelogramo \n 7 - Quadrado \n 8 - Retângulo \n 9 - Trapézio \n 10 - Triângulo Equilátero \n 11 - Triângulo Isósceles \n 12 - Triângulo Retângulo \n");
            Console.WriteLine("Digite qual forma você deseja. Digite apenas o número do exercicio: ");
            opcaoDeOperacao = int.Parse(Console.ReadLine());

            // Executa um procedimento de acordo com a opção escolida
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

        // Função para verifiacar se deseja fechar o programa
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
            // Tratamento de erro / reinicia o programa
            catch(Exception e){
                Console.WriteLine("Esta opção é uma opção inválida. Por Favor, digite apenas números.");
                FuncaoParaContinuar();
            }
        }

        // Procedimento para fazer contas do cilindro
        static void ExecutarCilindro(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double areaDaBase;
            double areaLateral;
            double areaTotal;
            double perimetro;
            double volume;

            double raio;
            double altura;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <cilindro>, do tipo cilindro
            Cilindro cilindro = new Cilindro(raio, altura);

            // Acessa métodos públicos
            cilindro.CalculaAreaDaBase();
            cilindro.CalculaAreaLateral();
            cilindro.CalculaAreaTotal();
            cilindro.CalculaPerimetro();
            cilindro.CalculaVolume();

            // Acessa valores das variáveis privadas e armazena na variável local
            areaDaBase = cilindro.get_areaDaBase();
            areaLateral = cilindro.get_areaLateral();
            areaTotal = cilindro.get_areaTotal();
            perimetro = cilindro.get_perimetro();
            volume = cilindro.get_volume();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Cilindro");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Area da Base: {Math.Round(areaDaBase,4)} m²");
            Console.WriteLine($"Area Lateral: {Math.Round(areaLateral,4)} m²");
            Console.WriteLine($"Area Total: {Math.Round(areaTotal,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do circulo
        static void ExecutarCirculo(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double perimetro;

            double raio;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <circulo>, do tipo circulo
            Circulo circulo = new Circulo(raio);

            // Acessa métodos públicos
            circulo.CalculaArea();
            circulo.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = circulo.get_area();
            perimetro = circulo.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Circulo");
            Console.WriteLine($"Area da Base: {Math.Round(area,4)} m²");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }
    
        // Procedimento para fazer contas da Elipse
        static void ExecutarElipse(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double perimetroAproximadoA;
            double perimetroAproximadoB;
            double volumeProlato;
            double volumeOblato;
            double areaProlato;
            double areaOblato;

            double raioMaior;
            double raioMenor;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite o raio horizontal: ");
            raioMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite o raio vertical: ");
            raioMenor = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <elipse>, do tipo elipse
            Elipse elipse = new Elipse(raioMaior, raioMenor);

            // Acessa métodos públicos
            elipse.CalculaArea();
            elipse.CalculaPerimetroAproximadoA();
            elipse.CalculaPerimetroAproximadoB();
            elipse.CalculaProlato();
            elipse.CalculaOblato();
            elipse.CalculaAreaProlato();
            elipse.CalculaAreaOblato();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = elipse.get_area();
            perimetroAproximadoA = elipse.get_PerimetroAproximadoA();
            perimetroAproximadoB = elipse.get_PerimetroAproximadoB();
            volumeOblato = elipse.get_VolumeOblato();
            volumeProlato = elipse.get_VolumeProlato();
            areaProlato = elipse.get_AreaProlato();
            areaOblato = elipse.get_AreaOblato();

            // Mostra na tela o resultado dos calculos
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

        // Procedimento para fazer contas da Esfera
        static void ExecutarEsfera(){ 

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;

            double raio;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite o raio: ");
            raio = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <esfera>, do tipo esfera
            Esfera esfera = new Esfera(raio);

            // Acessa métodos públicos
            esfera.CalculaArea();
            esfera.CalculaVolume();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = esfera.get_area();
            volume = esfera.get_volume();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Esfera");
            Console.WriteLine($"Area da Base: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do Losango
        static void ExecutarLosango(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetroDaBase;

            double diagonalMenor;
            double diagonalMaior;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a diagonal Maior: ");
            diagonalMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite a diagonal Menor: ");
            diagonalMenor = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <losango>, do tipo losango
            Losango losango = new Losango(diagonalMenor, diagonalMaior, profundidade);

            // Acessa métodos públicos
            losango.CalculaArea();
            losango.CalculaVolume();
            losango.CalculaPerimetroDaBase();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = losango.get_area();
            volume = losango.get_volume();
            perimetroDaBase = losango.get_perimetroDaBase();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Losango");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro da Base: {Math.Round(perimetroDaBase,4)} m");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do Paralelogramo
        static void ExecutarParalelogramo(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <paralelogramo>, do tipo paralelogramo
            Paralelogramo paralelogramo = new Paralelogramo(altura, base1, profundidade);

            // Acessa métodos públicos
            paralelogramo.CalculaArea();
            paralelogramo.CalculaVolume();
            paralelogramo.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = paralelogramo.get_area();
            volume = paralelogramo.get_volume();
            perimetro = paralelogramo.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Paralelogramo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do quadrado
        static void ExecutarQuadrado(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <quadrado>, do tipo quadrado
            Quadrado quadrado = new Quadrado(altura, base1, profundidade);

            // Acessa métodos públicos
            quadrado.CalculaArea();
            quadrado.CalculaVolume();
            quadrado.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = quadrado.get_area();
            volume = quadrado.get_volume();
            perimetro = quadrado.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados quadrado");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do retângulo
        static void ExecutarRetangulo(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double base1;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <retangulo>, do tipo retangulo
            Retangulo retangulo = new Retangulo(altura, base1, profundidade);

            // Acessa métodos públicos
            retangulo.CalculaArea();
            retangulo.CalculaVolume();
            retangulo.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = retangulo.get_area();
            volume = retangulo.get_volume();
            perimetro = retangulo.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados retângulo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perimetro: {Math.Round(perimetro,4)} m");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do trapézio
        static void ExecutarTrapezio(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;

            double altura;
            double baseMaior;
            double baseMenor;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a base Maior: ");
            baseMaior = double.Parse(Console.ReadLine());

            Console.Write("Digite a base Menor: ");
            baseMenor = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <trapezio>, do tipo trapezio
            Trapezio trapezio = new Trapezio(altura, baseMaior, baseMenor, profundidade);

            // Acessa métodos públicos
            trapezio.CalculaArea();
            trapezio.CalculaVolume();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = trapezio.get_area();
            volume = trapezio.get_volume();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados trapézio");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do Triângulo Equilatero
        static void ExecutarTrianguloEquilatero(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <trianguloEquilatero>, do tipo trianguloEquilatero
            TrianguloEquilatero trianguloEquilatero = new TrianguloEquilatero(altura, profundidade);

            // Acessa métodos públicos
            trianguloEquilatero.CalculaArea();
            trianguloEquilatero.CalculaVolume();
            trianguloEquilatero.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = trianguloEquilatero.get_area();
            volume = trianguloEquilatero.get_volume();
            perimetro = trianguloEquilatero.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Triângulo Equilátero");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Volume: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do Triângulo Isosceles
        static void ExecutarTrianguloIsosceles(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;
            double base1;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <trianguloIsosceles>, do tipo trianguloIsosceles
            TrianguloIsosceles trianguloIsosceles = new TrianguloIsosceles(altura, base1, profundidade);

            // Acessa métodos públicos
            trianguloIsosceles.CalculaArea();
            trianguloIsosceles.CalculaVolume();
            trianguloIsosceles.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = trianguloIsosceles.get_area();
            volume = trianguloIsosceles.get_volume();
            perimetro = trianguloIsosceles.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Triângulo Isósceles");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }

        // Procedimento para fazer contas do Triângulo Retângulo
        static void ExecutarTrianguloRetangulo(){

            Console.Clear();

            // Criação de variáveis locais (dados e resultados)
            double area;
            double volume;
            double perimetro;

            double altura;
            double profundidade;
            double base1;
            // -------------------------------------------------------

            // Solicitação dos dados
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a profundidade: ");
            profundidade = double.Parse(Console.ReadLine());

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());
            // -------------------------------------------------------

            //cria um objeto <trianguloRetangulo>, do tipo trianguloRetangulo
            TrianguloRetangulo trianguloRetangulo = new TrianguloRetangulo(altura, base1, profundidade);

            // Acessa métodos públicos
            trianguloRetangulo.CalculaArea();
            trianguloRetangulo.CalculaVolume();
            trianguloRetangulo.CalculaPerimetro();

            // Acessa valores das variáveis privadas e armazena na variável local
            area = trianguloRetangulo.get_area();
            volume = trianguloRetangulo.get_volume();
            perimetro = trianguloRetangulo.get_perimetro();

            // Mostra na tela o resultado dos calculos
            Console.WriteLine("\nResultados Triângulo Retângulo");
            Console.WriteLine($"Area: {Math.Round(area,4)} m²");
            Console.WriteLine($"Volume: {Math.Round(volume,4)} m³");
            Console.WriteLine($"Perímetro: {Math.Round(perimetro,4)} m³");

            FuncaoParaContinuar();
        }
    }
}
