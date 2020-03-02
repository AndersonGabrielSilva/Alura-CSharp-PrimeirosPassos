using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 3 - Criando Variaveis Ponto Flutuante");

            double salario;
            salario = 1800.70;
            Console.WriteLine("" + salario);


            double idade;
            idade = 15 / 2;
            Console.WriteLine("Idade divido por 2 :" + idade);

            double idade2;
            idade2 = 15.0 / 2;
            Console.WriteLine("Idade divida por 2: " + idade2);

            Console.WriteLine(salario/idade);
            
            Console.WriteLine("Pressione qualquer tecla para sair.......");
            Console.ReadLine();
        }
    }
}
