using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Programa de média");

            double nota1; // Variável da nota 1
            double nota2; // Variável da nota 2
            double nota3; // Variável da nota 3
            double nota4; // Variável da nota 3
            double nota5; // Variável da nota 3
            double nota6; // Variável da nota 3
            double notaFinal;

            nota1 = LerNota(1); // Chama a função para ler nota e armazena em nota1
            nota2 = LerNota(2); // Chama a função para ler nota e armazena em nota2
            nota3 = LerNota(3); // Chama a função para ler nota e armazena em nota3
            nota4 = LerNota(4); // Chama a função para ler nota e armazena em nota4
            nota5 = LerNota(5); // Chama a função para ler nota e armazena em nota5
            nota6 = LerNota(6); // Chama a função para ler nota e armazena em nota6

            notaFinal = MediaNumeros(nota1, nota2, nota3, nota4, nota5, nota6); // Chama a função para a média e passa os parâmentros
            VerificacaoDeSituacao(notaFinal);
        }

        static double LerNota(double numeroNota) // Função para ler nota
        {   
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Por favor, Digite a {numeroNota}º nota: "); // Mostra a mensagem solicitando a nota
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToDouble(dadoRecebido); // Retorna o dadoRecebido convertido para double
        }

        static double MediaNumeros(double nota1, double nota2, double nota3, double nota4, double nota5, double nota6) // Função para fazer a média ponderada de 6 números
        {
             return (((nota1 * 6 + nota2 * 4)/10) + ((nota3 * 6 + nota4 * 4)/10) + ((nota5 * 6 + nota6 * 4)/10)) / 3;
        }

        static void VerificacaoDeSituacao(double notaFinal){

            Console.WriteLine($"A sua média final é {Math.Round(notaFinal,2)}!");

            if(notaFinal >= 6){
                Console.WriteLine("Sua situação é Aprovado");
            }

            else{
                Console.WriteLine("Sua situação é Reprovado");
            }
        }
    }
}
