using System;

namespace DesafioM3
{
    class Paralelogramo
    {
        private double altura;
        private double base1;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetro;

        public Paralelogramo(double h, double b, double p){

            altura = h;
            base1 = b;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;

        }

        public void CalculaArea(){
            area = altura * base1;
        }

        public void CalculaVolume(){
            volume = altura * base1 * profundidade;
        }

        public void CalculaPerimetro(){
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