// Victor e Willian - 04_09_2021
using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            string nome = ""; // Variável do nome
            string sobrenome = ""; // Variável do sobrenome
            string nomeCompleto = ""; // // Variável do nome completo

            nome = LerString("nome"); // Chama a função para ler string e armazena em nome
            sobrenome = LerString("sobrenome"); // Chama a função para ler string e armazena em sobrenome
            nomeCompleto = $"{nome} {sobrenome}"; // Concatena o nome e sobrenome e armazena em nomeCompleto
            Console.WriteLine($"O nome digitado foi {nomeCompleto}!"); // Mostra na tela o nome completo
        }

        static string LerString(string dadoDesejado) // Função para ler string
        {
            Console.WriteLine($"Por favor, digite seu {dadoDesejado}: "); // Mostra a mensagem solicitando um dado em string
            return Console.ReadLine(); // Retorna o que for digitado
        }
    }
}
