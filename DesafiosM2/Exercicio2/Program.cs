using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            LeituraEValidacao();
            
        }

        static string LeituraEValidacao(){

            string codigo;

            Console.Write("Digite o código:");
            codigo = Console.ReadLine();

            if(codigo == "ABCD" || codigo == "XYPK" || codigo == "KLMP" || codigo == "QRST"){
                Console.WriteLine("Tudo certo");
                return codigo;
            }

            else{

                Console.WriteLine("Código inválido! Tente novamente! \n");
                LeituraEValidacao();
            }

            /*02) Um vendedor precisa de um programa que calcule o preço total devido por um cliente. O
            algoritmo deve receber o código de um produto e a quantidade comprada e calcular o preço
                total, usando a tabela abaixo. Mostre uma mensagem no caso de código inválido. Código
            Preço Unitário 'ABCD' R$100 'XYPK' R$ 200 'KLMP' R$400 'QRST' R$ 1000.
            Código Valor
            ABCD 100
            XYPK 200
            KLMP 400
            QRST 1000*/

        }

    }
}