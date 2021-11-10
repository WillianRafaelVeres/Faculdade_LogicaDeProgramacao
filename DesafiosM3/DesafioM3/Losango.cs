using System;

namespace DesafioM3
{
    class Losango
    {
        public static double diagonalMenor;
        public static double diagonalMaior;
        public static double profundidade;
        
        public static double CalculaArea(double diagonalMenor, double diagonalMaior){
            return (diagonalMenor * diagonalMaior)/2;
        }

        public static double CalculaVolume(double diagonalMenor, double diagonalMaior, double profundidade){
            return ((diagonalMenor * diagonalMaior)/2) * profundidade;
        }

        public static double CalculaPerimetroDaBase(double diagonalMenor){
            return 4 * diagonalMenor;
        }
    }
}