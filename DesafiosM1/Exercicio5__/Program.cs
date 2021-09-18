// Victor e Willian - 04_09_2021
using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            double lado1; // Variável da lado 1
            double lado2; // Variável da lado 2
            double lado3; // Variável da lado 3

            lado1 = LerDouble("1"); // Chama a função para ler o lado 1 e armazena em lado1
            lado2 = LerDouble("2"); // Chama a função para ler o lado 2 e armazena em lado2
            lado3 = LerDouble("3"); // Chama a função para ler o lado 3 e armazena em lado3

            CalculaAreaTriangulo(lado1, lado2, lado3); // Chama a função de calculo de área passando os parâmetros
            
        }

        static double LerDouble(string lado) // Função para ler um double
        {
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Digite o lado {lado}:"); // Mostra a mensagem solicitando o valor do lado do triângulo
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para string
        }

        static void CalculaAreaTriangulo(double lado1,double lado2, double lado3) // Função para o calculo de área de um triângulo
        {
            double p; // Váriavel para o p(usado na conta)
            double resultado; // Váriavel do resultado sem a raiz quadrada
            double raizQuadrada; // Váriavel do resultado após a raiz quadrada
            p = (lado1 + lado2 + lado3) / 2; // Soma todos os lados e divide por 2 e armazena em p
            resultado = p*(p-lado1)*(p-lado2)*(p-lado3); // Subtrai os lados em p, multiplica e armazena em resultado
            raizQuadrada = Math.Sqrt(resultado); // Faz a raiz quadrada de resultado e armazena em raizQuadrada
            Console.WriteLine($"O resultado é {Math.Round(raizQuadrada, 2)}m²!"); // Apresenta na tela o resultado após a raiz quadrada com 2 casas decimais.
        }
    }
}
