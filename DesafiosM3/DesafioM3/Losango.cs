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

            area = null;
            volume = null;
            perimetroDaBase = null;

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

            x = ((diagonalMenor*diagonalMenor)+(diagonalMaior*diagonalMaior));
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