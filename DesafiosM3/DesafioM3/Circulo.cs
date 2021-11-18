// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Circulo
    {
        // Variável que armazena o raio do círculo
        private double raio;

        // Variável que armazena a area do círculo
        private double area;
        // Variável que armazena o perimetro do círculo
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Circulo(double r){

            raio = r;

            area = 0;
            perimetro = 0;

        }
        
        // Procedimento que calcula a área do circulo e armazena na variável de instância
        public void CalculaArea(){
            area = (Math.PI * (raio * raio));
        }

        // Procedimento que calcula o perímetro do circulo e armazena na variável de instância
        public void CalculaPerimetro(){
            perimetro = (2 * Math.PI * raio);
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area()
        {
            return area; // retorna o valor da área
        }

        public double get_perimetro()
        {
            return perimetro; // retorna o valor do perimetro
        }
        //---------------------------------------------------------------
    }
}