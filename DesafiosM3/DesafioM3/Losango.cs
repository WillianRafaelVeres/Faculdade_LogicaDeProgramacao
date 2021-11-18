using System;

namespace DesafioM3
{
    class Losango
    {
        private double diagonalMenor;
        private double diagonalMaior;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetroDaBase;

        public Losango(double dMenor, double dMaior, double profun){

            diagonalMenor = dMenor;
            diagonalMaior = dMaior;
            profundidade = profun;

            area = 0;
            volume = 0;
            perimetroDaBase = 0;

        }
        
        public void CalculaArea(){
            area = (diagonalMenor * diagonalMaior)/2;
        }

        public void CalculaVolume(){
            volume = ((diagonalMenor * diagonalMaior)/2) * profundidade;
        }

        public void CalculaPerimetroDaBase(){

            double x;
            double x1;

            x = (Math.Pow((diagonalMenor/2),2)) + (Math.Pow((diagonalMaior/2),2));
            x1 = Math.Sqrt(x);

            perimetroDaBase = 4 * x1;
        }

        public double get_area()
        {
            return area;
        }

        public double get_volume()
        {
            return volume;
        }

        public double get_perimetroDaBase()
        {
            return perimetroDaBase;
        }
    }
}