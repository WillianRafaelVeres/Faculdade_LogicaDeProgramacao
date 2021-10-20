//Victor e Willian - 20/10/2021
using System;

namespace Exercicio2
{
    class Program
    {
        // Varialvel estática de continuar - Acessivel por todas as funções
        static bool continuar = true;
        // Varialvel estática do valor total - Acessivel por todas as funções
        static double valorTotal = 0;
        // Varialvel estática de quantidade - Acessivel por todas as funções
        static double quantidade = 0;

        static void Main(string[] args) // Programa principal
        {
            // Variável de código
            string codigo;

            // Função para limpar o terminal
            Console.Clear();

            // Loop while
            while(continuar == true){
                //Armazena o que for retornado da função em código
                codigo = LeituraEValidacao();
                //Armazena o que for retornado da função em quantidade
                quantidade = QuantidadeDeCompra();
                //Chama o procedimento passando o codigo como parâmetro
                ValorCodigo(codigo);
                //Chama o procedimento de Novo código
                NovoCodigo();
            }

            // Função para limpar o terminal
            Console.Clear();
            // Mostra na tela o valor total
            Console.WriteLine($"O valor total é: R$ {valorTotal},00");
        }

        //Função para leitura e validação
        static string LeituraEValidacao(){

            // Váriavel de código
            string codigo;

            // Mostra os códigos disponiveis
            Console.Write("\n ABCD \n XYPK \n KLMP \n QRST \n Digite o código:");
            // Armazena o que for diigtado em codigo
            codigo = Console.ReadLine();

            // Verifica de o que for digitado está entre os códigos disponiveis
            if(codigo == "ABCD" || codigo == "XYPK" || codigo == "KLMP" || codigo == "QRST"){
                // Retorna o código
                return codigo;
            }

            // Caso não esteja
            else{
                // Mostra mensagem pedindo um novo código
                Console.WriteLine("\nCódigo inválido! Tente novamente! \n");
                // Chama o procedimento de leitura e válidação
                LeituraEValidacao();
                // Retorna
                return "";
            }

        }

        // Função para verificar o valor do código
        static void ValorCodigo(string codigo){

            // Passa o código como parâmetro
            switch(codigo){

                // Caso seja ABCD
                case "ABCD":
                    // valor total recebe o resultado de quantidade vezes 100 
                    valorTotal += 100 * quantidade;
                    break; // Saí do loop

                // Caso seja XYPK
                case "XYPK":
                    // valor total recebe o resultado de quantidade vezes 200 
                    valorTotal += 200 * quantidade;
                    break; // Saí do loop

                // Caso seja KLMP
                case "KLMP":
                    // valor total recebe o resultado de quantidade vezes 300 
                    valorTotal += 300 * quantidade;
                    break; // Saí do loop
                
                // Caso seja QRST
                case "QRST":
                    // valor total recebe o resultado de quantidade vezes 1000 
                    valorTotal += 1000 * quantidade;
                    break; //Saí do loop
                    
            } 

        }

        // Função para adicionar um novo código
        static void NovoCodigo(){

            // Variavel de resposta
            string resposta;

            // Mostra mensagem perguntando se deseja adicionar um novo código
            Console.WriteLine("Deseja adicionar um novo código? (SIM/NAO)");
            // Armazena o que for digitado em resposta
            resposta = Console.ReadLine();

            // Se resposta for sim
            if (resposta == "SIM")
            {
                // continuar recebe true
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