using System;

namespace DesafioM3
{
    class Esfera
    {
        public static double raio;
        
        public static double CalculaArea(double r){
            return (4 * Math.PI * (r * r));
        }

        public static double CalculaVolume(double r){
            return (4 * Math.PI * (Math.Pow(r,3)))/3;
        }
    }
}