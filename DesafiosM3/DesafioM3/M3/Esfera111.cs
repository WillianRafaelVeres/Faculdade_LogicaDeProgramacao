//m4rc3lo - 12/11/2021
using System; // inclusão de Math / Console 
namespace M3
{
    public class Esfera
    {//início escopo da classe
        /// Estados ----------------------------------------------------
        //Variáveis de isntância 
        //cada objeto criado pode assumir valores diferentes
        private double raio; // armazena raio da esfera
        private double area; // armazena área da esfera
        private double volume; // armazena volume da esfera
        ///-------------------------------------------------------------


        /// Comportamentos (métodos)------------------------------------
       
        //Cosntrutor - realizado sempre que se cria um objeto do tipo
        public Esfera (double r)
        {
            raio = r;
            area = 0;
            volume = 0;
        }

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