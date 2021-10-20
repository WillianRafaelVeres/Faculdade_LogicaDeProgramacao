using System;

namespace Exercicio2
{
    class Program
    {
        static bool continuar = true;
        static double valorTotal = 0;
        static double quantidade = 0;

        static void Main(string[] args)
        {
            
            string codigo;

            Console.Clear();

            while(continuar == true){
                codigo = LeituraEValidacao();
                quantidade = QuantidadeDeCompra();
                ValorCodigo(codigo);
                NovoCodigo();
            }
            
            Console.Clear();
            Console.WriteLine($"O valor total é: R$ {Math.Round(valorTotal, 2)},00");
        }

        static string LeituraEValidacao(){

            string codigo;

            Console.Write("\n ABCD \n XYPK \n KLMP \n QRST \n Digite o código:");
            codigo = Console.ReadLine();


            if(codigo == "ABCD" || codigo == "XYPK" || codigo == "KLMP" || codigo == "QRST"){
                return codigo;
            }

            else{

                Console.WriteLine("\nCódigo inválido! Tente novamente! \n");
                LeituraEValidacao();
                return "";
            }

        }

        static void ValorCodigo(string codigo){

            switch(codigo){

                case "ABCD":
                    valorTotal += 100 * quantidade;
                    break;

                case "XYPK":
                    valorTotal += 200 * quantidade;
                    break;
                
                case "KLMP":
                    valorTotal += 300 * quantidade;
                    break;
                
                case "QRST":
                    valorTotal += 1000 * quantidade;
                    break;
                    
            } 

        }

        static void NovoCodigo(){

            string resposta;

            Console.WriteLine("Deseja adicionar um novo código? (SIM/NAO)");
            resposta = Console.ReadLine();

            if (resposta == "SIM")
            {
                continuar = true;
            }
            else if (resposta == "NAO")
            {
                continuar = false;
            }
            else{
                Console.WriteLine("ERRO! Digite Novamente!");
                NovoCodigo();
            }
        }

        static double QuantidadeDeCompra(){

            Console.Write("\nQuantidade: ");
            return double.Parse(Console.ReadLine());
        }
    }
}