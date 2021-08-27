//Willian Rafael Veres - 22/08/2021
using System;

namespace MostrarNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string sobrenome = "";

            Console.Clear();

            Console.WriteLine("Mostrar nome completo!");
            Console.WriteLine("Digite seu primeiro nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Nome: " + nome + " " + sobrenome);
        }
    }
}
