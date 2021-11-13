//m4rc3lo - 12/11/2021
//exemplo de execução de vários problemas em um programa
using System;

namespace M3
{//inicio de escopo do namespace
    class Program
    {//inicio de escopo da classe Prgram
        
        //ponto de entrada do programa
        static void Main(string[] args)
        {
            menu(); // mostra opções

            //armazena em <escolha> o valor retornado
            //da função <leitura_opcao>
            int escolha = leitura_opcao();

            switch (escolha)
            {
                case 1:
                    //code
                    double raio = 0;
                    Console.WriteLine("Digitge o raio da Esfera");                    
                    Double.TryParse(Console.ReadLine(), out raio);

                    //cria um objeto <esfera>, do tipo esfera
                    Esfera esfera = new Esfera (raio);
                    //acessa métodos públicos
                    esfera.calcula_area();
                    esfera.calcula_volume();

                    //acessa valores das variáveis privadas
                    Console.WriteLine("Área: " + esfera.get_area());
                    Console.WriteLine("Volume: " + esfera.get_volume());
                    break; //interrompe a execução do bloco
                   
                case 2:
                    //code
                    Console.WriteLine("Não implementado ainda!");
                    //interrompe a execução do bloco
                    break;
                //...
                default:
                    break;
            }  
        }

        //procedimento que mostra as opções disponíveis
        //e o número correspondente
        static void menu()
        {
            // mostra mensagem do progrma
            Console.WriteLine("Calculadora Geométrica");
            // mostra opções
            Console.WriteLine("1 - Esfera; 2 - Cilindro; ...");
        }
        
        //função para leitura e conversão para número
        //da opcção a ser calculada
        static int leitura_opcao()
        {
            //para armazenar o valor numérico convertido
            //da leitura do texto a partir do teclado
            int opcao = 0; 
            //para o controle do laço de repetição
            bool ctrl = true;
            do
            {//início do esco do laço de repetição
                //variável do tipo texto para leitura do teclado
                string escolha = ""; 
                //mostra mensagem na tela
                Console.WriteLine ("Digite sua escolha:");
                //armazena em <escolha> o texto dgitado no teclado
                escolha = Console.ReadLine();
          
                //função que tenta converter o texto em <escolha>
                //em valor inteiro, se conseguir armazena em <opcao>
                //se não conseguir, caso o texto não represente um número
                //<opcao> não muda de valor e o progrma continua 
                Int32.TryParse(escolha, out opcao);          
                
                //testa de o valor em <opcao>
                //está entre uma das opções válidas
                if (opcao >= 1 && opcao <=1)
                {
                    //caso verdade, muda o valor de <ctrl> para falso
                    ctrl = false;
                }
                else
                {
                    //caso falso, limpa tela
                    Console.Clear();
                    //mostra mensagem de erro 
                    Console.WriteLine("Opção Invalida, Tente Novamente");
                    //chama o proceddimento que mostra as opções válidas
                    menu();
                }
            
            //se o valor de <ctrl> for flaso, sai do laço de repetição
            //se o valor de <ctrl> for verdadeiro, repete o bloco
            } while(ctrl);
            //quando sair do laço, retorna o valor em <opcao>
            return opcao;
        }
    }
}

