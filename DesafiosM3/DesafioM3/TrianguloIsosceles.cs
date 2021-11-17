using System;

namespace DesafioM3
{
    class TrianguloIsosceles
    {
        private double altura;
        private double base1;
        private double profundidade;

        private double area;
        private double volume;
        private double perimetro;

        public TrianguloIsosceles(double h, double b, double p){
            altura = h;
            base1 = b;
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
            double resultado1;
            double resultado2;
            
            resultado1 = ((base1 / 2) * (base1 / 2));
            resultado2 = Math.Sqrt((altura * altura) + resultado1 + base1);

            perimetro = 2 * resultado2;

            // ---- RESULTADO ERRADO
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