using System;

namespace DesafioM3
{
    class Cilindro
    {
        public static double raio;
        public static double altura;

        public static double CalculaVolume(double r, double h)
        {
            return (Math.PI * (r * r) * h);
        }

        public static double CalculaAreaDaBase(double h){
            return (Math.PI * (r * r));
        }

        public static double CalculaAreaLateral(double r, double h){
            return (2 * Math.PI * r * h);
        }

        public static double CalculaAreaTotal(double r, double h){
            return ((2 * Math.PI * (r * r)) + (2 * Math.PI * r * h));
        }

        public static double CalculaPerimetro(double r){
            return (2 * Math.PI * r);
        }
    }
}
