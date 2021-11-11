using System;

namespace DesafioM3
{
    class Trapezio
    {
        public static double altura;
        public static double baseMaior;
        public static double baseMenor;
        public static double profundidade;

        public static double CalculaArea(double h, double bMaior, double bMenor){
            return ((bMenor + bMaior)*h)/2;
        }

        public static double CalculaVolume(double h, double bMaior, double bMenor, double profundidade){
            return (((bMenor + bMaior)* h) * profundidade * (bMenor + bMaior) / 2);
        }
    }
}