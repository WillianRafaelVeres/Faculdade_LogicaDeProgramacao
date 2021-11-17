using System;

namespace DesafioM3
{
    class TrianguloRetangulo
    {
        private double altura;
        private double base1;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetro;

        public TrianguloRetangulo(double h, double base2, double p){
            altura = h;
            base1 = base2;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
        }
        
        public void CalculaArea(){
            area = (altura * base1 / 2);
        }

        public void CalculaVolume(){
            volume = (altura * base1 / 2) * profundidade;
        }

        public void CalculaPerimetro(){
            perimetro = 2 * Math.Sqrt((altura*altura)+(base1*base1)+altura+base1);
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