using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Escopo_Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Aula 9 - Escopo");
            
            double salario = 3800;
            string usuario = "Anderson";

            if (salario>= 1900 && salario <=2800)
            {
                Console.WriteLine("Seu IR é de 7.5%");
                Console.WriteLine("Pode deduzir 142 Reais");
            }
            else if (salario>=2800 && salario<=3751)
            {
                Console.WriteLine("Seu IR é de 15%");
                Console.WriteLine("Pode deduzir 350 Reais");
            }
            else
            {

                Console.WriteLine("Seu IR é de 22.5");
                Console.WriteLine("Pode deduzir 636 Reais");            }
            {

            }

            Console.ReadLine();

     
        }
    }
}
