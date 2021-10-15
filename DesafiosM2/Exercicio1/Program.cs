using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaSaldo;

            Console.Clear();

            Console.WriteLine("Calculo de crédito");

            mediaSaldo = LerMediaSaldo();
            CalculaCredito(mediaSaldo);

        }

        static double LerMediaSaldo(){
            Console.Write("Digite o valor da média anual do saldo:");
            return double.Parse(Console.ReadLine());
        }

        static void CalculaCredito(double saldo){

            double valorCredito = 0;
            double valorTotal = 0;

            if (saldo <= 200)
            {
                Console.WriteLine("\nSeu saldo não se encaixa em nenhum crédito especial!");
                valorCredito = 0;
            }

            else if (saldo <= 400)
            {
                Console.WriteLine("\nSeu saldo se encaixa em 20% de crédito especial!");
                valorCredito = saldo * 20 / 100;
            }

            else if (saldo <= 600)
            {
                Console.WriteLine("\nSeu saldo se encaixa em 30% de crédito especial!");
                valorCredito = saldo * 30 / 100;
            }

            else if (saldo > 600)
            {
                Console.WriteLine("\nSeu saldo se encaixa em 40% de crédito especial!");
                valorCredito = saldo * 40 / 100;
            }

            valorTotal = valorCredito + saldo;

            Console.WriteLine($"Valor saldo: R${Math.Round(saldo,2)}");
            Console.WriteLine($"Valor do crédito especial: R${Math.Round(valorCredito)}");
            Console.WriteLine($"Valor total: R${Math.Round(valorTotal,2)}\n");

        }
    }
}
