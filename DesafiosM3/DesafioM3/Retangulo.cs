using System;

namespace DesafioM3
{
    class Retangulo
    {
        public static double altura;
        public static double base1;
        public static double profundidade;

        public static double CalculaArea(double h, double b){
            return h * b;
        }

        public static double CalculaVolume(double h, double b, double p){
            return h * b * p;
        }

        public static double CalculaPerimetro(double h, double b){
            return (( 2 * h ) + ( 2 * b ));
        }
    }
}