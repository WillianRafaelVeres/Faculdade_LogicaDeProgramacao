using System;

namespace DesafioM3
{
    class Elipse
    {
        private double raioMaior; //a
        private double raioMenor; //b

        private double area;
        private double perimetroAproximadoA;
        private double perimetroAproximadoB;
        private double volumeProlato;
        private double volumeOblato;
        private double areaProlato;
        private double areaOblato;

        public Elipse(double rMaior, double rMenor){
            raioMaior = rMaior;
            raioMenor = rMenor;

            area = 0.0;
            perimetroAproximadoA = 0;
            perimetroAproximadoB = 0;
            volumeProlato = 0;
            volumeOblato = 0;
            areaProlato = 0;
            areaOblato = 0;
        }

        
        public void CalculaArea(){
            area = (Math.PI * (raioMaior * raioMenor));
        }
        public void CalculaPerimetroAproximadoA(){
            perimetroAproximadoA = Math.PI * raioMaior * (2 - (Math.Pow(Math.E,2))/2 + 3*(Math.Pow(Math.E,4))/16);
        }
        public void CalculaPerimetroAproximadoB(){
            perimetroAproximadoB = Math.PI * raioMenor * (2 - (Math.Pow(Math.E,2))/2 + 3*(Math.Pow(Math.E,4))/16);
        }
        public void CalculaProlato(){
            volumeProlato = (4/3)* Math.PI * raioMaior * Math.Pow(raioMenor,2);
        }
        public void CalculaOblato(){
            volumeOblato = (4/3)* Math.PI * Math.Pow(raioMaior,2) * raioMenor;
        }
        public void CalculaAreaProlato(){
            areaProlato = 2 * Math.PI * raioMenor * (raioMenor + raioMaior * (Math.Sin(Math.E))/Math.E);
        }
        public void CalculaAreaOblato(){
            areaOblato = Math.PI * (2*Math.Pow(raioMaior,2) + (Math.Pow(raioMenor,2)/Math.E)* Math.Log((1+Math.E)/(1-Math.E)));
        }
    }
}