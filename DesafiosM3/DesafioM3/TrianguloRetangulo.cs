using System;

namespace DesafioM3
{
    class TrianguloRetangulo
    {
        public static double altura;
        public static double base1;
        public static double profundidade;
        
        public static double CalculaArea(double h, double base2){
            return (h * base2 / 2);
        }

        public static double CalculaVolume(double h, double base2, double profundidade){
            return (h * base2 / 2) * profundidade;
        }

        public static double CalculaPerimetro(double h, double base2){
            return 2 * Math.Sqrt((h*h)+(base2*base2)+h+base2);
        }
    }
}