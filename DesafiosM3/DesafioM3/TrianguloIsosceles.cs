using System;

namespace DesafioM3
{
    class TrianguloIsosceles
    {
        public static double altura;
        public static double base1;
        public static double profundidade;
        
        public static double CalculaArea(double h, double base2){
            return (h * base2 / 2);
        }

        public static double CalculaVolume(double h, double base2, double profundidade){
            return (h * base2 / 2) * profundidade;
        }

        public static double CalculaPerimetro(double h, double base2){
            double resultado1;
            double resultado2;
            
            resultado1 = ((base2 / 2) * (base2 / 2));
            resultado2 = Math.Sqrt((h * h) + resultado1 + base2);

            return 2 * resultado2;

            // ---- RESULTADO ERRADO
        }
    }
}