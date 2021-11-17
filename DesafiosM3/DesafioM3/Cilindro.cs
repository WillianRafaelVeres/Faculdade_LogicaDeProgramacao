using System;

namespace DesafioM3
{
    public class Cilindro
    {
        private double raio;
        private double altura;

        private double areaDaBase;
        private double areaLateral;
        private double areaTotal;
        private double perimetro;
        private double volume;

        public Cilindro(double r, double h){
            
            raio = r;
            altura = h;
            
            volume = 0;
            areaDaBase = 0;
            areaLateral = 0;
            areaTotal = 0;
            perimetro = 0;

        }

        public void CalculaVolume()
        {
            volume = (Math.PI * (raio * raio) * altura);
        }

        public void CalculaAreaDaBase(){
            areaDaBase = (Math.PI * (raio * raio));
        }

        public void CalculaAreaLateral(){
            areaLateral = (2 * Math.PI * raio * altura);
        }

        public void CalculaAreaTotal(){
            areaTotal = ((2 * Math.PI * (raio * raio)) + (2 * Math.PI * raio * altura));
        }

        public void CalculaPerimetro(){
            perimetro = (2 * Math.PI * raio);
        }

        public double get_areaDaBase()
        {
            return areaDaBase;
        }

        public double get_areaLateral()
        {
            return areaLateral;
        }

        public double get_areaTotal()
        {
            return areaTotal;
        }

        public double get_perimetro()
        {
            return perimetro;
        }

        public double get_volume()
        {
            return volume;
        }
    }
}