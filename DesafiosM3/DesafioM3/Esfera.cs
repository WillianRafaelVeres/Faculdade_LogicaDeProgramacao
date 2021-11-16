using System;

namespace DesafioM3
{
    class Esfera
    {
        private double raio;
        
        private double area;
        private double volume;

        public Esfera(double r){

            raio = r;

            area = null;
            volume = null;

        }

        public void CalculaArea(){
            area = (4 * Math.PI * (raio * raio));
        }

        public void CalculaVolume(){
            volume = (4 * Math.PI * (Math.Pow(raio,3)))/3;
        }

        public double get_area()
        {
            return area;
        }

        public double get_volume()
        {
            return volume;
        }
    }
}