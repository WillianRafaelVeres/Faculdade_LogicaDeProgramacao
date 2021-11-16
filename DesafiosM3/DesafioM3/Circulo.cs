using System;

namespace DesafioM3
{
    class Circulo
    {
        private double raio;

        private double area;
        private double perimetro;

        public Circulo(double r){

            raio = r;

            area = null;
            perimetro = null;

        }
        
        public void CalculaArea(){
            area = (Math.PI * (raio * raio));
        }

        public void CalculaPerimetro(){
            perimetro = (2 * Math.PI * raio);
        }

        public double get_area()
        {
            return area;
        }

        public double get_perimetro()
        {
            return perimetro;
        }

    }
}