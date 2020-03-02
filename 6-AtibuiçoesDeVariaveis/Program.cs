using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtibuiçoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 6 - Atribuição de variaveis");

            int idade = 25;
            int idadeAnderson = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeAnderson);



            Console.WriteLine("Pressione qualquer tecla para sair......");
            Console.ReadLine();
        }
    }
}
