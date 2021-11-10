using System;

namespace DesafioM3
{
    class Circulo
    {
        public static double raio;
        
        public static double CalculaArea(double r){
            return (Math.PI * (r * r));
        }

        public static double CalculaPerimetro(double r){
            return (2 * Math.PI * r);
        }
    }
}