using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLacodeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Exercicio For Encadeado 2");

            for (int multiplicador = 1; multiplicador <=10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + "X" + contador + "=" +multiplicador*contador );
                    Console.WriteLine();
                }
                Console.WriteLine() ;
            }

            Console.WriteLine("Pressione qualquer tecla para sair.....");
            Console.ReadLine();
        }
    }
}
