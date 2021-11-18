using System;

namespace DesafioM3
{
    class Trapezio
    {
        private double altura;
        private double baseMaior;
        private double baseMenor;
        private double profundidade;

        private double area;
        private double volume;

        public Trapezio(double h, double bMaior, double bMenor, double p){
            altura = h;
            baseMaior = bMaior;
            baseMenor = bMenor;
            profundidade = p;

            area = 0;
            volume = 0;;
        }

        public void CalculaArea(){
            area = ((baseMenor + baseMaior)*altura)/2;
        }

        public void CalculaVolume(){
            volume = ((((baseMenor + baseMaior)* altura)/2) * profundidade * (baseMenor + baseMaior) / 2);
        }

        public double get_area()
        {
            return area;
        }

        public double get_volume()
        {
            return volume;
        }
    }
}