// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class TrianguloRetangulo
    {
        // Variável que armazena a altura do triângulo Retângulo
        private double altura;
        // Variável que armazena a base do triângulo Retângulo
        private double base1;
        // Variável que armazena a profundidade do triângulo Retângulo
        private double profundidade;

        // Variável que armazena a área do triângulo Retângulo
        private double area;
        // Variável que armazena o volume do triângulo Retângulo
        private double volume;
        // Variável que armazena o perímetro do triângulo Retângulo
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public TrianguloRetangulo(double h, double base2, double p){
            altura = h;
            base1 = base2;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
        }
        
        // Procedimento que calcula a área do Triângulo Retângulo e armazena na variável de instância
        public void CalculaArea(){
            area = (altura * base1 / 2);
        }

        // Procedimento que calcula o volume do Triângulo Retângulo e armazena na variável de instância
        public void CalculaVolume(){
            volume = (altura * base1 / 2) * profundidade;
        }

        // Procedimento que calcula o perímetro do Triângulo Retângulo e armazena na variável de instância
        public void CalculaPerimetro(){
            perimetro = 2 * Math.Sqrt((altura*altura)+(base1*base1)+altura+base1);
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