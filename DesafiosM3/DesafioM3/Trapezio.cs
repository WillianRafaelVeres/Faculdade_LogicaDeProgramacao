// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Trapezio
    {
        // Variável que armazena a altura do trapezio
        private double altura;
        // Variável que armazena a base Maior do trapezio
        private double baseMaior;
        // Variável que armazena a base Menor do trapezio
        private double baseMenor;
        // Variável que armazena a profundidade do trapezio
        private double profundidade;

        // Variável que armazena a area do trapezio
        private double area;
        // Variável que armazena o volume do trapezio
        private double volume;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Trapezio(double h, double bMaior, double bMenor, double p){
            altura = h;
            baseMaior = bMaior;
            baseMenor = bMenor;
            profundidade = p;

            area = 0;
            volume = 0;;
        }

        // Procedimento que calcula a área do trapézio e armazena na variável de instância
        public void CalculaArea(){
            area = ((baseMenor + baseMaior)*altura)/2;
        }

        // Procedimento que calcula o volume do trapézio e armazena na variável de instância
        public void CalculaVolume(){
            volume = ((((baseMenor + baseMaior)* altura)/2) * profundidade * (baseMenor + baseMaior) / 2);
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
        //---------------------------------------------------------------
    }
}