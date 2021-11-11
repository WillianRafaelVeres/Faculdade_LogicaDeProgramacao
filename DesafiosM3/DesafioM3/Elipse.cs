using System;

namespace DesafioM3
{
    class Elipse
    {
        public static double raioMaior; //a

        public static double raioMenor; //b
        
        public static double CalculaArea(double rMaior, double rMenor){
            return Math.PI * rMaior * rMenor;
        }

        /*
        public static double CalculaPerimetroAproximado(double rMaior, double rMenor){
            return Math.PI * rMaior * ()
        }*/

        public static double CalculaVolumeProlato(double rMaior, double rMenor){
            return ((4/3) * Math.PI * rMaior * (rMenor * rMenor));
        }

        public static double CalculaVolumeOblato(double rMaior, double rMenor){
            return ((4/3) * Math.PI * (rMaior * rMaior) * rMenor);
        }
    }
}