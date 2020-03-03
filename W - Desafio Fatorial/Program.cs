using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W___Desafio_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Desafio Fatorial");

            int fatorial = 1;

            for (int i=1; i < 11; i++)
            {
                //fatorial = fatorial * i;
                fatorial  *=  i;
                
                Console.WriteLine("Fatorial de " + i + " = "  + fatorial);
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine();

        }
    }
}
