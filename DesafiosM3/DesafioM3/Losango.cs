// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Losango
    {
        // Variável que armazena a diagonal menor do losango
        private double diagonalMenor;
        // Variável que armazena a diagonal maior do losango
        private double diagonalMaior;
        // Variável que armazena a profundidade do losango
        private double profundidade;

        // Variável que armazena a área do losango
        private double area;
        // Variável que armazena o volume do losango
        private double volume;
        // Variável que armazena o perimetro da base do losango
        private double perimetroDaBase;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Losango(double dMenor, double dMaior, double profun){

            diagonalMenor = dMenor;
            diagonalMaior = dMaior;
            profundidade = profun;

            area = 0;
            volume = 0;
            perimetroDaBase = 0;

        }
        
        // Procedimento que calcula a área do losango e armazena na variável de instância
        public void CalculaArea(){
            area = (diagonalMenor * diagonalMaior)/2;
        }

        // Procedimento que calcula o volume do losango e armazena na variável de instância
        public void CalculaVolume(){
            volume = ((diagonalMenor * diagonalMaior)/2) * profundidade;
        }

        // Procedimento que calcula o perimetro da Base do losango e armazena na variável de instância
        public void CalculaPerimetroDaBase(){

            double x;
            double x1;

            x = (Math.Pow((diagonalMenor/2),2)) + (Math.Pow((diagonalMaior/2),2));
            x1 = Math.Sqrt(x);

            perimetroDaBase = 4 * x1;
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

        public double get_perimetroDaBase()
        {
            return perimetroDaBase; // retorna o valor do perimetro da base
        }
        //---------------------------------------------------------------
    }
}