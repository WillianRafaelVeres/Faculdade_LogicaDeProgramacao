// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Retangulo
    {
        // Variável que armazena a altura do retângulo
        private double altura;
        // Variável que armazena a base do retângulo
        private double base1;
        // Variável que armazena a profundidade do retângulo
        private double profundidade;

        // Variável que armazena a área do retângulo
        private double area;
        // Variável que armazena o volume do retângulo
        private double volume;
        // Variável que armazena o perimetro do retângulo
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Retangulo(double h, double b, double p){

            altura = h;
            base1 = b;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
            
        }

        // Procedimento que calcula a área do retângulo e armazena na variável de instância
        public void CalculaArea(){
            area = altura * base1;
        }

        // Procedimento que calcula o volume do retângulo e armazena na variável de instância
        public void CalculaVolume(){
            volume = altura * base1 * profundidade;
        }

        // Procedimento que calcula o perímetro do retângulo e armazena na variável de instância
        public void CalculaPerimetro(){
            perimetro = (( 2 * altura ) + ( 2 * base1 ));
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