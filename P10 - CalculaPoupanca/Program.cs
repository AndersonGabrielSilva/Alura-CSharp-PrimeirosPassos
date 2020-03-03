using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execundo Projeto 10 - CAlculando Poupança");

            double valorInvertido = 1000;
            int contadorMes = 1;


            while (contadorMes<= 12)
            {
                valorInvertido = valorInvertido + valorInvertido * 0.0036;
                Console.WriteLine("Após {0} meses, voçê tera {1}",contadorMes,valorInvertido);
               
                //contadorMes = contadorMes +1;
                //contadorMes +=1;
                  contadorMes++;
            }

            
            Console.WriteLine("Pressione qualquer tecla para sair......");
            Console.ReadLine();
        }
    }
}
