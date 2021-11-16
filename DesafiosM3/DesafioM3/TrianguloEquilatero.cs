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

            area = null;
            volume = null;
            perimetro = null;
        }

        
        public void CalculaArea(){
            area = ((altura * altura) / Math.Sqrt(3));
        }

        public void CalculaVolume(){
            volume = (((altura * altura)/3) * profundidade);
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