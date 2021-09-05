// Victor e Willian - 04_09_2021
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Comando para limpar o Terminal

            string nome = ""; // Variável do nome
            string sobrenome = ""; // Variável do sobrenome
            string nomeCompleto = ""; // Variável do nome completo
            int diaNascimento = 0; // Variável do dia de nascimento
            int mesNascimento = 0; // Variável do mês de nascimento
            int anoNascimento = 0; // Variável do ano de nascimento
            
            nome = LerString("nome"); // Chama a função para ler string e armazena em nome
            sobrenome = LerString("sobrenome");// Chama a função para ler string e armazena em sobrenome
            diaNascimento = LerInt("dia de nascimento"); // Chama a função para ler int e armazena em diaNascimento
            mesNascimento = LerInt("mês de nascimento"); // Chama a função para ler int e armazena em mesNascimento
            anoNascimento = LerInt("ano de nascimento"); // Chama a função para ler int e armazena em anoNascimento
            nomeCompleto = $"{nome} {sobrenome}"; // Concatena o nome e sobrenome e armazena em nomeCompleto
            Console.WriteLine($"O nome digitado foi {nomeCompleto} e a data foi {Convert.ToString(diaNascimento)}/{Convert.ToString(mesNascimento)}/{Convert.ToString(anoNascimento)} !"); //Mostra na tela o nome completo, junto com a data convertida para string

        }

        static string LerString(string dadoDesejado) // Função para ler string
        {
            Console.WriteLine($"Por favor, digite seu {dadoDesejado}: "); // Mostra a mensagem solicitando um dado
            return Console.ReadLine(); // Retorna o que for digitado
        }

        static int LerInt(string dadoDesejado) // Função para ler int
        {   
            string dadoRecebido = ""; // Variável do dado digitado
            Console.WriteLine($"Por favor, digite seu {dadoDesejado} (Em números): "); // Mostra a mensagem solicitando um dado
            dadoRecebido = Console.ReadLine();  // Armazena o dado digitado em dadoRecebido
            return Convert.ToInt32(dadoRecebido); // Retorna o dadoRecebido convertido para int
        }
    }
}
