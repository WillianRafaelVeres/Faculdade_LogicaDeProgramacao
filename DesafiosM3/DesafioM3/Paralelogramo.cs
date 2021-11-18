// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Paralelogramo
    {
        // Variável que armazena a altura do papalelogramo
        private double altura;
        // Variável que armazena a base do papalelogramo
        private double base1;
        // Variável que armazena a profundidade do papalelogramo
        private double profundidade;

        // Variável que armazena a área do papalelogramo
        private double area;
        // Variável que armazena o volume do papalelogramo
        private double volume;
        // Variável que armazena o perímetro do papalelogramo
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Paralelogramo(double h, double b, double p){

            altura = h;
            base1 = b;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;

        }

        // Procedimento que calcula a área do palalelogramo e armazena na variável de instância
        public void CalculaArea(){
            area = altura * base1;
        }

        // Procedimento que calcula o volume do palalelogramo e armazena na variável de instância
        public void CalculaVolume(){
            volume = altura * base1 * profundidade;
        }

        // Procedimento que calcula o perimetro do palalelogramo e armazena na variável de instância
        public void CalculaPerimetro(){
            perimetro = (( 2 * altura ) + ( 2 * base1 ));
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area()
        {
            return area; // retorna o valor da área
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