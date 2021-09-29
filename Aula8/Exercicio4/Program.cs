using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Programa de identificação de categoria!");
            IdentificacaoDeCategoria();

        }

        static void IdentificacaoDeCategoria(){

            int idade;
            string continuar;
            string respostaParaComparar;

            Console.Clear();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A idade digitada foi {idade} anos!");

            if(idade >= 5 && idade <= 7){
                Console.WriteLine("Esta idade se encaixa na categoria: INFANTIL A !");
            }
            else if(idade >= 8 && idade <= 10){
                Console.WriteLine("Esta idade se encaixa na categoria: INFANTIL B !");
            }
            else if(idade >= 11 && idade <= 13){
                Console.WriteLine("Esta idade se encaixa na categoria: JUVENIL A !");
            }
            else if(idade >= 14 && idade <= 17){
                Console.WriteLine("Esta idade se encaixa na categoria: JUVENIL B !");
            }
            else if(idade >= 18 && idade <= 65){
                Console.WriteLine("Esta idade se encaixa na categoria: SÊNIOR !");
            }
            else{
                Console.WriteLine("Está idade não se encaixa em nenhuma das nossas categorias!");
            }

            Console.WriteLine("\nDeseja digitar uma nova idade?");
            Console.WriteLine("Digite apenas Sim ou Não");
            continuar = Console.ReadLine();
            respostaParaComparar = continuar.ToUpper();

            if(respostaParaComparar == "SIM"){
                IdentificacaoDeCategoria();
            }

        }
    }
}
