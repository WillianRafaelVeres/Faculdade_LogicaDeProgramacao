using System;

namespace DesafioM3
{
    class TrianguloEquilatero
    {
        private double altura;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetro;

        public TrianguloEquilatero(double h, double p){
            altura = h;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
        }

        
        public void CalculaArea(){
            area = ((altura * altura) / Math.Sqrt(3));
        }

        public void CalculaVolume(){
            volume = ((Math.Pow(altura,2)/3) * profundidade);
        }

        public void CalculaPerimetro(){ 
            perimetro = ( 3 * ( 2 * altura ) / Math.Sqrt(3));
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