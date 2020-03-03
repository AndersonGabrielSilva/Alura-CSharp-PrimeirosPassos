using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W_Desafio_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio opicional for");

            Console.WriteLine("Imprima todos os multiplos de 3 entre 1 e 100");
            for (int contador=0; contador<100; contador++)
            {
                if (contador% 3 == 0)
                {
                    Console.WriteLine("O numero: {0} é divisivel por 3", contador);
                }
            }

            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadLine();
        }
    }
}
