using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Conversoes_e_Outros_tipos_numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Projeto 4- Conversoes e outros tipos numericos");

            double salario = 1200.50;
               
            // Int é uma variavel de 32bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Salario em Ponto Flutuante: " + salario);
            Console.WriteLine("Salario em I nteiro: " + salarioEmInteiro);

            // Long é uma variavel de 64 bits
            long anoUniverso = 13000000000000000;

            // short é uma variavel de 16 bits
            short quantidadeProdutos = 15000;


            float altura = 1.98f;


            Console.WriteLine("Ano do universo em long: " + anoUniverso);
            Console.WriteLine("Quantidade dos produtos em short: " + quantidadeProdutos);
            Console.WriteLine("Altura em float: " + altura);

            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadLine();
        }
    }
}
