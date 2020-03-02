using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaractereseTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando o projeto 5 - Caracteres e Textos");

            //character
            char primeiraLetra = 'a';

            Console.WriteLine("Primeira Letra: " + primeiraLetra);

            //Convertendo numero para char
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //É possivel somar valores no tipo char 
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //É possivel adicionar numeros na variavel string
            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            //O @ é ultilizado para informar que tudo depois dos " é uma string ate encontrar uma outra "
            string cursosProgramacao = @"- .NET
- Java
- Javascript";

            
            Console.WriteLine( cursosProgramacao);





            

            Console.WriteLine("Pressione qualquer tecla para sair.....");
            Console.ReadLine();
        }
    }
}
