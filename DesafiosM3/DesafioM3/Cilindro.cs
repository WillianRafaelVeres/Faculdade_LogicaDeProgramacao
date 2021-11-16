using System;

namespace DesafioM3
{
    public class Cilindro
    {
        private double raio;
        private double altura;
        private double volume;

        private double areaDaBase;
        private double areaLateal;
        private double areaTotal;
        private double perimetro;

        public Cilindro(double r, double a, double v){
            
            raio = r;
            altura = a;
            volume = v;

            areaDaBase = null;
            areaLateal = null;
            areaTotal = null;
            perimetro = null;

        }

        public void CalculaVolume()
        {
            areaDaBase = (Math.PI * (r * r) * h);
        }

        public void CalculaAreaDaBase(){
            areaLateal = (Math.PI * (r * r));
        }

        public void CalculaAreaLateral(){
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

//m4rc3lo - 12/11/2021
using System; // inclusão de Math / Console 
namespace M3
{

        // procedimento, calcula a área da esfera
        //armazena na variável de instância
        public void calcula_area()
        {
            area = 4 * Math.PI * Math.Pow(raio, 2);
        }
        //procedimento, calcula o volume da esfera
        //armazena na variável de isntância
        public void calcula_volume()
        {
            volume = (4 * Math.PI  * Math.Pow(raio, 3)) / 3;
        }

        // funções para acessar o valor das variáveis de instância
        public double  get_area()
        {
            return area; // retorna o valor da área 
        }
        public double get_volume()
        {
            return volume; //retorna o valor do volume
        }
        ///---------------------------------------------------------------
    }
}