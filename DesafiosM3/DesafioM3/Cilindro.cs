// Victor e Willian - 18_11_2021
using System;


namespace DesafioM3
{
    //início escopo da classe
    public class Cilindro
    {
        // Variável que armazena o raio do cilindro
        private double raio; 
        // Variável que armazena a altura do cilindro
        private double altura; 

        // Variável que armazena a área da base do cilindro
        private double areaDaBase;
        // Variável que armazena a área lateral do cilindro
        private double areaLateral;
        // Variável que armazena a área total do cilindro
        private double areaTotal;
        // Variável que armazena o perímetro do cilindro
        private double perimetro;
        // Variável que armazena o volume do cilindro
        private double volume;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Cilindro(double r, double h){
            
            raio = r;
            altura = h;
            
            volume = 0;
            areaDaBase = 0;
            areaLateral = 0;
            areaTotal = 0;
            perimetro = 0;

        }

        // Procedimento que calcula o volume do cilindro e armazena na variável de instância
        public void CalculaVolume()
        {
            volume = (Math.PI * (raio * raio) * altura);
        }

        // Procedimento que calcula a área da base do cilindro e armazena na variável de instância
        public void CalculaAreaDaBase(){
            areaDaBase = (Math.PI * (raio * raio));
        }

        // Procedimento que calcula a área lateral do cilindro e armazena na variável de instância
        public void CalculaAreaLateral(){
            areaLateral = (2 * Math.PI * raio * altura);
        }

        // Procedimento que calcula a área total do cilindro e armazena na variável de instância
        public void CalculaAreaTotal(){
            areaTotal = ((2 * Math.PI * (raio * raio)) + (2 * Math.PI * raio * altura));
        }

        // Procedimento que calcula o perimetro do cilindro e armazena na variável de instância
        public void CalculaPerimetro(){
            perimetro = (2 * Math.PI * raio);
        }

        // funções para acessar o valor das variáveis de instância
        public double get_areaDaBase()
        {
            return areaDaBase; // retorna o valor da área da base
        }

        public double get_areaLateral()
        {
            return areaLateral; // retorna o valor da área Lateral
        }

        public double get_areaTotal()
        {
            return areaTotal; // retorna o valor da área total
        }

        public double get_perimetro()
        {
            return perimetro; // retorna o valor do perimetro
        }

        public double get_volume()
        {
            return volume; // retorna o valor do volume
        }
        //---------------------------------------------------------------
    }
}