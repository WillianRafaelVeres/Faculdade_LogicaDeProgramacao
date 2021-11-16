using System;

namespace DesafioM3
{
    class Quadrado
    {
        private double altura;
        private double base1;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetro;

        public Quadrado(double h, double b, double p){

            altura = h;
            base1 = b;
            profundidade = p;

            area = null;
            volume = null;
            perimetro = null;

        }

        public static double CalculaArea(){
            area = altura * base1;
        }

        public static double CalculaVolume(){
            volume = altura * base1 * profundidade;
        }

        public static double CalculaPerimetro(){
            perimetro = (( 2 * altura ) + ( 2 * base1 ));
        }

        public double get_area()
        {
            return area;
        }

        public double get_volume()
        {
            return volume;
        }

        public double get_perimetro()
        {
            return perimetro;
        }
    }
}