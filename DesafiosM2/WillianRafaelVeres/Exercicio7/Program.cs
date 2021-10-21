using System;

namespace Exercicio7
{
    class Program
    {
        // Arrey de 2 numeros - Acessivel por todas as funções
        static double[] numeros = new double[2];

        static void Main(string[] args) // Programa principal
        {
            // Variavel do resultado
            double resultado;

            // Função para limpar o terminal
            Console.Clear();
            // Procedimento para ler e validar os valores
            LerEValidarValores();
            // Armazena o valor do resultado retornado pela função
            resultado = Divisao();
            // Procedimento para mostrar o resultado (Passa o resultado como parâmetro)
            MostrarResultado(resultado);
        }

        // Função para Ler e validar os valores
        static void LerEValidarValores(){
            // Variavel index
            int i = 0;
            
            // Enquanto i for menor que 2
            while(i < 2){
                // Mensagem pedindo para digitar um número
                Console.Write("Digite um numero: ");
                // Armazena o que for digitado convertido para double no arrey de acordo com a posição do i(index)
                numeros[i] = double.Parse(Console.ReadLine());
                // Acrescenta 1 no i
                i++;
            }

            // Se o segundo numero do arrey for 0
            if (numeros[1] == 0)
            {

                // loop "infinito"
                while(true){
                    // Mostra mensagem
                    Console.Write("Valor inválido! Tente Novamente: ");
                    // Armazena o que for digitado convertido para double no segundo elemento do arrey
                    numeros[1] = double.Parse(Console.ReadLine());
                    // Se o segundo numero do arrey for diferente de 0
                    if(numeros[1] != 0){
                        // sai do loop
                        break;
                    }
                }
            }
        }

        // Função de divisão
        static double Divisao(){

            // Retorna o primeiro numero dividido pelo segundo
            return numeros[0]/numeros[1];

        }

        // Função para mostrar o resultado (Resultado como parâmetro)
        static void MostrarResultado(double resultado){
            // Variavel index
            int i = 0;

            // Mostra mensagem
            Console.WriteLine("\nOs números digitados foram:");
            // Enquanto i for menor que 2
            while(i < 2){
                // Mostra os numeros do arrey de acordo com o index convertido para string
                Console.WriteLine(numeros[i].ToString());
                // Acrescenta 1 no i
                i++;
            }
            // Mostra na tela o resultado
            Console.WriteLine($"\nO resultado foi: {resultado}!\n");
        }
    }
}
