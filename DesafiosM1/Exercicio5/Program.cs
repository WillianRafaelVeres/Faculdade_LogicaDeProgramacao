// Victor e Willian - 04_09_2021
using System;
using System.Math;


namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            float lado1; // Variável da lado 1
            float lado2; // Variável da lado 2
            float lado3; // Variável da lado 3

            lado1 = LerFloat(1); // Chama a função para ler o lado 1 e armazena em lado1
            lado2 = LerFloat(2); // Chama a função para ler o lado 2 e armazena em lado2
            lado3 = LerFloat(3); // Chama a função para ler o lado 3 e armazena em lado3

            CalculaAreaTriangulo(lado1, lado2, lado3);
            
        }

        static float LerFloat(string lado)
        {
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Digite o lado {lado}:"); // Mostra a mensagem solicitando o valor do lado do triângulo
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para string
        }

        static void CalculaAreaTriangulo(string lado1,string lado2, string lado3)
        {
            float p;
            float resultado;
            p = lado1 + lado2 + lado3;
            resultado = Sqrt(p*(p-lado1)*(p-lado2)*(p-lado3));
            Console.WriteLine($"O resultado é {resultado:2f}m²!");
        }
    }
}
