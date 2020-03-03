using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Caculando Poupança 2");

            double valorInvertido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            {
               // valorInvertido = valorInvertido + valorInvertido * 0.0036;
                valorInvertido *= 1.0036;
                Console.WriteLine("Após {0} meses, voçê terá R$:{1}", contadorMes, valorInvertido);    
            }



            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadLine();
        }
    }
}
