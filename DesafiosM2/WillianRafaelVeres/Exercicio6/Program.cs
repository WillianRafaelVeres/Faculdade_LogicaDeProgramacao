//Victor e Willian - 20/10/2021
using System;

namespace Exercicio6
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
            // For de 2 loops
            for (int i = 0; i < 2; i++)
            {
                // Mensagem pedindo para digitar um número
                Console.Write("Digite um numero: ");
                // Armazena o que for digitado convertido para double no arrey de acordo com a posição do i(index)
                numeros[i] = double.Parse(Console.ReadLine());
            }

            // Se o segundo numero do arrey for 0
            if (numeros[1] == 0)
            {
                // index recebe 1
                int index = 1;

                // Cria um for do tamanho do index 
                for (int i = 0; i < index; i++)
                {
                    // Mostra mensagem
                    Console.Write("Valor inválido! Tente Novamente: ");
                    // Armazena o que for digitado convertido para double no segundo elemento do arrey
                    numeros[1] = double.Parse(Console.ReadLine());
                    // Se o segundo numero do arrey for 0
                    if(numeros[1] == 0){
                        // Acrescenta 1 no index
                        index ++;
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

            // Mostra mensagem
            Console.WriteLine("\nOs números digitados foram:");
            // For de 2 loops
            for (int i = 0; i < 2; i++)
            {
                // Mostra os numeros do arrey de acordo com o index convertido para string
                Console.WriteLine(numeros[i].ToString());
            }
            // Mostra na tela o resultado
            Console.WriteLine($"\nO resultado foi: {resultado}!\n");
        }
    }
}
