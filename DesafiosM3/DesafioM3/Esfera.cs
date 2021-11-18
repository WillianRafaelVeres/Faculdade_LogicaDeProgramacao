// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class Esfera
    {
        // Variável que armazena o raio da esfera
        private double raio;
        
        // Variável que armazena a área da esfera
        private double area;
        // Variável que armazena o volume da esfera
        private double volume;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Esfera(double r){

            raio = r;

            area = 0;
            volume = 0;

        }

        // Procedimento que calcula a área da esfera e armazena na variável de instância
        public void CalculaArea(){
            area = (4 * Math.PI * (raio * raio));
        }

        // Procedimento que calcula o volume da esfera e armazena na variável de instância
        public void CalculaVolume(){
            volume = (4 * Math.PI * (Math.Pow(raio,3)))/3;
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area()
        {
            return area; // retorna o valor da área
        }

        public double get_volume()
        {
            return volume; // retorna o valor do volume
        }
        //---------------------------------------------------------------
    }
}