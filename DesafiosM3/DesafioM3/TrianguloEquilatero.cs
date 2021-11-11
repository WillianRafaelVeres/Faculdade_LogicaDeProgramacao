using System;

namespace DesafioM3
{
    class TrianguloEquilatero
    {
        public static double altura;
        public static double profundidade;

        
        public static double CalculaArea(double h){
            return ((h * h) / Math.Sqrt(3));
        }

        public static double CalculaVolume(double h, double prof){
            return (((h * h)/3) * prof);
        }

        public static double CalculaPerimetro(double h){
            
            return ( 3 * ( 2 * h ) / Math.Sqrt(3));

        }
    }
}