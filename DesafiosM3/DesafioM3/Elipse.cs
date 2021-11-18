// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Elipse
    {
        // Variável que armazena o raio Maior da elipse
        private double raioMaior; //a
        // Variável que armazena o raio Menor da elipse
        private double raioMenor; //b

        // Variável que armazena a área da elipse
        private double area;
        // Variável que armazena o perimetro Aproximado da elipse
        private double perimetroAproximadoA;
        // Variável que armazena o perimetro Aproximado da elipse
        private double perimetroAproximadoB;
        // Variável que armazena o volume do prolato da elipse
        private double volumeProlato;
        // Variável que armazena o volume do oblato da elipse
        private double volumeOblato;
        // Variável que armazena a área do prolato da elipse
        private double areaProlato;
        // Variável que armazena a área do oblato da elipse
        private double areaOblato;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
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

        // Procedimento que calcula a área da elipse e armazena na variável de instância
        public void CalculaArea(){
            area = (Math.PI * (raioMaior * raioMenor));
        }
        // Procedimento que calcula o perimetro aproximado da elipse e armazena na variável de instância
        public void CalculaPerimetroAproximadoA(){
            perimetroAproximadoA = Math.PI * raioMaior * (2 - (Math.Pow(Math.E,2))/2 + 3*(Math.Pow(Math.E,4))/16);
        }
        // Procedimento que calcula o perimetro aproximado da elipse e armazena na variável de instância
        public void CalculaPerimetroAproximadoB(){
            perimetroAproximadoB = Math.PI * raioMenor * (2 - (Math.Pow(Math.E,2))/2 + 3*(Math.Pow(Math.E,4))/16);
        }
        // Procedimento que calcula o volume do prolato da elipse e armazena na variável de instância
        public void CalculaProlato(){
            volumeProlato = (4/3)* Math.PI * raioMaior * Math.Pow(raioMenor,2);
        }
        // Procedimento que calcula o volume do oblato da elipse e armazena na variável de instância
        public void CalculaOblato(){
            volumeOblato = (4/3)* Math.PI * Math.Pow(raioMaior,2) * raioMenor;
        }
        // Procedimento que calcula a área do prolato da elipse e armazena na variável de instância
        public void CalculaAreaProlato(){
            areaProlato = 2 * Math.PI * raioMenor * (raioMenor + raioMaior * (Math.Sin(Math.E))/Math.E);
        }
        // Procedimento que calcula a área do oblato da elipse e armazena na variável de instância
        public void CalculaAreaOblato(){
            areaOblato = Math.PI * (2*Math.Pow(raioMaior,2) + (Math.Pow(raioMenor,2)/Math.E)* Math.Log((1+Math.E)/(1-Math.E)));
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area(){
            return area; // retorna o valor da área
        }

        public double get_PerimetroAproximadoA(){
            return perimetroAproximadoA; // retorna o valor do perimetro aproximado
        }

        public double get_PerimetroAproximadoB(){
            return perimetroAproximadoB; // retorna o valor do perimetro aproximado
        }

        public double get_VolumeProlato(){
            return volumeProlato; // retorna o valor do volume Prolato
        }

        public double get_VolumeOblato(){
            return volumeOblato; // retorna o valor do volume Oblato
        }

        public double get_AreaProlato(){
            return areaProlato; // retorna o valor da área do Prolato
        }

        public double get_AreaOblato(){
            return areaOblato; // retorna o valor da área do Oblato
        }
        //---------------------------------------------------------------
    }
}