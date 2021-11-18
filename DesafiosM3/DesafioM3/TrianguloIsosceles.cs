// Victor e Willian - 18_11_2021
using System;

namespace DesafioM3
{
    //início escopo da classe
    class TrianguloIsosceles
    {
        // Variável que armazena a altura do triângulo Isosceles
        private double altura;
        // Variável que armazena a base do triângulo Isosceles
        private double base1;
        // Variável que armazena a profundidade do triângulo Isosceles
        private double profundidade;

        // Variável que armazena a area do triângulo Isosceles
        private double area;
        // Variável que armazena o volume do triângulo Isosceles
        private double volume;
        // Variável que armazena o perímetro do triângulo Isosceles
        private double perimetro;

        // Cosntrutor - realizado sempre que se cria um objeto do tipo
        public TrianguloIsosceles(double h, double b, double p){
            altura = h;
            base1 = b;
            profundidade = p;

            area = 0;
            volume = 0;
            perimetro = 0;
        }
        
        // Procedimento que calcula a área do Triângulo Isosceles e armazena na variável de instância
        public void CalculaArea(){
            area = (altura * base1 / 2);
        }

        // Procedimento que calcula o volume do Triângulo Isosceles e armazena na variável de instância
        public void CalculaVolume(){
            volume = (altura * base1 / 2) * profundidade;
        }

        // Procedimento que calcula o perímetro do Triângulo Isosceles e armazena na variável de instância
        public void CalculaPerimetro(){
            double resultado1;
            double resultado2;
            
            resultado1 = ((base1 / 2) * (base1 / 2));
            resultado2 = Math.Sqrt((altura * altura) + resultado1 + base1);

            perimetro = 2 * resultado2;

            // ---- RESULTADO DIFERENTE
        }

        // funções para acessar o valor das variáveis de instância
        public double get_area()
        {
            return area; // retorna o valor da area
        }

        public double get_volume()
        {
            return volume; // retorna o valor do volume
        }

        public double get_perimetro()
        {
            return perimetro; // retorna o valor do perimetro
        }
        //---------------------------------------------------------------
    }
}