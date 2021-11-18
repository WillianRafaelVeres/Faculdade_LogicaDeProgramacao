// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class TrianguloEquilatero
    {
        // Variável que armazena a altura do triângulo Equilatero
        private double altura;
        // Variável que armazena a profundidade do triângulo Equilatero
        private double profundidade;

        // Variável que armazena a área do triângulo Equilatero
        private double area;
        // Variável que armazena o volume do triângulo Equilatero
        private double volume;
        // Variável que armazena o perímetro do triângulo Equilatero
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public TrianguloEquilatero(double h, double p){
            altura = h;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
        }

        // Procedimento que calcula a área do Triângulo Equilatero e armazena na variável de instância
        public void CalculaArea(){
            area = ((altura * altura) / Math.Sqrt(3));
        }

        // Procedimento que calcula o volume do Triângulo Equilatero e armazena na variável de instância
        public void CalculaVolume(){
            volume = ((Math.Pow(altura,2)/3) * profundidade);
        }

        // Procedimento que calcula o perimetro do Triângulo Equilatero e armazena na variável de instância
        public void CalculaPerimetro(){ 
            perimetro = ( 3 * ( 2 * altura ) / Math.Sqrt(3));
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area()
        {
            return area; // retorna o valor da area
        }

        public double get_volume()
        {
            return volume; // retorna o valor do volume
        }

        public double get_perimetro()
        {
            return perimetro; // retorna o valor do perimetro
        }
        //---------------------------------------------------------------
    }
}