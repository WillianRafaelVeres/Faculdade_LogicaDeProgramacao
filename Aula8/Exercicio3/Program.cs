using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas;
            int[] notasComMedia4;
            int[] notasComMedia6;
            int[] soma;
            int contador = 1;
            int contador2 = 0;
            int notaFinal = 0;

            Console.Clear();

            while(contador < 7){
                Console.WriteLine($"Digite a nota {contador}");
                notas.add(Convert.ToInt32(Console.ReadLine()));
                contador++;
            }

            while(contador2 < 6){
                
                if(contador%2 == 0){
                    notasComMedia4.add(notas[contador2]);
                }

                else{
                    notasComMedia6.add(notas[contador2]);
                }
                contador2++;
            }

            while(contador2 < 3){
                soma.add((notasComMedia4[contador2]*4 + notasComMedia6[contador2]*6)/10);
            }

            foreach(int nota in soma){
                notaFinal += nota;
            }

            notaFinal = notaFinal / 3;

            Console.WriteLine(notaFinal);






            foreach( int nota in notas){
                
            }


        }
    }
}
