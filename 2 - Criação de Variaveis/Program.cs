using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Criação_de_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 25 + 2;

            Console.WriteLine(idade);

            Console.WriteLine("Sua Idade é " + idade);


            Console.WriteLine("Sua idade multiplicada por 2 é: " + idade *2);

            Console.WriteLine("Precione qualquer tecla para sair .....");
            Console.ReadLine();
        }
    }
}
