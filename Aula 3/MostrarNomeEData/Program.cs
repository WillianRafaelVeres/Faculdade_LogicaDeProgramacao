//Willian Rafael Veres - 23/08/2021
using System;

namespace MostrarNomeEData
{
    class Program
    {
        static void Main(string[] args)
        {
            string sobrenome = "";
            string dataNascimento = "";

            Console.Clear();

            Console.WriteLine("Mostrar sobrenome e data de nascimento!");
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento: ex:00/00/0000");
            dataNascimento = Console.ReadLine();

            Console.WriteLine($"Seu sobrenome é {sobrenome} e sua data de nascimento é {dataNascimento}!");
        }
    }
}
