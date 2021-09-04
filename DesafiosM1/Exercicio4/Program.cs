// Victor e Willian - 04_09_2021
using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            double nota1; // Variável da nota 1
            double nota2; // Variável da nota 2
            double nota3; // Variável da nota 3
            double valorNota1; // Variável do valor da nota 1
            double valorNota2; // Variável do valor da nota 2
            double valorNota3; // Variável do valor da nota 3

            nota1 = LerNota(1); // Chama a função para ler nota e armazena em nota1
            nota2 = LerNota(2); // Chama a função para ler nota e armazena em nota2
            nota3 = LerNota(3); // Chama a função para ler nota e armazena em nota3

            valorNota1 = LerValorNota(1); // Chama a função para ler o valor da nota e armazena em valorNota1
            valorNota2 = LerValorNota(2); // Chama a função para ler o valor da nota e armazena em valorNota1
            valorNota3 = LerValorNota(3); // Chama a função para ler o valor da nota e armazena em valorNota1

            MediaTresNumeros(nota1, valorNota1, nota2, valorNota2, nota3, valorNota3); // Chama a função para a média e passa os parâmentros
        }

        static double LerNota(double numeroNota) // Função para ler nota
        {   
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Por favor, Digite a {numeroNota}º nota: "); // Mostra a mensagem solicitando a nota
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para double
        }

        static double LerValorNota(double numeroNota) // Função para ler o valor nota
        {   
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Por favor, Digite o valor da {numeroNota}º nota: "); // Mostra a mensagem solicitando o valor da nota
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para double
        }

        static void MediaTresNumeros(double nota1, double valorNota1, double nota2, double valorNota2, double nota3, double valorNota3) // Função para fazer a média ponderada de 3 números
        {
            double somaValorNota; // Variável da soma dos valores das notas
            double somaNotas; // Variável da soma das notas
            double totalNota1; // Variável da multiplicação da nota1 e valorNota1
            double totalNota2; // Variável da multiplicação da nota2 e valorNota2
            double totalNota3; // Variável da multiplicação da nota3 e valorNota3
            double notaFinal; // Valor nota final

            somaNotas = nota1*valorNota1 + nota2*valorNota2 + nota3*valorNota3; // Multiplica a nota pelos seus valores e armazena em somaNotas
            somaValorNota = valorNota1 + valorNota2 + valorNota3; // Soma os valores das notas e armazena em somaValorNota
            totalNota1 = nota1 * valorNota1; // multiplica a nota1 pelo valorNota1
            totalNota2 = nota2 * valorNota2; // multiplica a nota2 pelo valorNota2
            totalNota3 = nota3 * valorNota3; // multiplica a nota3 pelo valorNota3
            notaFinal = somaNotas / somaValorNota; // divide a somaNotas por somaValorNota
            Console.WriteLine(notaFinal); // Mostra a nota final na tela
        }
    }
}
