using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_ExercicioLacodeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execultando Exercicio - Laco de Repeticão 2");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna ++)
                     Console.Write("*");

                Console.WriteLine();
            }
            

            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadLine();
        }
    }
}
